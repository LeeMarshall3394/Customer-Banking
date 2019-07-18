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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            //Opens the Customer menu form
            frmCustomerMenu frmCustomersMenu = new frmCustomerMenu();
            frmCustomersMenu.ShowDialog();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            //Opens the Products menu
            frmProductsMenu frmProductsMenu = new frmProductsMenu();
            frmProductsMenu.ShowDialog();
        }

        private void btnAccounts_Click(object sender, EventArgs e)
        {
            //Opens the accounts menu
            frmAccountsMenu frmAccountsMenu = new frmAccountsMenu();
            frmAccountsMenu.ShowDialog();
        }
    }
}
