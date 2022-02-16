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
    public partial class CustomerAppMenu : Form1
    {
        Controller control = Home.GetController();
        Customer customer;
        public CustomerAppMenu(Customer customer)
        {
            this.customer = customer;
            InitializeComponent();
            label2.Text = "Customer account \n" + this.customer.ID + ": " + this.customer.Name;
            LoadAccount();
        }

        public void LoadAccount()
        {
            

            //for (int i = 0; i < control.customerList.Count; i++)
            //{
            //    customerIdentifier = control.customerList[i].Name;
            //}

            Customer temp = control.customerList[0];
            

            foreach(KeyValuePair<string, double> k in temp.EBal)
            {
                //need variable to contain the name
                if (k.Key.Contains(customer.Name))
                {
                    listBox1.Items.Add(k.Value);
                }
            }

            foreach(KeyValuePair<string, double> k in temp.IBal)
            {
                if (k.Key.Contains(customer.Name))
                {
                    listBox2.Items.Add(k.Value);
                }
            }

            foreach (KeyValuePair<string, double> k in temp.OBal)
            {
                if (k.Key.Contains(customer.Name))
                {
                    listBox3.Items.Add(k.Value);
                }
            }


        }

        //Cancel Button
        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            //new Home().Show();
            Home.GetInstance().Show();
            
        }
    }
}
