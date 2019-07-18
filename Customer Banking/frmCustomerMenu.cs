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
    public partial class frmCustomerMenu : Form
    {
        public frmCustomerMenu()
        {
            InitializeComponent();
        }

        private void btnNewCust_Click(object sender, EventArgs e)
        {
            frmCustomerNew frmCustomersNew = new frmCustomerNew();
            frmCustomersNew.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCustomerSearch frmCustomersSearch = new frmCustomerSearch();
            frmCustomersSearch.Show();
        }
    }
}
