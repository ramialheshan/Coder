namespace desCoding
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
            this.label3 = new System.Windows.Forms.Label();
            this.DeCodingPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CodingPassword = new System.Windows.Forms.TextBox();
            this.maskedPassword = new System.Windows.Forms.MaskedTextBox();
            this.сodingButton = new System.Windows.Forms.Button();
            this.createSettingButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Раскодированный  пароль";
            // 
            // DeCodingPassword
            // 
            this.DeCodingPassword.Location = new System.Drawing.Point(193, 68);
            this.DeCodingPassword.Name = "DeCodingPassword";
            this.DeCodingPassword.Size = new System.Drawing.Size(251, 20);
            this.DeCodingPassword.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Закодированный пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Пароль";
            // 
            // CodingPassword
            // 
            this.CodingPassword.Location = new System.Drawing.Point(193, 42);
            this.CodingPassword.Name = "CodingPassword";
            this.CodingPassword.Size = new System.Drawing.Size(251, 20);
            this.CodingPassword.TabIndex = 21;
            // 
            // maskedPassword
            // 
            this.maskedPassword.Culture = new System.Globalization.CultureInfo("en-US");
            this.maskedPassword.Location = new System.Drawing.Point(193, 16);
            this.maskedPassword.Name = "maskedPassword";
            this.maskedPassword.PromptChar = ' ';
            this.maskedPassword.ShortcutsEnabled = false;
            this.maskedPassword.Size = new System.Drawing.Size(251, 20);
            this.maskedPassword.TabIndex = 20;
            // 
            // сodingButton
            // 
            this.сodingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.сodingButton.Location = new System.Drawing.Point(450, 16);
            this.сodingButton.Name = "сodingButton";
            this.сodingButton.Size = new System.Drawing.Size(115, 72);
            this.сodingButton.TabIndex = 26;
            this.сodingButton.Text = "Кодировать пароль";
            this.сodingButton.UseVisualStyleBackColor = true;
            this.сodingButton.Click += new System.EventHandler(this.сodingButton_Click);
            // 
            // createSettingButton
            // 
            this.createSettingButton.Location = new System.Drawing.Point(571, 16);
            this.createSettingButton.Name = "createSettingButton";
            this.createSettingButton.Size = new System.Drawing.Size(115, 72);
            this.createSettingButton.TabIndex = 7;
            this.createSettingButton.Text = "Сохранить настройки в файл";
            this.createSettingButton.UseVisualStyleBackColor = true;
            this.createSettingButton.Click += new System.EventHandler(this.createSettingButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 103);
            this.Controls.Add(this.createSettingButton);
            this.Controls.Add(this.сodingButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeCodingPassword);
            this.Controls.Add(this.CodingPassword);
            this.Controls.Add(this.maskedPassword);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Form1";
            this.Text = "Проверка пароля";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DeCodingPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedPassword;
        private System.Windows.Forms.Button сodingButton;
        private System.Windows.Forms.TextBox CodingPassword;
        private System.Windows.Forms.Button createSettingButton;

    }
}

