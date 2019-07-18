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
    public partial class frmProductsMenu : Form
    {
        public frmProductsMenu()
        {
            InitializeComponent();
        }

        private void btnEditProducts_Click(object sender, EventArgs e)
        {
            //Open the product edit form
            frmProductEdit frmProductEdit = new frmProductEdit();
            frmProductEdit.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Open the open products form
            frmProductOpen frmProductOpen = new frmProductOpen();
            frmProductOpen.ShowDialog();
        }
    }
}
