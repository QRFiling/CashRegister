using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;

namespace СashRegister
{
    public partial class BarcodeInputForm : Form
    {
        public BarcodeInputForm()
        {
            InitializeComponent();
        }

        void BarcodeField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        void BarcodeField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = e.SuppressKeyPress = true;
                BarcodeField.Enabled = false;
                Close();
            }
        }

        BarcodeWriter writer = new BarcodeWriter();
        BarcodeFormat format;

        void BarcodeField_TextChanged(object sender, System.EventArgs e)
        {
            if (BarcodeField.TextLength == 7 || BarcodeField.TextLength == 8) format = BarcodeFormat.EAN_8;
            else if (BarcodeField.TextLength == 12 || BarcodeField.TextLength == 13) format = BarcodeFormat.EAN_13;
            else
            {
                BarcodePreview.Image = null;
                return;
            }

            writer.Options = new EncodingOptions
            {
                Width = BarcodePreview.Width,
                Height = BarcodePreview.Height,
                PureBarcode = true
            };

            try
            {
                writer.Format = format;
                BarcodePreview.Image = writer.Write(BarcodeField.Text);
            }
            catch { BarcodePreview.Image = null; }
        }

        void BarcodePreview_Paint(object sender, PaintEventArgs e)
        {
            if (BarcodePreview.Image == null)
            {
                using (HatchBrush brush = new HatchBrush(HatchStyle.BackwardDiagonal, Color.FromArgb(235, 235, 235), BarcodePreview.BackColor))
                    e.Graphics.FillRectangle(brush, e.ClipRectangle);

                using (Font font = new Font("Segoe UI", 9))
                {
                    using (var f = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
                        e.Graphics.DrawString("Не удалось создать предпросмотр штрих-кода", font, Brushes.DimGray, e.ClipRectangle, f);
                }
            }
        }
    }
}
