namespace NewRC.ui
{
    partial class Auth
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
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.authButton = new System.Windows.Forms.Button();
            this.registButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(44, 48);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(202, 20);
            this.loginTextBox.TabIndex = 0;
            // 
            // passTextBox
            // 
            this.passTextBox.Location = new System.Drawing.Point(44, 99);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.Size = new System.Drawing.Size(202, 20);
            this.passTextBox.TabIndex = 1;
            // 
            // authButton
            // 
            this.authButton.Location = new System.Drawing.Point(74, 162);
            this.authButton.Name = "authButton";
            this.authButton.Size = new System.Drawing.Size(138, 23);
            this.authButton.TabIndex = 3;
            this.authButton.Text = "Login";
            this.authButton.UseVisualStyleBackColor = true;
            this.authButton.Click += new System.EventHandler(this.authButton_Click);
            // 
            // registButton
            // 
            this.registButton.Location = new System.Drawing.Point(74, 207);
            this.registButton.Name = "registButton";
            this.registButton.Size = new System.Drawing.Size(138, 23);
            this.registButton.TabIndex = 4;
            this.registButton.Text = "Registration";
            this.registButton.UseVisualStyleBackColor = true;
            this.registButton.Click += new System.EventHandler(this.registButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registButton);
            this.Controls.Add(this.authButton);
            this.Controls.Add(this.passTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Name = "Auth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auth";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.Button authButton;
        private System.Windows.Forms.Button registButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}