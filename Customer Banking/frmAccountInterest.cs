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
    public partial class frmAccountInterest : Form
    {
        public frmAccountInterest()
        {
            InitializeComponent();
        }

        //Make a connection
        OleDbConnection myConn = new OleDbConnection(dbConnection.dbConnect);

        private void dataFill()
        {
            try
            {
                //SQL code to enter a search the database based on the name entered
                string sql = @"SELECT account.accid, account.balance, account.accrued, product.intrate 
                                FROM account INNER JOIN product ON account.prodid = product.prodid;";
                //Making a data adapter
                OleDbDataAdapter daSearch = new OleDbDataAdapter(sql, myConn);
                //Open connection
                myConn.Open();
                //Making new datatable
                DataTable dtSearch = new DataTable();

                //Fill the data adapter with the datatable
                daSearch.Fill(dtSearch);

                //Filling the datagrid with the data adapter
                dtaResults.DataSource = dtSearch;

                //Closing the connection
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
        private void frmAccountInterest_Load(object sender, EventArgs e)
        {
            //Run the datafill function
            dataFill();
        }

        private void btnInterest_Click(object sender, EventArgs e)
        {
            try
            {
                //Open connection
                myConn.Open();

                //Make a command
                OleDbCommand myCmd = myConn.CreateCommand();
                //Set the command sql to calculate the interest and add it to the accrued.
                myCmd.CommandText = @"UPDATE product INNER JOIN account ON product.prodid = account.prodid 
                                    SET account.accrued = (accrued+(balance*product.intrate/365));";
                //Run the sql
                myCmd.ExecuteReader();

                //Close the connection
                myConn.Close();
                //Run the datafill function
                dataFill();
            }
            catch (Exception ex)
            {
                //Show error message in textbox
                MessageBox.Show(ex.Message);
                //Close the connection
                myConn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Open connection
                myConn.Open();

                //Make a command
                OleDbCommand myCmd = myConn.CreateCommand();
                //Set the command sql to add the interest into the balance and reset the accrued field
                myCmd.CommandText = @"UPDATE account, customer SET account.balance = (account.balance+account.accrued), account.accrued = @getAccrued, 
                                        customer.allowance = @getallowance;";
                //Parameter passing
                myCmd.Parameters.AddWithValue("getAccrued", 0);
                myCmd.Parameters.AddWithValue("getallowance", 15000);
                //Run the sql
                myCmd.ExecuteReader();


                //Close the connection
                myConn.Close();
                //Run the datafill function
                dataFill();
            }
            catch (Exception ex)
            {
                //Show error message in textbox
                MessageBox.Show(ex.Message);
                //Close the connection
                myConn.Close();
            }
        }
    }
}
