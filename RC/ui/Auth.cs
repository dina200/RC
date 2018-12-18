using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RC.classes;
using RC.db;

namespace RC.ui
{
    public partial class Auth : Form
    {
        private dbHelper db;
        public Auth()
        {
            InitializeComponent();
            db = new dbHelper();
            db.openDb();
           
            passTextBox.MaxLength = 8;
            passTextBox.PasswordChar = '*';
            passTextBox.CharacterCasing = CharacterCasing.Lower;
        }

        private void authButton_Click(object sender, EventArgs e)
        {
            String login = loginTextBox.Text;
            String pass = passTextBox.Text;
            User user = null;

            if (login.Equals("admin"))
            {
                user = new Admin();
                user.login = login;
                user.password = pass;
            }
            else
            {
                user = new Manager();
                user.login = login;
                user.password = pass;
            }
            if (db.authorisation(login, pass, user) != null)
            {
                user = db.authorisation(login, pass, user);
                new RentCar(user).Show();
                db.close();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Error! Not correct data");
                loginTextBox.Text = "";
                passTextBox.Text = "";
            }
        }

        private void registButton_Click(object sender, EventArgs e)
        {
            new Regist().Show();
        }
             

    }
}
