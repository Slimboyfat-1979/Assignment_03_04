using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_03_04
{
    public partial class AddCustomer : Form1
    {
        Controller control = Home.GetController();
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            double eBal = Convert.ToDouble(txtEBal.Text);
            double iBal = Convert.ToDouble(txtIBal.Text);
            double oBal = Convert.ToDouble(txtOBal.Text);

            Everyday everyday = new Everyday(name, eBal);
            Investment investment = new Investment(name, iBal);
            Omni omni = new Omni(name, oBal);

           
            control.AddCustomer(new Customer(name, Everyday.GetEBalances(), Investment.GetIBalances(), Omni.GetOBalances()));
            MessageBox.Show("Customer has been added!");
            this.Hide();
            Home.GetInstance().Clear();
            Home.GetInstance().LoadCustomers();
            Home.GetInstance().Show();
        }
    }
}
