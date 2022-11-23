using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace СashRegister
{
    public partial class ProductCheckForm : Form
    {
        public decimal Total { get; set; }
        public decimal Change { get; set; }
        public Form1.Product[] Products { get; set; }

        public ProductCheckForm()
        {
            InitializeComponent();
        }

        string CheckText = string.Empty;
        Bitmap QRcode = new Bitmap(1, 1);

        void ProductCheckForm_Load(object sender, EventArgs e)
        {
            string nl = Environment.NewLine;
            string products = string.Join(nl, Products.Select(s => $"{s.Name} (Штрих-код: {s.Barcode}){nl}[b]= {s.Price} руб{nl}"));

            CheckText = $"[c]ДОБРО ПОЖАЛОВАТЬ!{nl}==={nl}" +
                        $"[c]{RegionInfo.CurrentRegion.DisplayName}, {RegionInfo.CurrentRegion.Name}{nl}" +
                        $"{Environment.OSVersion}{nl}{nl}{nl}" +
                        $"[c]КАССОВЫЙ ЧЕК{nl}" +
                        $"GUID операции: {Guid.NewGuid()}{nl}" +
                        $"Дата операции: {DateTime.Now:F}{nl}==={nl}" +
                        $"{products}{nl}==={nl}" +
                        $"[b]ИТОГО: = {Total} руб{nl}" +
                        $"Оплата наличными: {Total + Change} руб{nl}" +
                        $"Сдача: {Change} руб{nl}==={nl}" +
                        $"[c]СПАСИБО ЗА ПОКУПКУ!";

            try
            {
                ZXing.BarcodeWriter writer = new ZXing.BarcodeWriter
                {
                    Options = { Width = 100, Height = 100, Margin = 0 },
                    Format = ZXing.BarcodeFormat.QR_CODE
                };

                QRcode = writer.Write($"Purchase for {DateTime.Now:dd:MM:yyyy}." +
                    $" Total: {Total} rub");
            }
            catch { }

            MaximumSize = new Size(Width, Screen.PrimaryScreen.WorkingArea.Height - 200);
        }

        void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            RectangleF bounds = ClientRectangle;
            bounds.Inflate(-15, -15);

            using (Font font = new Font(Form1.ProductCheckFont, 8))
            {
                using (Font bigFont = new Font(Form1.ProductCheckFont, 10, FontStyle.Bold))
                {
                    using (StringFormat format = new StringFormat() { })
                    {
                        foreach (var item in CheckText.Split(new string[] { Environment.NewLine }, StringSplitOptions.None))
                        {
                            string prefix = item.StartsWith("[") ? item.Substring(1).Remove(1) : string.Empty;
                            string line = string.IsNullOrEmpty(prefix) ? item : item.Substring(3);

                            if (prefix == "c") format.Alignment = StringAlignment.Center;
                            else format.Alignment = StringAlignment.Near;

                            if (item == "===")
                                line = new string('=', 30);

                            e.Graphics.DrawString(line + Environment.NewLine, prefix == "b" ? bigFont : font, Brushes.Black, bounds, format);
                            bounds.Y += e.Graphics.MeasureString(line, prefix == "b" ? bigFont : font, bounds.Size, format).Height + 2;
                        }
                    }
                }
            }

            e.Graphics.DrawImage(QRcode, bounds.Width / 2 - QRcode.Width / 2, bounds.Y + 20);
            pictureBox1.Height = (int)bounds.Y + 20 + QRcode.Height;
            Height = pictureBox1.Height + 100;
        }
    }
}
