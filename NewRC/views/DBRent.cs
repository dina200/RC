using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NewRC.ui
{
    public partial class DBRent : Form
    {
        public DBRent()
        {
            InitializeComponent();
            
        }

        private void DBRent_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDbDataSet.Rent". При необходимости она может быть перемещена или удалена.
            this.rentTableAdapter.Fill(this.myDbDataSet.Rent);
           
        }
 

        private void buttonCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonText_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            rentBindingSource.EndEdit();
            RCTableAdapterManager.UpdateAll(this.myDbDataSet);
        }
    }
}
