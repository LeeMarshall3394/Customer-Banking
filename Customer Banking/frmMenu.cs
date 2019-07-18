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
            frmCustomerMenu frmCustomersMenu = new frmCustomerMenu();
            frmCustomersMenu.ShowDialog();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            frmProductsMenu frmProductsMenu = new frmProductsMenu();
            frmProductsMenu.ShowDialog();
        }

        private void btnAccounts_Click(object sender, EventArgs e)
        {
            frmAccountsMenu frmAccountsMenu = new frmAccountsMenu();
            frmAccountsMenu.ShowDialog();
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            frmTransactionsMenu btnTransactionsMenu = new frmTransactionsMenu();
            btnTransactionsMenu.ShowDialog();
        }
    }
}
