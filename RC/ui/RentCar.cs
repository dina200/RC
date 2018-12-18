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
using RC.ui;

namespace RC
{
    public partial class RentCar : Form
    {
        private dbHelper db;
        private User user;
        private int totalPrice;

        public Admin admin { get; set; }
        public Manager manager { get; set; }

        public RentCar()
        {
            InitializeComponent();
            db = new dbHelper();
            db.openDb();
            totalPrice = 0;
        }

        public RentCar(User user) : this()
        {
            userNameLabel.Text = user.login;
            this.user = user;
            
            if (this.user.Equals("admin"))
            {
                dbCarsButton.Visible = true;
            }
            else 
            {
                dbCarsButton.Visible = false;
            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            string passport = comboBox1.SelectedValue.ToString();
            string carId = numCarComboBox.SelectedValue.ToString();
            int duration = Convert.ToInt32(durationComboBox.Value);
            string from = fromTextBox.Text;
            string to = toTextBox.Text;
            if (db.createRent(passport, carId, user, from, to, duration))
            {
                MessageBox.Show("Rent is created");
            }
            else {
                MessageBox.Show("Rent doesn't create");
            }
            this.Validate();
            RCTableAdapterManager.UpdateAll(this.myDbDataSet);
        }

        private void RentCar_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDbDataSet.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.myDbDataSet.Client);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDbDataSet.User". При необходимости она может быть перемещена или удалена.           
            this.clientTableAdapter.Fill(this.myDbDataSet.Client);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDbDataSet.Rent". При необходимости она может быть перемещена или удалена.
            this.rentTableAdapter.Fill(this.myDbDataSet.Rent);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDbDataSet.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.myDbDataSet.Client);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDbDataSet.Car". При необходимости она может быть перемещена или удалена.
            this.carTableAdapter.Fill(this.myDbDataSet.Car);

        }

        private void buttonNewClient_Click(object sender, EventArgs e)
        {
            new CreateClientForm().Show();
        }

        private void numCarComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Car c = db.selectCar(numCarComboBox.SelectedValue.ToString());
            brandCarTextBox.Text = c.brand;
            modelCarTextBox.Text = c.model;
            locationTextBox.Text = c.location;
            fromTextBox.Text = c.location;
            totalPrice = c.price;
        }


        private void durationComboBox_ValueChanged(object sender, EventArgs e)
        {
            priceTextBox.Text = (totalPrice * Convert.ToInt32(durationComboBox.Value)).ToString();
        }

        private void dbCarsButton_Click(object sender, EventArgs e)
        {
            new DBCars().Show();
        }

        private void dbRentButton_Click(object sender, EventArgs e)
        {
            new DBRent().Show();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            db.close();
            Environment.Exit(0);
        }

        private void dbClients_Click(object sender, EventArgs e)
        {
            new DBClient().Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue != null)
            {
                Client c = db.selectClient(comboBox1.SelectedValue.ToString());
                clientTeltextBox.Text = c.phone;
                clientNameTextBox.Text = c.name;
            }
        }        
    }
}
