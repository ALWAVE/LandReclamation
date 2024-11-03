namespace LandReclamation
{
    partial class AccountingLandForms
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
            this.btn_hideForms = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox_idUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richhTextBox_Comment = new System.Windows.Forms.RichTextBox();
            this.textBox_Adress = new System.Windows.Forms.TextBox();
            this.textBox_City = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_CreateAccounting = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_Count = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_hideForms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_hideForms
            // 
            this.btn_hideForms.BackColor = System.Drawing.Color.Transparent;
            this.btn_hideForms.BackgroundImage = global::LandReclamation.Properties.Resources.back_to_480px;
            this.btn_hideForms.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_hideForms.Location = new System.Drawing.Point(1046, 15);
            this.btn_hideForms.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_hideForms.Name = "btn_hideForms";
            this.btn_hideForms.Size = new System.Drawing.Size(62, 62);
            this.btn_hideForms.TabIndex = 0;
            this.btn_hideForms.TabStop = false;
            this.btn_hideForms.Click += new System.EventHandler(this.btn_hideForms_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(240, 40);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(786, 391);
            this.dataGridView1.TabIndex = 1;
            // 
            // textBox_idUser
            // 
            this.textBox_idUser.Location = new System.Drawing.Point(13, 40);
            this.textBox_idUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_idUser.Name = "textBox_idUser";
            this.textBox_idUser.Size = new System.Drawing.Size(218, 22);
            this.textBox_idUser.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(73, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID Владельца ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(51, 181);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Метонахождение поля";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(28, 241);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Комментарий к данному участку";
            // 
            // richhTextBox_Comment
            // 
            this.richhTextBox_Comment.Location = new System.Drawing.Point(14, 260);
            this.richhTextBox_Comment.Name = "richhTextBox_Comment";
            this.richhTextBox_Comment.Size = new System.Drawing.Size(218, 96);
            this.richhTextBox_Comment.TabIndex = 6;
            this.richhTextBox_Comment.Text = "";
            // 
            // textBox_Adress
            // 
            this.textBox_Adress.Location = new System.Drawing.Point(14, 201);
            this.textBox_Adress.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Adress.Name = "textBox_Adress";
            this.textBox_Adress.Size = new System.Drawing.Size(218, 22);
            this.textBox_Adress.TabIndex = 7;
            // 
            // textBox_City
            // 
            this.textBox_City.Location = new System.Drawing.Point(13, 95);
            this.textBox_City.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_City.Name = "textBox_City";
            this.textBox_City.Size = new System.Drawing.Size(218, 22);
            this.textBox_City.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(89, 75);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Город";
            // 
            // btn_CreateAccounting
            // 
            this.btn_CreateAccounting.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_CreateAccounting.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_CreateAccounting.Location = new System.Drawing.Point(14, 379);
            this.btn_CreateAccounting.Name = "btn_CreateAccounting";
            this.btn_CreateAccounting.Size = new System.Drawing.Size(219, 52);
            this.btn_CreateAccounting.TabIndex = 10;
            this.btn_CreateAccounting.Text = "Создать учет";
            this.btn_CreateAccounting.UseVisualStyleBackColor = true;
            this.btn_CreateAccounting.Click += new System.EventHandler(this.btn_CreateAccounting_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(71, 135);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Кол-во гектра";
            // 
            // comboBox_Count
            // 
            this.comboBox_Count.FormattingEnabled = true;
            this.comboBox_Count.Items.AddRange(new object[] {
            "1 Гектар",
            "2 Гектар",
            "3 Гектар",
            "4 Гектар",
            "5 Гектар",
            "6 Гектар",
            "7 Гектар",
            "8 Гектар",
            "9 Гектар",
            "10 Гектар",
            "11 Гектар",
            "12 Гектар",
            "13 Гектар",
            "14 Гектар",
            "15 Гектар"});
            this.comboBox_Count.Location = new System.Drawing.Point(12, 154);
            this.comboBox_Count.Name = "comboBox_Count";
            this.comboBox_Count.Size = new System.Drawing.Size(219, 24);
            this.comboBox_Count.TabIndex = 12;
            // 
            // AccountingLandForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LandReclamation.Properties.Resources.gradient_color_background_233705_14;
            this.ClientSize = new System.Drawing.Size(1122, 475);
            this.Controls.Add(this.comboBox_Count);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_CreateAccounting);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_City);
            this.Controls.Add(this.textBox_Adress);
            this.Controls.Add(this.richhTextBox_Comment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_idUser);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_hideForms);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AccountingLandForms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccountingLandForms";
            ((System.ComponentModel.ISupportInitialize)(this.btn_hideForms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btn_hideForms;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_idUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richhTextBox_Comment;
        private System.Windows.Forms.TextBox textBox_Adress;
        private System.Windows.Forms.TextBox textBox_City;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_CreateAccounting;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_Count;
    }
}