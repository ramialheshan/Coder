namespace CoderApplication
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.DeCodingPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CodingPassword = new System.Windows.Forms.TextBox();
            this.maskedPassword = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.userAsseccComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.userAsseccComboBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.DeCodingPassword);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CodingPassword);
            this.groupBox1.Controls.Add(this.maskedPassword);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(14, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 187);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Проверка пароля";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Font = new System.Drawing.Font("Arial", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(166, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(251, 42);
            this.button1.TabIndex = 20;
            this.button1.Text = "Записать файл настроек";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 14);
            this.label3.TabIndex = 19;
            this.label3.Text = "Раскодированный  пароль";
            // 
            // DeCodingPassword
            // 
            this.DeCodingPassword.Location = new System.Drawing.Point(166, 99);
            this.DeCodingPassword.Name = "DeCodingPassword";
            this.DeCodingPassword.Size = new System.Drawing.Size(251, 20);
            this.DeCodingPassword.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 14);
            this.label2.TabIndex = 17;
            this.label2.Text = "Закодированный пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 14);
            this.label1.TabIndex = 16;
            this.label1.Text = "Пароль";
            // 
            // CodingPassword
            // 
            this.CodingPassword.Location = new System.Drawing.Point(166, 73);
            this.CodingPassword.Name = "CodingPassword";
            this.CodingPassword.Size = new System.Drawing.Size(251, 20);
            this.CodingPassword.TabIndex = 15;
            // 
            // maskedPassword
            // 
            this.maskedPassword.Culture = new System.Globalization.CultureInfo("en-US");
            this.maskedPassword.Location = new System.Drawing.Point(166, 19);
            this.maskedPassword.Name = "maskedPassword";
            this.maskedPassword.PromptChar = ' ';
            this.maskedPassword.ShortcutsEnabled = false;
            this.maskedPassword.Size = new System.Drawing.Size(251, 20);
            this.maskedPassword.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 14);
            this.label4.TabIndex = 21;
            this.label4.Text = "Права пользователя";
            // 
            // userAsseccComboBox
            // 
            this.userAsseccComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userAsseccComboBox.FormattingEnabled = true;
            this.userAsseccComboBox.Items.AddRange(new object[] {
            "Администратор",
            "Пользователь"});
            this.userAsseccComboBox.Location = new System.Drawing.Point(166, 45);
            this.userAsseccComboBox.Name = "userAsseccComboBox";
            this.userAsseccComboBox.Size = new System.Drawing.Size(251, 22);
            this.userAsseccComboBox.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 213);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Окно создания файла настроек";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DeCodingPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CodingPassword;
        private System.Windows.Forms.MaskedTextBox maskedPassword;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox userAsseccComboBox;
        private System.Windows.Forms.Label label4;
    }
}

