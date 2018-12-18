namespace RC
{
    partial class RentCar
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
            this.components = new System.ComponentModel.Container();
            this.clientTeltextBox = new System.Windows.Forms.TextBox();
            this.clientNameTextBox = new System.Windows.Forms.TextBox();
            this.brandCarTextBox = new System.Windows.Forms.TextBox();
            this.modelCarTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.fromTextBox = new System.Windows.Forms.TextBox();
            this.toTextBox = new System.Windows.Forms.TextBox();
            this.createButton = new System.Windows.Forms.Button();
            this.dbGroupBox = new System.Windows.Forms.GroupBox();
            this.dbClients = new System.Windows.Forms.Button();
            this.dbRentButton = new System.Windows.Forms.Button();
            this.dbCarsButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.numCarComboBox = new System.Windows.Forms.ComboBox();
            this.carBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.myDbDataSet = new RC.MyDbDataSet();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carTableAdapter = new RC.MyDbDataSetTableAdapters.CarTableAdapter();
            this.buttonNewClient = new System.Windows.Forms.Button();
            this.durationComboBox = new System.Windows.Forms.NumericUpDown();
            this.rentTableAdapter = new RC.MyDbDataSetTableAdapters.RentTableAdapter();
            this.clientTableAdapter = new RC.MyDbDataSetTableAdapters.ClientTableAdapter();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.clientBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.RCTableAdapterManager = new RC.MyDbDataSetTableAdapters.TableAdapterManager();
            this.dbGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // clientTeltextBox
            // 
            this.clientTeltextBox.Location = new System.Drawing.Point(400, 52);
            this.clientTeltextBox.Name = "clientTeltextBox";
            this.clientTeltextBox.Size = new System.Drawing.Size(100, 20);
            this.clientTeltextBox.TabIndex = 100;
            // 
            // clientNameTextBox
            // 
            this.clientNameTextBox.Location = new System.Drawing.Point(190, 52);
            this.clientNameTextBox.Name = "clientNameTextBox";
            this.clientNameTextBox.Size = new System.Drawing.Size(185, 20);
            this.clientNameTextBox.TabIndex = 100;
            // 
            // brandCarTextBox
            // 
            this.brandCarTextBox.Location = new System.Drawing.Point(232, 114);
            this.brandCarTextBox.Name = "brandCarTextBox";
            this.brandCarTextBox.Size = new System.Drawing.Size(100, 20);
            this.brandCarTextBox.TabIndex = 100;
            // 
            // modelCarTextBox
            // 
            this.modelCarTextBox.Location = new System.Drawing.Point(400, 114);
            this.modelCarTextBox.Name = "modelCarTextBox";
            this.modelCarTextBox.Size = new System.Drawing.Size(100, 20);
            this.modelCarTextBox.TabIndex = 100;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(67, 224);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 100;
            // 
            // locationTextBox
            // 
            this.locationTextBox.Location = new System.Drawing.Point(320, 170);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(100, 20);
            this.locationTextBox.TabIndex = 100;
            // 
            // fromTextBox
            // 
            this.fromTextBox.Location = new System.Drawing.Point(232, 224);
            this.fromTextBox.Name = "fromTextBox";
            this.fromTextBox.Size = new System.Drawing.Size(100, 20);
            this.fromTextBox.TabIndex = 100;
            // 
            // toTextBox
            // 
            this.toTextBox.Location = new System.Drawing.Point(400, 224);
            this.toTextBox.Name = "toTextBox";
            this.toTextBox.Size = new System.Drawing.Size(100, 20);
            this.toTextBox.TabIndex = 3;
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(248, 282);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 4;
            this.createButton.Text = "Create rent";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // dbGroupBox
            // 
            this.dbGroupBox.Controls.Add(this.dbClients);
            this.dbGroupBox.Controls.Add(this.dbRentButton);
            this.dbGroupBox.Controls.Add(this.dbCarsButton);
            this.dbGroupBox.Location = new System.Drawing.Point(540, 95);
            this.dbGroupBox.Name = "dbGroupBox";
            this.dbGroupBox.Size = new System.Drawing.Size(197, 149);
            this.dbGroupBox.TabIndex = 6;
            this.dbGroupBox.TabStop = false;
            this.dbGroupBox.Text = "Open DBs";
            // 
            // dbClients
            // 
            this.dbClients.Location = new System.Drawing.Point(67, 62);
            this.dbClients.Name = "dbClients";
            this.dbClients.Size = new System.Drawing.Size(75, 20);
            this.dbClients.TabIndex = 2;
            this.dbClients.Text = "DB Client";
            this.dbClients.UseVisualStyleBackColor = true;
            this.dbClients.Click += new System.EventHandler(this.dbClients_Click);
            // 
            // dbRentButton
            // 
            this.dbRentButton.Location = new System.Drawing.Point(67, 96);
            this.dbRentButton.Name = "dbRentButton";
            this.dbRentButton.Size = new System.Drawing.Size(75, 20);
            this.dbRentButton.TabIndex = 3;
            this.dbRentButton.Text = "DB Rent";
            this.dbRentButton.UseVisualStyleBackColor = true;
            this.dbRentButton.Click += new System.EventHandler(this.dbRentButton_Click);
            // 
            // dbCarsButton
            // 
            this.dbCarsButton.Location = new System.Drawing.Point(67, 25);
            this.dbCarsButton.Name = "dbCarsButton";
            this.dbCarsButton.Size = new System.Drawing.Size(75, 20);
            this.dbCarsButton.TabIndex = 1;
            this.dbCarsButton.Text = "DB Cars";
            this.dbCarsButton.UseVisualStyleBackColor = true;
            this.dbCarsButton.Click += new System.EventHandler(this.dbCarsButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(607, 272);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 7;
            this.closeButton.Text = "Exit";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Client\'s name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Client\'s phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Client\'s passport";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "ID car";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(235, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Brand";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(400, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Model";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(69, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Price";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(317, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Location";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(146, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Duration";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(232, 207);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "From";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(397, 207);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "To";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(12, 9);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(57, 13);
            this.userNameLabel.TabIndex = 24;
            this.userNameLabel.Text = "UserName";
            // 
            // numCarComboBox
            // 
            this.numCarComboBox.DataSource = this.carBindingSource1;
            this.numCarComboBox.DisplayMember = "idCar";
            this.numCarComboBox.FormattingEnabled = true;
            this.numCarComboBox.Location = new System.Drawing.Point(64, 114);
            this.numCarComboBox.Name = "numCarComboBox";
            this.numCarComboBox.Size = new System.Drawing.Size(100, 21);
            this.numCarComboBox.TabIndex = 1;
            this.numCarComboBox.ValueMember = "idCar";
            this.numCarComboBox.SelectedIndexChanged += new System.EventHandler(this.numCarComboBox_SelectedIndexChanged);
            // 
            // carBindingSource1
            // 
            this.carBindingSource1.DataMember = "Car";
            this.carBindingSource1.DataSource = this.myDbDataSet;
            // 
            // myDbDataSet
            // 
            this.myDbDataSet.DataSetName = "MyDbDataSet";
            this.myDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataMember = "Car";
            this.carBindingSource.DataSource = this.myDbDataSet;
            // 
            // carTableAdapter
            // 
            this.carTableAdapter.ClearBeforeFill = true;
            // 
            // buttonNewClient
            // 
            this.buttonNewClient.Location = new System.Drawing.Point(607, 48);
            this.buttonNewClient.Name = "buttonNewClient";
            this.buttonNewClient.Size = new System.Drawing.Size(75, 23);
            this.buttonNewClient.TabIndex = 5;
            this.buttonNewClient.Text = "New client";
            this.buttonNewClient.UseVisualStyleBackColor = true;
            this.buttonNewClient.Click += new System.EventHandler(this.buttonNewClient_Click);
            // 
            // durationComboBox
            // 
            this.durationComboBox.Location = new System.Drawing.Point(149, 171);
            this.durationComboBox.Name = "durationComboBox";
            this.durationComboBox.Size = new System.Drawing.Size(97, 20);
            this.durationComboBox.TabIndex = 2;
            this.durationComboBox.ValueChanged += new System.EventHandler(this.durationComboBox_ValueChanged);
            // 
            // rentTableAdapter
            // 
            this.rentTableAdapter.ClearBeforeFill = true;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.myDbDataSet;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.clientBindingSource1;
            this.comboBox1.DisplayMember = "passport";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(64, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "passport";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // clientBindingSource1
            // 
            this.clientBindingSource1.DataMember = "Client";
            this.clientBindingSource1.DataSource = this.myDbDataSet;
            // 
            // RCTableAdapterManager
            // 
            this.RCTableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.RCTableAdapterManager.CarTableAdapter = this.carTableAdapter;
            this.RCTableAdapterManager.ClientTableAdapter = this.clientTableAdapter;
            this.RCTableAdapterManager.RentTableAdapter = this.rentTableAdapter;
            this.RCTableAdapterManager.UpdateOrder = RC.MyDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.RCTableAdapterManager.UserTableAdapter = null;
            // 
            // RentCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 324);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.durationComboBox);
            this.Controls.Add(this.buttonNewClient);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.dbGroupBox);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.toTextBox);
            this.Controls.Add(this.fromTextBox);
            this.Controls.Add(this.locationTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.modelCarTextBox);
            this.Controls.Add(this.brandCarTextBox);
            this.Controls.Add(this.numCarComboBox);
            this.Controls.Add(this.clientNameTextBox);
            this.Controls.Add(this.clientTeltextBox);
            this.Name = "RentCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RentCar";
            this.Load += new System.EventHandler(this.RentCar_Load);
            this.dbGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox clientTeltextBox;
        private System.Windows.Forms.TextBox clientNameTextBox;
        private System.Windows.Forms.ComboBox numCarComboBox;
        private System.Windows.Forms.TextBox brandCarTextBox;
        private System.Windows.Forms.TextBox modelCarTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.TextBox fromTextBox;
        private System.Windows.Forms.TextBox toTextBox;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.GroupBox dbGroupBox;
        private System.Windows.Forms.Button dbCarsButton;
        private System.Windows.Forms.Button dbRentButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label userNameLabel;
        private MyDbDataSet myDbDataSet;
        private System.Windows.Forms.BindingSource carBindingSource;
        private MyDbDataSetTableAdapters.CarTableAdapter carTableAdapter;
        private System.Windows.Forms.Button buttonNewClient;
        private System.Windows.Forms.NumericUpDown durationComboBox;
        private MyDbDataSetTableAdapters.RentTableAdapter rentTableAdapter;
        private System.Windows.Forms.Button dbClients;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private MyDbDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource clientBindingSource1;
        private System.Windows.Forms.BindingSource carBindingSource1;
        private MyDbDataSetTableAdapters.TableAdapterManager RCTableAdapterManager;
    }
}