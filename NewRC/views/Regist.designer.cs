﻿namespace NewRC.ui
{
    partial class Regist
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
            this.newLoginTextBox = new System.Windows.Forms.TextBox();
            this.passdRegTextBox = new System.Windows.Forms.TextBox();
            this.confPassRegTextBox = new System.Windows.Forms.TextBox();
            this.regButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // newLoginTextBox
            // 
            this.newLoginTextBox.Location = new System.Drawing.Point(41, 41);
            this.newLoginTextBox.Name = "newLoginTextBox";
            this.newLoginTextBox.Size = new System.Drawing.Size(202, 20);
            this.newLoginTextBox.TabIndex = 0;
            // 
            // passdRegTextBox
            // 
            this.passdRegTextBox.Location = new System.Drawing.Point(41, 83);
            this.passdRegTextBox.Name = "passdRegTextBox";
            this.passdRegTextBox.Size = new System.Drawing.Size(202, 20);
            this.passdRegTextBox.TabIndex = 1;
            // 
            // confPassRegTextBox
            // 
            this.confPassRegTextBox.Location = new System.Drawing.Point(41, 127);
            this.confPassRegTextBox.Name = "confPassRegTextBox";
            this.confPassRegTextBox.Size = new System.Drawing.Size(202, 20);
            this.confPassRegTextBox.TabIndex = 2;
            // 
            // regButton
            // 
            this.regButton.Location = new System.Drawing.Point(80, 191);
            this.regButton.Name = "regButton";
            this.regButton.Size = new System.Drawing.Size(115, 23);
            this.regButton.TabIndex = 3;
            this.regButton.Text = "Create new user";
            this.regButton.UseVisualStyleBackColor = true;
            this.regButton.Click += new System.EventHandler(this.regButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "New login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Confirm password";
            // 
            // Regist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.regButton);
            this.Controls.Add(this.confPassRegTextBox);
            this.Controls.Add(this.passdRegTextBox);
            this.Controls.Add(this.newLoginTextBox);
            this.Name = "Regist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox newLoginTextBox;
        private System.Windows.Forms.TextBox passdRegTextBox;
        private System.Windows.Forms.TextBox confPassRegTextBox;
        private System.Windows.Forms.Button regButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}