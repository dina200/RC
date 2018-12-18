namespace RC.ui
{
    partial class CreateClientForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.clientNametextBox = new System.Windows.Forms.TextBox();
            this.clientTeltextBox = new System.Windows.Forms.TextBox();
            this.clientPassportTextBox = new System.Windows.Forms.TextBox();
            this.createButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.RCTableAdapterManager = new RC.MyDbDataSetTableAdapters.TableAdapterManager();
            this.myDbDataSet = new RC.MyDbDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.myDbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Client\'s name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Client\'s phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Client\'s passport";
            // 
            // clientNametextBox
            // 
            this.clientNametextBox.Location = new System.Drawing.Point(90, 92);
            this.clientNametextBox.Name = "clientNametextBox";
            this.clientNametextBox.Size = new System.Drawing.Size(100, 20);
            this.clientNametextBox.TabIndex = 1;
            // 
            // clientTeltextBox
            // 
            this.clientTeltextBox.Location = new System.Drawing.Point(90, 144);
            this.clientTeltextBox.Name = "clientTeltextBox";
            this.clientTeltextBox.Size = new System.Drawing.Size(100, 20);
            this.clientTeltextBox.TabIndex = 2;
            // 
            // clientPassportTextBox
            // 
            this.clientPassportTextBox.Location = new System.Drawing.Point(90, 48);
            this.clientPassportTextBox.Name = "clientPassportTextBox";
            this.clientPassportTextBox.Size = new System.Drawing.Size(100, 20);
            this.clientPassportTextBox.TabIndex = 0;
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(104, 186);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 3;
            this.createButton.Text = "Add client";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(104, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RCTableAdapterManager
            // 
            this.RCTableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.RCTableAdapterManager.CarTableAdapter = null;
            this.RCTableAdapterManager.ClientTableAdapter = null;
            this.RCTableAdapterManager.Connection = null;
            this.RCTableAdapterManager.RentTableAdapter = null;
            this.RCTableAdapterManager.UpdateOrder = RC.MyDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.RCTableAdapterManager.UserTableAdapter = null;
            // 
            // myDbDataSet
            // 
            this.myDbDataSet.DataSetName = "MyDbDataSet";
            this.myDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CreateClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.clientPassportTextBox);
            this.Controls.Add(this.clientTeltextBox);
            this.Controls.Add(this.clientNametextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Client";
            ((System.ComponentModel.ISupportInitialize)(this.myDbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox clientNametextBox;
        private System.Windows.Forms.TextBox clientTeltextBox;
        private System.Windows.Forms.TextBox clientPassportTextBox;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button button1;
        private MyDbDataSetTableAdapters.TableAdapterManager RCTableAdapterManager;
        private MyDbDataSet myDbDataSet;
    }
}