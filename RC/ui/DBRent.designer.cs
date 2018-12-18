namespace RC.ui
{
    partial class DBRent
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idRentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.managerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fromPlaceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toPlaceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myDbDataSet = new RC.MyDbDataSet();
            this.rentTableAdapter = new RC.MyDbDataSetTableAdapters.RentTableAdapter();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonText = new System.Windows.Forms.Button();
            this.userTableAdapter1 = new RC.MyDbDataSetTableAdapters.UserTableAdapter();
            this.carTableAdapter1 = new RC.MyDbDataSetTableAdapters.CarTableAdapter();
            this.RCTableAdapterManager = new RC.MyDbDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idRentDataGridViewTextBoxColumn,
            this.clientDataGridViewTextBoxColumn,
            this.carDataGridViewTextBoxColumn,
            this.managerDataGridViewTextBoxColumn,
            this.durationDataGridViewTextBoxColumn,
            this.fromPlaceDataGridViewTextBoxColumn,
            this.toPlaceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(638, 241);
            this.dataGridView1.TabIndex = 0;
            // 
            // idRentDataGridViewTextBoxColumn
            // 
            this.idRentDataGridViewTextBoxColumn.DataPropertyName = "idRent";
            this.idRentDataGridViewTextBoxColumn.HeaderText = "idRent";
            this.idRentDataGridViewTextBoxColumn.Name = "idRentDataGridViewTextBoxColumn";
            this.idRentDataGridViewTextBoxColumn.ReadOnly = true;
            this.idRentDataGridViewTextBoxColumn.Width = 45;
            // 
            // clientDataGridViewTextBoxColumn
            // 
            this.clientDataGridViewTextBoxColumn.DataPropertyName = "client";
            this.clientDataGridViewTextBoxColumn.HeaderText = "client";
            this.clientDataGridViewTextBoxColumn.Name = "clientDataGridViewTextBoxColumn";
            // 
            // carDataGridViewTextBoxColumn
            // 
            this.carDataGridViewTextBoxColumn.DataPropertyName = "car";
            this.carDataGridViewTextBoxColumn.HeaderText = "car";
            this.carDataGridViewTextBoxColumn.Name = "carDataGridViewTextBoxColumn";
            // 
            // managerDataGridViewTextBoxColumn
            // 
            this.managerDataGridViewTextBoxColumn.DataPropertyName = "manager";
            this.managerDataGridViewTextBoxColumn.HeaderText = "manager";
            this.managerDataGridViewTextBoxColumn.Name = "managerDataGridViewTextBoxColumn";
            // 
            // durationDataGridViewTextBoxColumn
            // 
            this.durationDataGridViewTextBoxColumn.DataPropertyName = "duration";
            this.durationDataGridViewTextBoxColumn.HeaderText = "duration";
            this.durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
            this.durationDataGridViewTextBoxColumn.Width = 45;
            // 
            // fromPlaceDataGridViewTextBoxColumn
            // 
            this.fromPlaceDataGridViewTextBoxColumn.DataPropertyName = "fromPlace";
            this.fromPlaceDataGridViewTextBoxColumn.HeaderText = "fromPlace";
            this.fromPlaceDataGridViewTextBoxColumn.Name = "fromPlaceDataGridViewTextBoxColumn";
            // 
            // toPlaceDataGridViewTextBoxColumn
            // 
            this.toPlaceDataGridViewTextBoxColumn.DataPropertyName = "toPlace";
            this.toPlaceDataGridViewTextBoxColumn.HeaderText = "toPlace";
            this.toPlaceDataGridViewTextBoxColumn.Name = "toPlaceDataGridViewTextBoxColumn";
            // 
            // rentBindingSource
            // 
            this.rentBindingSource.DataMember = "Rent";
            this.rentBindingSource.DataSource = this.myDbDataSet;
            // 
            // myDbDataSet
            // 
            this.myDbDataSet.DataSetName = "MyDbDataSet";
            this.myDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rentTableAdapter
            // 
            this.rentTableAdapter.ClearBeforeFill = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(566, 269);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Close";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click_1);
            // 
            // buttonText
            // 
            this.buttonText.Location = new System.Drawing.Point(460, 269);
            this.buttonText.Name = "buttonText";
            this.buttonText.Size = new System.Drawing.Size(75, 23);
            this.buttonText.TabIndex = 1;
            this.buttonText.Text = "Save";
            this.buttonText.UseVisualStyleBackColor = true;
            this.buttonText.Click += new System.EventHandler(this.buttonText_Click_1);
            // 
            // userTableAdapter1
            // 
            this.userTableAdapter1.ClearBeforeFill = true;
            // 
            // carTableAdapter1
            // 
            this.carTableAdapter1.ClearBeforeFill = true;
            // 
            // RCTableAdapterManager
            // 
            this.RCTableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.RCTableAdapterManager.CarTableAdapter = this.carTableAdapter1;
            this.RCTableAdapterManager.ClientTableAdapter = null;
            this.RCTableAdapterManager.RentTableAdapter = this.rentTableAdapter;
            this.RCTableAdapterManager.UpdateOrder = RC.MyDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.RCTableAdapterManager.UserTableAdapter = this.userTableAdapter1;
            // 
            // DBRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 326);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonText);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DBRent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DBRent";
            this.Load += new System.EventHandler(this.DBRent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDbDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MyDbDataSet myDbDataSet;
        private System.Windows.Forms.BindingSource rentBindingSource;
        private MyDbDataSetTableAdapters.RentTableAdapter rentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn managerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fromPlaceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toPlaceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonText;
        private MyDbDataSetTableAdapters.UserTableAdapter userTableAdapter1;
        private MyDbDataSetTableAdapters.CarTableAdapter carTableAdapter1;
        private MyDbDataSetTableAdapters.TableAdapterManager RCTableAdapterManager;
    }
}