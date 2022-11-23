using System;
using System.Globalization;
using System.Windows.Forms;

namespace СashRegister
{
    public partial class Payment : Form
    {
        public decimal TotalSum = 0;
        public int ProductCount = 0;

        public Payment()
        {
            InitializeComponent();
            Load += (s, e) => ControlsSettings();
        }

        public bool PrintCheck = true;

        void ControlsSettings()
        {
            Shown += (s, e) => ReceivedTextBox.Focus();
            SumTextBox.Text = $"{TotalSum} руб";

            timer1_Tick(null, null);
            timer1.Start();

            ChangePrintCheckState.GotFocus += (s, e) => ReceivedTextBox.Focus();
            ChangePrintCheckState.Click += (s, e) =>
            {
                ChangePrintCheckState.Text = PrintCheck ? "Без печати чека" : "С печатью чека";
                PrintCheck = !PrintCheck;
            };
        }

        void timer1_Tick(object sender, EventArgs e)
        {
            PaymentInfo.Text = $"Дата проведения операции: {DateTime.Now:F}" +
                $"     |     Количество товаров: {ProductCount}";
        }

        void ReceivedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;

            if (e.KeyChar == ',')
            {
                ReceivedTextBox.Text += ".";
                ReceivedTextBox.SelectionStart = ReceivedTextBox.TextLength;
            }
        }

        public bool PaymentInvalid = true;
        public decimal Receive;

        void ReceivedTextBox_TextChanged(object sender, EventArgs e)
        {
            decimal.TryParse(ReceivedTextBox.Text, NumberStyles.Number,
                CultureInfo.InvariantCulture, out Receive);

            if (Receive >= TotalSum)
            {
                ChangeTextBox.Text = $"{Receive - TotalSum} руб";
                PaymentInvalid = false;
            }
            else
            {
                ChangeTextBox.Text = "0 руб";
                PaymentInvalid = true;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                if (!PaymentInvalid)
                {
                    ReceivedTextBox.Enabled = false;
                    Close();
                }
                else
                {
                    Console.Beep(4000, 200);
                    Console.Beep(4000, 200);
                }
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
