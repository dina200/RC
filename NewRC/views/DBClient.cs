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
    public partial class DBClient : Form
    {
        public DBClient()
        {
            InitializeComponent();
        }

        private void DBClient_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDbDataSet.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.myDbDataSet.Client);

        }



        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonText_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            clientBindingSource.EndEdit();
            RCTableAdapterManager.UpdateAll(this.myDbDataSet);
          
                 
        }
    }
}
