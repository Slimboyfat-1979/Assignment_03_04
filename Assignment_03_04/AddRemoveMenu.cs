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
    public partial class AddRemoveMenu : Form1
    {
        public AddRemoveMenu()
        {
            InitializeComponent();
        }

        //Add Customer
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddCustomer().Show();
        }
    }
}
