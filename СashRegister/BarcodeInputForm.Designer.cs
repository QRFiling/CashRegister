
namespace СashRegister
{
    partial class BarcodeInputForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BarcodeField = new System.Windows.Forms.TextBox();
            this.BarcodePreview = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.BarcodePreview)).BeginInit();
            this.SuspendLayout();
            // 
            // BarcodeField
            // 
            this.BarcodeField.BackColor = System.Drawing.Color.White;
            this.BarcodeField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BarcodeField.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.BarcodeField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BarcodeField.Location = new System.Drawing.Point(64, 162);
            this.BarcodeField.Name = "BarcodeField";
            this.BarcodeField.Size = new System.Drawing.Size(516, 25);
            this.BarcodeField.TabIndex = 1;
            this.BarcodeField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BarcodeField.TextChanged += new System.EventHandler(this.BarcodeField_TextChanged);
            this.BarcodeField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BarcodeField_KeyDown);
            this.BarcodeField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BarcodeField_KeyPress);
            // 
            // BarcodePreview
            // 
            this.BarcodePreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.BarcodePreview.Location = new System.Drawing.Point(64, 32);
            this.BarcodePreview.Name = "BarcodePreview";
            this.BarcodePreview.Size = new System.Drawing.Size(516, 110);
            this.BarcodePreview.TabIndex = 2;
            this.BarcodePreview.TabStop = false;
            this.BarcodePreview.Paint += new System.Windows.Forms.PaintEventHandler(this.BarcodePreview_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(64, 190);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(516, 2);
            this.panel1.TabIndex = 4;
            // 
            // BarcodeInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(651, 225);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BarcodePreview);
            this.Controls.Add(this.BarcodeField);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BarcodeInputForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ручной ввод штрих-кода";
            ((System.ComponentModel.ISupportInitialize)(this.BarcodePreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox BarcodeField;
        private System.Windows.Forms.PictureBox BarcodePreview;
        private System.Windows.Forms.Panel panel1;
    }
}