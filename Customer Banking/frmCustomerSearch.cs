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
    public partial class frmCustomerSearch : Form
    {
        public frmCustomerSearch()
        {
            InitializeComponent();
        }

        //Setting up a new connection using a class.
        OleDbConnection myConn = new OleDbConnection(dbConnection.dbConnect);

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                //SQL code to enter a search the database based on the name entered
                string sql = @"SELECT custid, title, firstname, lastname, dob, allowance FROM customer 
                                WHERE firstname LIKE @getname;";
                //Making a data adapter
                OleDbDataAdapter daSearch = new OleDbDataAdapter(sql, myConn);
                //Parameter passing to avoid SQL injection
                daSearch.SelectCommand.Parameters.AddWithValue("getname", txtSearch.Text + "%");
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
        
        private void dtaResults_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //Make sure cell clicked isn't a header cell
            if(e.RowIndex > -1)
            {
                //Put the customer id into the dbconnection class
                dbConnection.custID = dtaResults[0, e.RowIndex].Value.ToString();

                //Open the results form
                frmCustomerAccounts frmcustomerAccounts = new frmCustomerAccounts();
                frmcustomerAccounts.ShowDialog();
            }
        }
    }
}
