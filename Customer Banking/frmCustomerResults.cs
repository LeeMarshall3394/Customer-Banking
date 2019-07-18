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
    public partial class frmCustomerResults : Form
    {
        public frmCustomerResults()
        {
            InitializeComponent();
        }

        //Setting up a new connection using a class.
        OleDbConnection myConn = new OleDbConnection(dbConnection.dbConnect);

        private void frmCustomerResults_Load(object sender, EventArgs e)
        {
            try
            {
                //Open connection
                myConn.Open();
                //Make a new command
                OleDbCommand myCmd = myConn.CreateCommand();
                //SQL code to enter a new customer into the database
                myCmd.CommandText = @"SELECT * FROM customer WHERE custid = @getID;";
                //Parameter passing
                myCmd.Parameters.AddWithValue("getID", dbConnection.custID);
                //Making a data reader so i can extract data from the database
                OleDbDataReader myDr = myCmd.ExecuteReader();

                //Read the matching record
                myDr.Read();
                //Add the customer's information to the textboxes.
                txtID.Text = myDr[0].ToString();
                txtTitle.Text = myDr[1].ToString();
                txtFirstName.Text = myDr[2].ToString();
                txtLastName.Text = myDr[3].ToString();
                txtDOB.Text = myDr[4].ToString();
                txtNatins.Text = myDr[5].ToString();
                txtEmail.Text = myDr[6].ToString();
                txtPassword.Text = myDr[7].ToString();
                txtAllowance.Text = myDr[8].ToString();
                //Close the connection
                myConn.Close();
            }
            //Catch any errors
            catch (Exception ex)
            {
                //Show what the error was
                MessageBox.Show(ex.Message);
                //Close the connection
                myConn.Close();
            }
        }
    }
}
