namespace LandReclamation
{
    partial class Order
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LocationField = new System.Windows.Forms.TextBox();
            this.NameOrganization = new System.Windows.Forms.TextBox();
            this.FieldSize = new System.Windows.Forms.ComboBox();
            this.City = new System.Windows.Forms.ComboBox();
            this.OneAddition = new System.Windows.Forms.ComboBox();
            this.TwoAddition = new System.Windows.Forms.ComboBox();
            this.BtnViewTotalPrice = new System.Windows.Forms.Button();
            this.BtnAccept = new System.Windows.Forms.Button();
            this.BtnRefuse = new System.Windows.Forms.Button();
            this.TotalPriceName = new System.Windows.Forms.Label();
            this.Label_TotalPrice = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.MyWorker = new System.Windows.Forms.PictureBox();
            this.Additional_Info = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MyWorker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Additional_Info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Размер вашего поля:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Наименование вашей организации:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Местонахождение вашего поля:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Дополнения:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Город в котором находится ваше поле:";
            // 
            // LocationField
            // 
            this.LocationField.Location = new System.Drawing.Point(192, 152);
            this.LocationField.Name = "LocationField";
            this.LocationField.Size = new System.Drawing.Size(212, 20);
            this.LocationField.TabIndex = 6;
            // 
            // NameOrganization
            // 
            this.NameOrganization.Location = new System.Drawing.Point(207, 93);
            this.NameOrganization.Name = "NameOrganization";
            this.NameOrganization.Size = new System.Drawing.Size(149, 20);
            this.NameOrganization.TabIndex = 7;
            // 
            // FieldSize
            // 
            this.FieldSize.FormattingEnabled = true;
            this.FieldSize.Items.AddRange(new object[] {
            "1 Гектар(а)",
            "2 Гектар(а)",
            "3 Гектар(а)",
            "4 Гектар(а)",
            "5 Гектар(а)",
            "6 Гектар(а)",
            "7 Гектар(а)",
            "8 Гектар(а)",
            "9 Гектар(а)",
            "10 Гектар(а)"});
            this.FieldSize.Location = new System.Drawing.Point(134, 58);
            this.FieldSize.Name = "FieldSize";
            this.FieldSize.Size = new System.Drawing.Size(121, 21);
            this.FieldSize.TabIndex = 8;
            // 
            // City
            // 
            this.City.FormattingEnabled = true;
            this.City.Items.AddRange(new object[] {
            "Энгельс",
            "Саратов",
            "Самара",
            "Балашово",
            "Балашов",
            "Вольск",
            "Пугачёв",
            "Маркс",
            "Москва"});
            this.City.Location = new System.Drawing.Point(224, 125);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(121, 21);
            this.City.TabIndex = 9;
            // 
            // OneAddition
            // 
            this.OneAddition.FormattingEnabled = true;
            this.OneAddition.Items.AddRange(new object[] {
            "Нету",
            "Улучшеный полив поля"});
            this.OneAddition.Location = new System.Drawing.Point(101, 183);
            this.OneAddition.Name = "OneAddition";
            this.OneAddition.Size = new System.Drawing.Size(121, 21);
            this.OneAddition.TabIndex = 10;
            // 
            // TwoAddition
            // 
            this.TwoAddition.FormattingEnabled = true;
            this.TwoAddition.Items.AddRange(new object[] {
            "Нету",
            "Прополка поля"});
            this.TwoAddition.Location = new System.Drawing.Point(228, 183);
            this.TwoAddition.Name = "TwoAddition";
            this.TwoAddition.Size = new System.Drawing.Size(121, 21);
            this.TwoAddition.TabIndex = 11;
            // 
            // BtnViewTotalPrice
            // 
            this.BtnViewTotalPrice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnViewTotalPrice.Location = new System.Drawing.Point(19, 239);
            this.BtnViewTotalPrice.Name = "BtnViewTotalPrice";
            this.BtnViewTotalPrice.Size = new System.Drawing.Size(385, 55);
            this.BtnViewTotalPrice.TabIndex = 14;
            this.BtnViewTotalPrice.Text = "Узнать конечную цену";
            this.BtnViewTotalPrice.UseVisualStyleBackColor = true;
            this.BtnViewTotalPrice.Click += new System.EventHandler(this.BtnViewTotalPrice_Click);
            // 
            // BtnAccept
            // 
            this.BtnAccept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAccept.Location = new System.Drawing.Point(98, 398);
            this.BtnAccept.Name = "BtnAccept";
            this.BtnAccept.Size = new System.Drawing.Size(88, 59);
            this.BtnAccept.TabIndex = 15;
            this.BtnAccept.Text = "Покупаю";
            this.BtnAccept.UseVisualStyleBackColor = true;
            this.BtnAccept.Visible = false;
            this.BtnAccept.Click += new System.EventHandler(this.BtnAccept_Click);
            // 
            // BtnRefuse
            // 
            this.BtnRefuse.Location = new System.Drawing.Point(291, 398);
            this.BtnRefuse.Name = "BtnRefuse";
            this.BtnRefuse.Size = new System.Drawing.Size(75, 59);
            this.BtnRefuse.TabIndex = 16;
            this.BtnRefuse.Text = "Откажусь";
            this.BtnRefuse.UseVisualStyleBackColor = true;
            this.BtnRefuse.Visible = false;
            this.BtnRefuse.Click += new System.EventHandler(this.BtnRefuse_Click);
            // 
            // TotalPriceName
            // 
            this.TotalPriceName.AutoSize = true;
            this.TotalPriceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TotalPriceName.Location = new System.Drawing.Point(130, 329);
            this.TotalPriceName.Name = "TotalPriceName";
            this.TotalPriceName.Size = new System.Drawing.Size(139, 20);
            this.TotalPriceName.TabIndex = 17;
            this.TotalPriceName.Text = "Итоговая цена:";
            this.TotalPriceName.Visible = false;
            // 
            // Label_TotalPrice
            // 
            this.Label_TotalPrice.AutoSize = true;
            this.Label_TotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_TotalPrice.Location = new System.Drawing.Point(275, 329);
            this.Label_TotalPrice.Name = "Label_TotalPrice";
            this.Label_TotalPrice.Size = new System.Drawing.Size(49, 20);
            this.Label_TotalPrice.TabIndex = 18;
            this.Label_TotalPrice.Text = "120р";
            this.Label_TotalPrice.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(498, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 38);
            this.button1.TabIndex = 26;
            this.button1.Text = "Показать совместную фотографию наших работников";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MyWorker
            // 
            this.MyWorker.BackgroundImage = global::LandReclamation.Properties.Resources.bea712470617fd45e2833f54dbf6741d;
            this.MyWorker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MyWorker.Location = new System.Drawing.Point(464, 125);
            this.MyWorker.Name = "MyWorker";
            this.MyWorker.Size = new System.Drawing.Size(229, 139);
            this.MyWorker.TabIndex = 25;
            this.MyWorker.TabStop = false;
            this.MyWorker.Visible = false;
            // 
            // Additional_Info
            // 
            this.Additional_Info.BackColor = System.Drawing.Color.Transparent;
            this.Additional_Info.BackgroundImage = global::LandReclamation.Properties.Resources.question_mark_208px;
            this.Additional_Info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Additional_Info.Location = new System.Drawing.Point(363, 183);
            this.Additional_Info.Name = "Additional_Info";
            this.Additional_Info.Size = new System.Drawing.Size(31, 31);
            this.Additional_Info.TabIndex = 13;
            this.Additional_Info.TabStop = false;
            this.Additional_Info.Click += new System.EventHandler(this.Additional_Info_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::LandReclamation.Properties.Resources.back_to_480px;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(638, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 592);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MyWorker);
            this.Controls.Add(this.Label_TotalPrice);
            this.Controls.Add(this.TotalPriceName);
            this.Controls.Add(this.BtnRefuse);
            this.Controls.Add(this.BtnAccept);
            this.Controls.Add(this.BtnViewTotalPrice);
            this.Controls.Add(this.Additional_Info);
            this.Controls.Add(this.TwoAddition);
            this.Controls.Add(this.OneAddition);
            this.Controls.Add(this.City);
            this.Controls.Add(this.FieldSize);
            this.Controls.Add(this.NameOrganization);
            this.Controls.Add(this.LocationField);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order";
            ((System.ComponentModel.ISupportInitialize)(this.MyWorker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Additional_Info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox LocationField;
        private System.Windows.Forms.TextBox NameOrganization;
        private System.Windows.Forms.ComboBox FieldSize;
        private System.Windows.Forms.ComboBox City;
        private System.Windows.Forms.ComboBox OneAddition;
        private System.Windows.Forms.ComboBox TwoAddition;
        private System.Windows.Forms.PictureBox Additional_Info;
        private System.Windows.Forms.Button BtnViewTotalPrice;
        private System.Windows.Forms.Button BtnAccept;
        private System.Windows.Forms.Button BtnRefuse;
        private System.Windows.Forms.Label TotalPriceName;
        private System.Windows.Forms.Label Label_TotalPrice;
        private System.Windows.Forms.PictureBox MyWorker;
        private System.Windows.Forms.Button button1;
    }
}