using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Media;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using СashRegister.Properties;

namespace СashRegister
{
    public partial class Form1 : Form
    {        
        public Form1()
        {
            InitializeComponent();
            ControlsSettings();
            OpenConnection();
            LoadFontFromResources();
        }

        void ControlsSettings()
        {
            foreach (var item in GetAll(this, typeof(Button)))
                item.GotFocus += (s, e) => ProductPreview.Focus();
        }

        IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();
            return controls.SelectMany(ctrl => GetAll(ctrl, type)).Concat(controls).Where(c => c.GetType() == type);
        }

        public static FontFamily ProductCheckFont = null;

        void LoadFontFromResources()
        {
            using (PrivateFontCollection collection = new PrivateFontCollection())
            {
                using (Stream fontStream = new MemoryStream(Resources.amc100f))
                {
                    IntPtr data = Marshal.AllocCoTaskMem((int)fontStream.Length);
                    byte[] fontdata = new byte[fontStream.Length];
                    fontStream.Read(fontdata, 0, (int)fontStream.Length);
                    Marshal.Copy(fontdata, 0, data, (int)fontStream.Length);
                    collection.AddMemoryFont(data, (int)fontStream.Length);

                    fontStream.Close();
                    Marshal.FreeCoTaskMem(data);

                    ProductCheckFont = collection.Families[0];
                }
            }
        }

        async void OpenConnection()
        {
            TcpClient client;
            TcpListener listener;
            IPEndPoint ep;

            IPAddress[] localIp = Dns.GetHostAddresses(Dns.GetHostName());
            string ipString = string.Empty;

            foreach (IPAddress address in localIp)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                    ipString = address.ToString();
            }

            ep = new IPEndPoint(IPAddress.Parse(ipString), new Random().Next(1000, 9999));
            listener = new TcpListener(ep);
            listener.Start();
            WriteToConnectionLog($"Сервер открыл подключение.");

            IpLabel.Text = $"IP: {ep.Address}";
            PortLabel.Text = $"Порт: {ep.Port}";

            client = await listener.AcceptTcpClientAsync();
            WriteToConnectionLog("Подключён к клиентскому приложению!");

            using (StreamReader reader = new StreamReader(client.GetStream()))
            {
                while (client.Connected)
                {
                    await Task.Run(() =>
                    {
                        try
                        {
                            string line = reader.ReadLine();

                            if (!string.IsNullOrEmpty(line))
                            {
                                string[] data = line.Split(';');

                                if (data[0] == "0")
                                {
                                    DeviceName.Text = data[1];
                                    DeviceAndroidVersion.Text = $"Андроид {data[2]}";

                                    panel2.Height = 170;
                                    pictureBox1.Invalidate();
                                }
                                else if (data[0] == "1")
                                {
                                    WriteToConnectionLog($"Распознан штрих-код: {data[1]}");
                                    BarcodeRecognized(data[1], data[2], true);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            client.Close();
                            WriteToConnectionLog("Произошла ошибка. Подключение остановленно." + ex.Message, true);

                            DeviceName.Text = string.Empty;
                            DeviceAndroidVersion.Text = string.Empty;

                            panel2.Height = 70;
                            pictureBox1.Invalidate();
                        }
                    });
                }
            }
        }

        void WriteToConnectionLog(string message, bool error = false)
        {
            ConnectionLogList.Items.Add(new ListViewItem(new string[] { DateTime.Now.ToString("t"), message }));
            if (error) ConnectionLogList.Items[ConnectionLogList.Items.Count - 1].ForeColor = Color.Red;
            ConnectionLogList.EnsureVisible(ConnectionLogList.Items.Count - 1);
        }

        GraphicsPath RoundedRect(Rectangle bounds, int radius)
        {
            int diameter = radius * 2;
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(bounds.Location, size);
            GraphicsPath path = new GraphicsPath();

            if (radius == 0)
            {
                path.AddRectangle(bounds);
                return path;
            }

            path.AddArc(arc, 180, 90);

            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);

            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
        }

        void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (!string.IsNullOrEmpty(DeviceName.Text))
            {
                using (GraphicsPath path = RoundedRect(new Rectangle(5, 5, pictureBox1.Width - 10, pictureBox1.Height - 10), 10))
                {
                    e.Graphics.FillPath(Brushes.Silver, path);

                    using (Pen pen = new Pen(Color.Black, 5))
                        e.Graphics.DrawPath(pen, path);
                }
            }
        }

        public class Product
        {
            public string Name { get; set; }
            public string ImageUrl { get; set; }
            public decimal Price { get; set; }
            public string Barcode { get; set; }
            public string BarcodeFormat { get; set; }
            public string WebLink { get; set; }
        }

        async void BarcodeRecognized(string barcode, string type, bool beepSound)
        {
            if (beepSound) Console.Beep(850, 250);
            Tuple<string, string, decimal, string> result = await GetProductByBarcode(barcode);

            if (result != null)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    (ProductsList.Items.Count + 1).ToString(),
                    result.Item1,
                    $"{(result.Item3 <= 0 ? "?" : result.Item3.ToString())} руб",
                    DateTime.Now.ToString("T")
                });

                if (result.Item3 <= 0)
                {
                    item.UseItemStyleForSubItems = false;
                    item.SubItems[2].ForeColor = Color.Tomato;
                }

                item.Tag = new Product
                {
                    Name = result.Item1,
                    ImageUrl = result.Item2,
                    Price = result.Item3,
                    Barcode = barcode,
                    BarcodeFormat = type,
                    WebLink = result.Item4
                };

                ProductsList.Items.Add(item);
                item.Selected = true;
                WriteToOperationsLog($"Добавлен новый товар ({barcode})", Color.Gray);
            }
            else
            {
                WriteToOperationsLog($"Товар не найден в базе ({barcode})", Color.DarkGoldenrod);
                SystemSounds.Hand.Play();
            }
        }

        async Task<Tuple<string, string, decimal, string>> GetProductByBarcode(string barcode)
        {
            using (WebClient web = new WebClient() { Encoding = Encoding.UTF8 })
            {
                try
                {
                    string url = $"https://priceguard.ru/search?q={barcode}";
                    string responce = await web.DownloadStringTaskAsync(url);

                    var m = Regex.Matches(responce, $@"(?s)<div[^>]*?class={"\"or-title mr5\""}[^>]*?>(.*?)</div>");
                    string name = m[0].Value.Substring(m[0].Value.IndexOf(">") + 1, m[0].Value.LastIndexOf("<") - m[0].Value.IndexOf(">") - 1);

                    string webLink = string.Empty;

                    for (int i = m[0].Index - 4; i > 0 && responce[i] != '\"'; i--)
                        webLink = webLink.Insert(0, responce[i].ToString());

                    webLink = $"https://priceguard.ru{webLink.Substring(1)}";

                    var m2 = Regex.Matches(responce, @"<(?<Tag_Name>(a)|img)\b[^>]*?\b(?<URL_Type>(?(1)href|src))\s*=\s*(?:""(?<URL>(?:\\""|[^""])*)""|'(?<URL>(?:\\'|[^'])*)')");
                    string image = m2.OfType<Match>().Where(w => w.Groups[0].Value.Contains("or-image")).Select(s => s.Groups[4].Value).First();

                    var m3 = Regex.Matches(responce, $@"(?s)<div[^>]*?class={"\"or-price nw\""}[^>]*?>(.*?)</div>");
                    string priceString = m3[0].Value.Substring(m3[0].Value.IndexOf(">") + 1, m3[0].Value.LastIndexOf("<") - m3[0].Value.IndexOf(">") - 1);

                    decimal.TryParse(priceString, NumberStyles.Number, CultureInfo.InvariantCulture, out decimal price);
                    return new Tuple<string, string, decimal, string>(name, image, price, webLink);
                }
                catch { return null; }
            }
        }

        void OpenProductInWeb_Click(object sender, EventArgs e)
        {
            Product p = ProductsList.SelectedItems[0].Tag as Product;
            Process.Start(p.WebLink);
        }

        void RemoveProduct_Click(object sender, EventArgs e)
        {
            WriteToOperationsLog($"Товар удалён из списка ({((Product)ProductsList.SelectedItems[0].Tag).Barcode})", Color.Gray);
            ProductsList.Items.Remove(ProductsList.SelectedItems[0]);
            ProductsList_SelectedIndexChanged(null, null);
        }

        decimal TotalPrice = 0;

        void ProductsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProductsList.SelectedItems.Count > 0)
            {
                Product p = ProductsList.SelectedItems[0].Tag as Product;

                ProductPreview.ImageLocation = p.ImageUrl;
                ProductNameLabel.Text = p.Name;
                BarcodeLabel.Text = p.Barcode;
                BarcodeFormatLabel.Text = p.BarcodeFormat;
                ProductPriceLabel.Text = $"Цена: {(p.Price <= 0 ? "?" : p.Price.ToString())} руб";

                OpenProductInWeb.Enabled = true;
                RemoveProduct.Enabled = true;
            }
            else
            {
                ProductPreview.Image = null;
                ProductNameLabel.Text = "Название продукта";
                ProductPriceLabel.Text = "Цена: -";
                BarcodeLabel.Text = string.Empty;
                BarcodeFormatLabel.Text = "Тип";

                OpenProductInWeb.Enabled = false;
                RemoveProduct.Enabled = false;
            }

            TotalPrice = 0;

            for (int i = 0; i < ProductsList.Items.Count; i++)
            {
                ProductsList.Items[i].SubItems[0].Text = (i + 1).ToString();
                TotalPrice += ((Product)ProductsList.Items[i].Tag).Price;
            }

            TotalSumLabel.Text = $"Итого {TotalPrice} руб";
            PaymentButton.Enabled = TotalPrice > 0;
        }

        void AddProductButton_Click(object sender, EventArgs e)
        {
            using (BarcodeInputForm input = new BarcodeInputForm())
            {
                input.ShowDialog();

                if (!input.BarcodeField.Enabled)
                    BarcodeRecognized(input.BarcodeField.Text, "Тип?", false);
            }
        }

        void OpenCalc_Click(object sender, EventArgs e) => Process.Start("calc.exe");
        void OpenPriceguardButton_Click(object sender, EventArgs e) => Process.Start("https://priceguard.ru");

        public void WriteToOperationsLog(string message, Color color)
        {
            OperationsLogList.Items.Add(new ListViewItem(new string[] { DateTime.Now.ToString("t"), message }));
            OperationsLogList.Items[OperationsLogList.Items.Count - 1].ForeColor = color;
            OperationsLogList.EnsureVisible(OperationsLogList.Items.Count - 1);
        }

        SoundPlayer player = new SoundPlayer(Resources.PaymentSoundEffect);
        int PaymentCount = 0;
        decimal Profit = 0;

        async void PaymentButton_Click(object sender, EventArgs e)
        {
            using (Payment payment = new Payment() { TotalSum = TotalPrice, ProductCount = ProductsList.Items.Count })
            {
                payment.ShowDialog();
                if (payment.PaymentInvalid || payment.ReceivedTextBox.Enabled) return;

                WriteToOperationsLog($"Прошла оплата (Сумма: {TotalPrice} руб | Сдача: {payment.Receive - TotalPrice} руб " +
                    $"| Кол. товаров: {ProductsList.Items.Count})", Color.DodgerBlue);

                PaymentCount++;
                Profit += TotalPrice;

                StatisticLabel.Text = $"Оплат проведено: {PaymentCount}" +
                    $"{Environment.NewLine}Прибыль: {Profit} руб";

                player.Play();

                if (payment.PrintCheck)
                {
                    ProductCheckForm checkForm = new ProductCheckForm
                    {
                        Owner = this,
                        Products = ProductsList.Items.OfType<ListViewItem>().Select(s => (Product)s.Tag).ToArray(),
                        Total = TotalPrice,
                        Change = payment.Receive - TotalPrice
                    };

                    await Task.Delay(500);
                    checkForm.Show();
                }

                TotalPrice = 0;
                ProductsList.Items.Clear();
                ProductsList_SelectedIndexChanged(null, null);
            }
        }
    }
}
