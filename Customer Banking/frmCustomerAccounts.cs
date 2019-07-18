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
    public partial class frmCustomerAccounts : Form
    {
        public frmCustomerAccounts()
        {
            InitializeComponent();
        }

        //Setting up a new connection using a class.
        OleDbConnection myConn = new OleDbConnection(dbConnection.dbConnect);

        private void fillData()
        {
            try
            {
                //SQL code to enter a search the database based on the ID selected.
                string sql = @"SELECT * FROM account 
                                WHERE custid = @getID;";
                //Open connection
                myConn.Open();
                //Making a data adapter
                OleDbDataAdapter daSearch = new OleDbDataAdapter(sql, myConn);
                //Making new datatable
                DataTable dtSearch = new DataTable();
                //Parameter passing to avoid SQL injection
                daSearch.SelectCommand.Parameters.AddWithValue("getID", dbConnection.custID);

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

        //private void dtaResults_CellClick_1(object sender, DataGridViewCellEventArgs e)
        //{
        //    //Make sure cell clicked isn't a header cell and that the cell isn't empty
        //    if (e.RowIndex > -1 && dtaResults.CurrentCell.Value.ToString() != "3")
        //    {
        //        dbConnection.custID = dtaResults[0, e.RowIndex].Value.ToString();

        //        //Open the results form
        //        frmCustomerResults frmcustomerresults = new frmCustomerResults();
        //        frmcustomerresults.ShowDialog();
        //    }
        //}

        private void frmCustomerAccounts_Load(object sender, EventArgs e)
        {
            fillData();
        }

        private void dtaResults_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Make sure cell clicked isn't a header cell and that the cell isn't empty
            if (e.RowIndex > -1 && dtaResults.CurrentCell.Value.ToString() != "")
            {
                //Put the customer id into the dbconnection class
                dbConnection.accID = dtaResults[0, e.RowIndex].Value.ToString();

                //Open the results form
                frmCustomerAccountsEdit frmcustomerAccountsEdit = new frmCustomerAccountsEdit();
                frmcustomerAccountsEdit.ShowDialog();
                fillData();
            }
        }

        private void dtaResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }        
    }
}
