
namespace СashRegister
{
    partial class Payment
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SumTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ReceivedTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ChangeTextBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PaymentInfo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ChangePrintCheckState = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.SumTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(25, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 95);
            this.panel1.TabIndex = 0;
            // 
            // SumTextBox
            // 
            this.SumTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SumTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SumTextBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.SumTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.SumTextBox.Location = new System.Drawing.Point(34, 42);
            this.SumTextBox.Name = "SumTextBox";
            this.SumTextBox.ReadOnly = true;
            this.SumTextBox.Size = new System.Drawing.Size(230, 32);
            this.SumTextBox.TabIndex = 1;
            this.SumTextBox.Text = "0 руб";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(30, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сумма";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.ReceivedTextBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(336, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(303, 95);
            this.panel2.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkGray;
            this.panel4.Location = new System.Drawing.Point(34, 76);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(230, 1);
            this.panel4.TabIndex = 4;
            // 
            // ReceivedTextBox
            // 
            this.ReceivedTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ReceivedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReceivedTextBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.ReceivedTextBox.ForeColor = System.Drawing.Color.Black;
            this.ReceivedTextBox.Location = new System.Drawing.Point(34, 41);
            this.ReceivedTextBox.Name = "ReceivedTextBox";
            this.ReceivedTextBox.Size = new System.Drawing.Size(230, 32);
            this.ReceivedTextBox.TabIndex = 1;
            this.ReceivedTextBox.TextChanged += new System.EventHandler(this.ReceivedTextBox_TextChanged);
            this.ReceivedTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ReceivedTextBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(30, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Получено";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(30, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Сдача";
            // 
            // ChangeTextBox
            // 
            this.ChangeTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ChangeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ChangeTextBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.ChangeTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.ChangeTextBox.Location = new System.Drawing.Point(34, 40);
            this.ChangeTextBox.Name = "ChangeTextBox";
            this.ChangeTextBox.ReadOnly = true;
            this.ChangeTextBox.Size = new System.Drawing.Size(230, 32);
            this.ChangeTextBox.TabIndex = 1;
            this.ChangeTextBox.Text = "0 руб";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.ChangeTextBox);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(647, 26);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(305, 95);
            this.panel3.TabIndex = 3;
            // 
            // PaymentInfo
            // 
            this.PaymentInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PaymentInfo.ForeColor = System.Drawing.Color.Gray;
            this.PaymentInfo.Location = new System.Drawing.Point(267, 141);
            this.PaymentInfo.Name = "PaymentInfo";
            this.PaymentInfo.Size = new System.Drawing.Size(522, 19);
            this.PaymentInfo.TabIndex = 2;
            this.PaymentInfo.Text = "Дата проведения операции: ?     |     Количество товаров: ?";
            this.PaymentInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ChangePrintCheckState
            // 
            this.ChangePrintCheckState.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.ChangePrintCheckState.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.ChangePrintCheckState.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.ChangePrintCheckState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangePrintCheckState.Location = new System.Drawing.Point(25, 138);
            this.ChangePrintCheckState.Name = "ChangePrintCheckState";
            this.ChangePrintCheckState.Size = new System.Drawing.Size(221, 25);
            this.ChangePrintCheckState.TabIndex = 4;
            this.ChangePrintCheckState.Text = "С печатью чека";
            this.ChangePrintCheckState.UseVisualStyleBackColor = true;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1009, 190);
            this.Controls.Add(this.ChangePrintCheckState);
            this.Controls.Add(this.PaymentInfo);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Payment";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Оплата  |  Для проведения операции - нажать Enter";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ChangeTextBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label PaymentInfo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox SumTextBox;
        private System.Windows.Forms.Button ChangePrintCheckState;
        public System.Windows.Forms.TextBox ReceivedTextBox;
    }
}