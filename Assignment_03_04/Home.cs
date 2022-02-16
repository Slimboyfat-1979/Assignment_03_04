using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_03_04
{
    public partial class Home : Form1
    {
        //Account types 0 - Everyday, 1 - Investment, 2 - Omni
        public static Controller control = new Controller();
        private static Home home;
    
        
        int[] accountTypes = new int[3];
        private Home()
        {
            InitializeComponent();
            ReadInitialFile();
           
            LoadCustomers();
        }

        public static Home GetInstance()
        {
            if (home == null)
            {
                home = new Home();
                
            }
            return home;

        }
        public static Controller GetController()
        {
            return control;
        }

        public void Clear()
        {
            listBox1.Items.Clear();
        }
        public void LoadCustomers()
        {
            listBox1.Items.Add("ID" + "\t" + "Name");
            foreach (Customer c in control.customerList)
            {
                listBox1.Items.Add(c.ID + "\t" + c.Name);
            }
        }

        public void ReadInitialFile()
        {
            string[] customerInfo;
            StreamReader reader = new StreamReader("/Data1.txt");
            while (!reader.EndOfStream)
            {
                customerInfo = reader.ReadLine().Split(',');
                accountTypes[0] = Convert.ToInt32(customerInfo[1]);
                accountTypes[1] = Convert.ToInt32(customerInfo[4]);
                accountTypes[2] = Convert.ToInt32(customerInfo[7]);
                SetupAccounts(accountTypes, customerInfo);

            }
        }
       public void SetupAccounts(int[] accountTypes, string[] customerInfo)
        {
            if(accountTypes[0] == 0)
            {
                new Everyday(customerInfo[0], Convert.ToDouble(customerInfo[2]));
                
            }
            if(accountTypes[1] == 1)
            {
                new Investment(customerInfo[0], Convert.ToDouble(customerInfo[5]));
            }
            if(accountTypes[2] == 2)
            {
                new Omni(customerInfo[0], Convert.ToDouble(customerInfo[8]));
            }

            control.AddCustomer(new Customer(customerInfo[0], Everyday.GetEBalances(), Investment.GetIBalances(), Omni.GetOBalances()));
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            Customer customer = control.Getcustomer(index-1);
            this.Hide();
            new CustomerAppMenu(customer).Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddRemoveMenu().Show();
        }
    }
}
