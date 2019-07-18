using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Assignment_2
{
    public partial class frmCustomerAccountsEdit : Form
    {
        public frmCustomerAccountsEdit()
        {
            InitializeComponent();
        }

        OleDbConnection myConn = new OleDbConnection(dbConnection.dbConnect);

        private void frmCustomerAccountsEdit_Load(object sender, EventArgs e)
        {
            try
            {
                myConn.Open();
                OleDbCommand myCmd = myConn.CreateCommand();
                myCmd.CommandText = @"SELECT * FROM account INNER JOIN customer ON customer.custid = account.custid
                                        WHERE accID = @getID";

                myCmd.Parameters.AddWithValue("getID", dbConnection.accID);

                OleDbDataReader myDR = myCmd.ExecuteReader();

                myDR.Read();
                txtAccID.Text = dbConnection.accID;
                txtCustID.Text = myDR[1].ToString();
                txtBalance.Text = myDR[3].ToString();
                txtAccrued.Text = myDR[4].ToString();
                txtAllowance.Text = myDR[14].ToString();
    
                myConn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                myConn.Close();
            }
        }

        private void frmCustomerAccountsEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void frmCustomerAccountsEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
