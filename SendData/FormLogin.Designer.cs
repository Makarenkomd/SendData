namespace SendData
{
    partial class FormLogin
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
            this.buttonEnterLogin = new System.Windows.Forms.Button();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonEnterLogin
            // 
            this.buttonEnterLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEnterLogin.Location = new System.Drawing.Point(44, 149);
            this.buttonEnterLogin.Name = "buttonEnterLogin";
            this.buttonEnterLogin.Size = new System.Drawing.Size(201, 40);
            this.buttonEnterLogin.TabIndex = 1;
            this.buttonEnterLogin.Text = "войти";
            this.buttonEnterLogin.UseVisualStyleBackColor = true;
            this.buttonEnterLogin.Click += new System.EventHandler(this.buttonEnterLogin_Click);
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLogin.Location = new System.Drawing.Point(44, 77);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(201, 38);
            this.textBoxLogin.TabIndex = 0;
            this.textBoxLogin.Text = "Введите ник";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 276);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.buttonEnterLogin);
            this.Name = "FormLogin";
            this.Text = "Представьтесь!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEnterLogin;
        private System.Windows.Forms.TextBox textBoxLogin;
    }
}

