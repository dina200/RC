using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NewRC.db;
using NewRC.classes;

namespace NewRC.ui
{
    public partial class CreateClientForm : Form
    {
        private dbHelper db;
        public CreateClientForm()
        {
            InitializeComponent();
            db = new dbHelper();
            db.openDb();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            string name = clientNametextBox.Text;
            string pass = clientPassportTextBox.Text;
            string tel = clientTeltextBox.Text;
            Client cl = db.addClient(pass, name, tel);
            if (cl == null || 
                clientNametextBox.Text == "" &&
                clientPassportTextBox.Text == "" &&
                clientTeltextBox.Text == "")
            {
                MessageBox.Show("Error! Client isn't added");
            }
            else
            {
                MessageBox.Show("Client " + name + " is created");
               clientNametextBox.Text = "";
               clientPassportTextBox.Text = "";
               clientTeltextBox.Text = "";
            }
            this.Validate();
            RCTableAdapterManager.UpdateAll(this.myDbDataSet);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
