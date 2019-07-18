using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    public partial class frmAccountsMenu : Form
    {
        public frmAccountsMenu()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmAccountsCustomer frmAccountsCustomer = new frmAccountsCustomer();
            frmAccountsCustomer.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAccountInterest frmAccountInterest = new frmAccountInterest();
            frmAccountInterest.ShowDialog();
        }
    }
}
