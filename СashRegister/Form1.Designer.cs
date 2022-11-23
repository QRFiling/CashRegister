
namespace СashRegister
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.DeviceAndroidVersion = new System.Windows.Forms.Label();
            this.DeviceName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ConnectionLogList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.PortLabel = new System.Windows.Forms.Label();
            this.IpLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BarcodeFormatLabel = new System.Windows.Forms.Label();
            this.ProductPriceLabel = new System.Windows.Forms.Label();
            this.ProductNameLabel = new System.Windows.Forms.Label();
            this.ProductPreview = new System.Windows.Forms.PictureBox();
            this.BarcodeLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.OpenProductInWeb = new System.Windows.Forms.Button();
            this.RemoveProduct = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.TotalSumLabel = new System.Windows.Forms.Label();
            this.PaymentButton = new System.Windows.Forms.Button();
            this.ProductsList = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.StatisticLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.OperationsLogList = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.OpenPriceguardButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.OpenCalcButton = new System.Windows.Forms.Button();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPreview)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.DeviceAndroidVersion);
            this.panel2.Controls.Add(this.DeviceName);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(1159, 413);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(331, 70);
            this.panel2.TabIndex = 5;
            // 
            // DeviceAndroidVersion
            // 
            this.DeviceAndroidVersion.AutoSize = true;
            this.DeviceAndroidVersion.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.DeviceAndroidVersion.ForeColor = System.Drawing.Color.DimGray;
            this.DeviceAndroidVersion.Location = new System.Drawing.Point(111, 91);
            this.DeviceAndroidVersion.Name = "DeviceAndroidVersion";
            this.DeviceAndroidVersion.Size = new System.Drawing.Size(0, 13);
            this.DeviceAndroidVersion.TabIndex = 3;
            // 
            // DeviceName
            // 
            this.DeviceName.AutoEllipsis = true;
            this.DeviceName.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeviceName.Location = new System.Drawing.Point(110, 70);
            this.DeviceName.Name = "DeviceName";
            this.DeviceName.Size = new System.Drawing.Size(182, 17);
            this.DeviceName.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(31, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 85);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(28, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Подключённое устройтво";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.ConnectionLogList);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.PortLabel);
            this.panel1.Controls.Add(this.IpLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1159, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 357);
            this.panel1.TabIndex = 6;
            // 
            // ConnectionLogList
            // 
            this.ConnectionLogList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ConnectionLogList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.ConnectionLogList.ForeColor = System.Drawing.Color.Gray;
            this.ConnectionLogList.FullRowSelect = true;
            this.ConnectionLogList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ConnectionLogList.HideSelection = false;
            this.ConnectionLogList.Location = new System.Drawing.Point(31, 168);
            this.ConnectionLogList.MultiSelect = false;
            this.ConnectionLogList.Name = "ConnectionLogList";
            this.ConnectionLogList.ShowItemToolTips = true;
            this.ConnectionLogList.Size = new System.Drawing.Size(272, 162);
            this.ConnectionLogList.TabIndex = 5;
            this.ConnectionLogList.UseCompatibleStateImageBehavior = false;
            this.ConnectionLogList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Время";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Сообщение";
            this.columnHeader2.Width = 190;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(28, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Лог";
            // 
            // PortLabel
            // 
            this.PortLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.PortLabel.Location = new System.Drawing.Point(28, 95);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(275, 28);
            this.PortLabel.TabIndex = 2;
            this.PortLabel.Text = "Порт: -";
            this.PortLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IpLabel
            // 
            this.IpLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.IpLabel.Location = new System.Drawing.Point(28, 61);
            this.IpLabel.Name = "IpLabel";
            this.IpLabel.Size = new System.Drawing.Size(275, 28);
            this.IpLabel.TabIndex = 1;
            this.IpLabel.Text = "IP: -";
            this.IpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(28, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "TCP-соединение";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.BarcodeFormatLabel);
            this.panel3.Controls.Add(this.ProductPriceLabel);
            this.panel3.Controls.Add(this.ProductNameLabel);
            this.panel3.Controls.Add(this.ProductPreview);
            this.panel3.Controls.Add(this.BarcodeLabel);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(810, 36);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(331, 400);
            this.panel3.TabIndex = 7;
            // 
            // BarcodeFormatLabel
            // 
            this.BarcodeFormatLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.BarcodeFormatLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BarcodeFormatLabel.Location = new System.Drawing.Point(256, 336);
            this.BarcodeFormatLabel.Name = "BarcodeFormatLabel";
            this.BarcodeFormatLabel.Size = new System.Drawing.Size(61, 40);
            this.BarcodeFormatLabel.TabIndex = 9;
            this.BarcodeFormatLabel.Text = "Тип";
            this.BarcodeFormatLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProductPriceLabel
            // 
            this.ProductPriceLabel.AutoSize = true;
            this.ProductPriceLabel.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.ProductPriceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProductPriceLabel.Location = new System.Drawing.Point(30, 263);
            this.ProductPriceLabel.Name = "ProductPriceLabel";
            this.ProductPriceLabel.Size = new System.Drawing.Size(51, 17);
            this.ProductPriceLabel.TabIndex = 8;
            this.ProductPriceLabel.Text = "Цена: -";
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.AutoEllipsis = true;
            this.ProductNameLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.ProductNameLabel.ForeColor = System.Drawing.Color.Black;
            this.ProductNameLabel.Location = new System.Drawing.Point(28, 243);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(263, 24);
            this.ProductNameLabel.TabIndex = 6;
            this.ProductNameLabel.Text = "Название продукта";
            // 
            // ProductPreview
            // 
            this.ProductPreview.BackColor = System.Drawing.Color.White;
            this.ProductPreview.Location = new System.Drawing.Point(32, 59);
            this.ProductPreview.Name = "ProductPreview";
            this.ProductPreview.Size = new System.Drawing.Size(170, 170);
            this.ProductPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProductPreview.TabIndex = 7;
            this.ProductPreview.TabStop = false;
            // 
            // BarcodeLabel
            // 
            this.BarcodeLabel.AutoEllipsis = true;
            this.BarcodeLabel.BackColor = System.Drawing.Color.White;
            this.BarcodeLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.BarcodeLabel.Location = new System.Drawing.Point(29, 336);
            this.BarcodeLabel.Name = "BarcodeLabel";
            this.BarcodeLabel.Size = new System.Drawing.Size(220, 40);
            this.BarcodeLabel.TabIndex = 6;
            this.BarcodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(29, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Штрих код";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(28, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Продукт";
            // 
            // OpenProductInWeb
            // 
            this.OpenProductInWeb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.OpenProductInWeb.Enabled = false;
            this.OpenProductInWeb.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.OpenProductInWeb.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.OpenProductInWeb.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.OpenProductInWeb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenProductInWeb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.OpenProductInWeb.Location = new System.Drawing.Point(31, 50);
            this.OpenProductInWeb.Name = "OpenProductInWeb";
            this.OpenProductInWeb.Size = new System.Drawing.Size(272, 30);
            this.OpenProductInWeb.TabIndex = 12;
            this.OpenProductInWeb.Text = "Открыть в браузере";
            this.OpenProductInWeb.UseVisualStyleBackColor = false;
            this.OpenProductInWeb.Click += new System.EventHandler(this.OpenProductInWeb_Click);
            // 
            // RemoveProduct
            // 
            this.RemoveProduct.BackColor = System.Drawing.Color.WhiteSmoke;
            this.RemoveProduct.Enabled = false;
            this.RemoveProduct.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.RemoveProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.RemoveProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.RemoveProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RemoveProduct.Location = new System.Drawing.Point(32, 85);
            this.RemoveProduct.Name = "RemoveProduct";
            this.RemoveProduct.Size = new System.Drawing.Size(271, 30);
            this.RemoveProduct.TabIndex = 11;
            this.RemoveProduct.Text = "Удалить текущий";
            this.RemoveProduct.UseVisualStyleBackColor = false;
            this.RemoveProduct.Click += new System.EventHandler(this.RemoveProduct_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.RemoveProduct);
            this.panel4.Controls.Add(this.OpenProductInWeb);
            this.panel4.Location = new System.Drawing.Point(810, 447);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(331, 136);
            this.panel4.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(28, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "Действия";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.Controls.Add(this.TotalSumLabel);
            this.panel5.Controls.Add(this.PaymentButton);
            this.panel5.Controls.Add(this.ProductsList);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(382, 36);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(402, 547);
            this.panel5.TabIndex = 13;
            // 
            // TotalSumLabel
            // 
            this.TotalSumLabel.AutoEllipsis = true;
            this.TotalSumLabel.AutoSize = true;
            this.TotalSumLabel.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.TotalSumLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TotalSumLabel.Location = new System.Drawing.Point(31, 499);
            this.TotalSumLabel.Name = "TotalSumLabel";
            this.TotalSumLabel.Size = new System.Drawing.Size(87, 17);
            this.TotalSumLabel.TabIndex = 10;
            this.TotalSumLabel.Text = "Итого: 0 руб";
            // 
            // PaymentButton
            // 
            this.PaymentButton.BackColor = System.Drawing.Color.Transparent;
            this.PaymentButton.Enabled = false;
            this.PaymentButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.PaymentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.PaymentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.PaymentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PaymentButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PaymentButton.ForeColor = System.Drawing.Color.Black;
            this.PaymentButton.Location = new System.Drawing.Point(186, 493);
            this.PaymentButton.Name = "PaymentButton";
            this.PaymentButton.Size = new System.Drawing.Size(169, 30);
            this.PaymentButton.TabIndex = 13;
            this.PaymentButton.Text = "Перейти к оплате";
            this.PaymentButton.UseVisualStyleBackColor = false;
            this.PaymentButton.Click += new System.EventHandler(this.PaymentButton_Click);
            // 
            // ProductsList
            // 
            this.ProductsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.ProductsList.ForeColor = System.Drawing.Color.Gray;
            this.ProductsList.FullRowSelect = true;
            this.ProductsList.GridLines = true;
            this.ProductsList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ProductsList.HideSelection = false;
            this.ProductsList.Location = new System.Drawing.Point(33, 62);
            this.ProductsList.MultiSelect = false;
            this.ProductsList.Name = "ProductsList";
            this.ProductsList.ShowItemToolTips = true;
            this.ProductsList.Size = new System.Drawing.Size(322, 412);
            this.ProductsList.TabIndex = 6;
            this.ProductsList.UseCompatibleStateImageBehavior = false;
            this.ProductsList.View = System.Windows.Forms.View.Details;
            this.ProductsList.SelectedIndexChanged += new System.EventHandler(this.ProductsList_SelectedIndexChanged);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "№";
            this.columnHeader6.Width = 30;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Название";
            this.columnHeader3.Width = 130;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Цена";
            this.columnHeader4.Width = 65;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Время";
            this.columnHeader5.Width = 80;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(30, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Список товаров";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.StatisticLabel);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.OperationsLogList);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(38, 36);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(318, 345);
            this.panel6.TabIndex = 7;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Location = new System.Drawing.Point(30, 53);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(8, 47);
            this.panel8.TabIndex = 11;
            // 
            // StatisticLabel
            // 
            this.StatisticLabel.BackColor = System.Drawing.Color.White;
            this.StatisticLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.StatisticLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StatisticLabel.Location = new System.Drawing.Point(36, 53);
            this.StatisticLabel.Name = "StatisticLabel";
            this.StatisticLabel.Size = new System.Drawing.Size(250, 47);
            this.StatisticLabel.TabIndex = 10;
            this.StatisticLabel.Text = "Оплат проведено: 0\r\nПрибыль: 0 руб";
            this.StatisticLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(28, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "Статистика (тек. сеанс)";
            // 
            // OperationsLogList
            // 
            this.OperationsLogList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OperationsLogList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8});
            this.OperationsLogList.ForeColor = System.Drawing.Color.Gray;
            this.OperationsLogList.FullRowSelect = true;
            this.OperationsLogList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.OperationsLogList.HideSelection = false;
            this.OperationsLogList.Location = new System.Drawing.Point(30, 150);
            this.OperationsLogList.MultiSelect = false;
            this.OperationsLogList.Name = "OperationsLogList";
            this.OperationsLogList.ShowItemToolTips = true;
            this.OperationsLogList.Size = new System.Drawing.Size(255, 161);
            this.OperationsLogList.TabIndex = 5;
            this.OperationsLogList.UseCompatibleStateImageBehavior = false;
            this.OperationsLogList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Время";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Сообщение";
            this.columnHeader8.Width = 174;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(28, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Журнал";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel7.Controls.Add(this.OpenPriceguardButton);
            this.panel7.Controls.Add(this.label10);
            this.panel7.Controls.Add(this.OpenCalcButton);
            this.panel7.Controls.Add(this.AddProductButton);
            this.panel7.Location = new System.Drawing.Point(38, 401);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(318, 182);
            this.panel7.TabIndex = 13;
            // 
            // OpenPriceguardButton
            // 
            this.OpenPriceguardButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.OpenPriceguardButton.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.OpenPriceguardButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.OpenPriceguardButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.OpenPriceguardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenPriceguardButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.OpenPriceguardButton.Location = new System.Drawing.Point(32, 123);
            this.OpenPriceguardButton.Name = "OpenPriceguardButton";
            this.OpenPriceguardButton.Size = new System.Drawing.Size(254, 30);
            this.OpenPriceguardButton.TabIndex = 13;
            this.OpenPriceguardButton.Text = "Открыть Priceguard.ru";
            this.OpenPriceguardButton.UseVisualStyleBackColor = false;
            this.OpenPriceguardButton.Click += new System.EventHandler(this.OpenPriceguardButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(28, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "Дополнительно";
            // 
            // OpenCalcButton
            // 
            this.OpenCalcButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.OpenCalcButton.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.OpenCalcButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.OpenCalcButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.OpenCalcButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenCalcButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.OpenCalcButton.Location = new System.Drawing.Point(32, 86);
            this.OpenCalcButton.Name = "OpenCalcButton";
            this.OpenCalcButton.Size = new System.Drawing.Size(254, 30);
            this.OpenCalcButton.TabIndex = 11;
            this.OpenCalcButton.Text = "Открыть калькулятор";
            this.OpenCalcButton.UseVisualStyleBackColor = false;
            this.OpenCalcButton.Click += new System.EventHandler(this.OpenCalc_Click);
            // 
            // AddProductButton
            // 
            this.AddProductButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AddProductButton.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.AddProductButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.AddProductButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.AddProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddProductButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddProductButton.Location = new System.Drawing.Point(31, 50);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(255, 30);
            this.AddProductButton.TabIndex = 12;
            this.AddProductButton.Text = "Добавить товар вручную";
            this.AddProductButton.UseVisualStyleBackColor = false;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1530, 633);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CashRegister - Сервер  |  Автор: Рыжкин Максим (QR Filing)";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPreview)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label DeviceAndroidVersion;
        private System.Windows.Forms.Label DeviceName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView ConnectionLogList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label PortLabel;
        private System.Windows.Forms.Label IpLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label BarcodeLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label ProductPriceLabel;
        private System.Windows.Forms.Label ProductNameLabel;
        private System.Windows.Forms.PictureBox ProductPreview;
        private System.Windows.Forms.Label BarcodeFormatLabel;
        private System.Windows.Forms.Button OpenProductInWeb;
        private System.Windows.Forms.Button RemoveProduct;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ListView ProductsList;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button PaymentButton;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label StatisticLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView OperationsLogList;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button OpenCalcButton;
        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.Button OpenPriceguardButton;
        private System.Windows.Forms.Label TotalSumLabel;
        private System.Windows.Forms.Panel panel8;
    }
}

