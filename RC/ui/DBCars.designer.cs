namespace RC.ui
{
    partial class DBCars
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
            this.dataGridViewCars = new System.Windows.Forms.DataGridView();
            this.myDbDataSet = new RC.MyDbDataSet();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carTableAdapter = new RC.MyDbDataSetTableAdapters.CarTableAdapter();
            this.idCarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.RCTableAdapterManager = new RC.MyDbDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCars
            // 
            this.dataGridViewCars.AllowUserToDeleteRows = false;
            this.dataGridViewCars.AutoGenerateColumns = false;
            this.dataGridViewCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCars.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCarDataGridViewTextBoxColumn,
            this.brandDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn});
            this.dataGridViewCars.DataSource = this.carBindingSource;
            this.dataGridViewCars.Location = new System.Drawing.Point(57, 12);
            this.dataGridViewCars.Name = "dataGridViewCars";
            this.dataGridViewCars.Size = new System.Drawing.Size(559, 261);
            this.dataGridViewCars.TabIndex = 0;
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
            // idCarDataGridViewTextBoxColumn
            // 
            this.idCarDataGridViewTextBoxColumn.DataPropertyName = "idCar";
            this.idCarDataGridViewTextBoxColumn.HeaderText = "idCar";
            this.idCarDataGridViewTextBoxColumn.Name = "idCarDataGridViewTextBoxColumn";
            // 
            // brandDataGridViewTextBoxColumn
            // 
            this.brandDataGridViewTextBoxColumn.DataPropertyName = "brand";
            this.brandDataGridViewTextBoxColumn.HeaderText = "brand";
            this.brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "location";
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(420, 279);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonText_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(526, 279);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Close";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // RCTableAdapterManager
            // 
            this.RCTableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.RCTableAdapterManager.CarTableAdapter = this.carTableAdapter;
            this.RCTableAdapterManager.ClientTableAdapter = null;
            this.RCTableAdapterManager.RentTableAdapter = null;
            this.RCTableAdapterManager.UpdateOrder = RC.MyDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.RCTableAdapterManager.UserTableAdapter = null;
            // 
            // DBCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 326);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dataGridViewCars);
            this.Name = "DBCars";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DBCars";
            this.Load += new System.EventHandler(this.DBCars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCars;
        private MyDbDataSet myDbDataSet;
        private System.Windows.Forms.BindingSource carBindingSource;
        private MyDbDataSetTableAdapters.CarTableAdapter carTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private MyDbDataSetTableAdapters.TableAdapterManager RCTableAdapterManager;

    }
}