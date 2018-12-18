using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NewRC.db;

namespace NewRC.ui
{    
    public partial class Regist : Form
    {
        private dbHelper db;
        public Regist()
        {
            InitializeComponent();
            db = new dbHelper();
            db.openDb();
            passdRegTextBox.MaxLength = 8;
            passdRegTextBox.PasswordChar = '*';
            passdRegTextBox.CharacterCasing = CharacterCasing.Lower;
            confPassRegTextBox.MaxLength = 8;
            confPassRegTextBox.PasswordChar = '*';
            confPassRegTextBox.CharacterCasing = CharacterCasing.Lower;
        }

        private void regButton_Click(object sender, EventArgs e)
        {
            string username = newLoginTextBox.Text;
            string pass = passdRegTextBox.Text;
            if (newLoginTextBox.Text != "" &&
                passdRegTextBox.Text != "" &&
                passdRegTextBox.Text == confPassRegTextBox.Text)
            {
                db.registration(username, pass);

                this.Close();
            }
            else
            {
                MessageBox.Show("You can't create the user, try again");
                newLoginTextBox.Text = "";
                passdRegTextBox.Text = "";
                confPassRegTextBox.Text = "";
            } 
        }

     
    }
}
