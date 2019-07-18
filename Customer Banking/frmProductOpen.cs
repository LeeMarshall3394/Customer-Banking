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
    public partial class frmProductOpen : Form
    {
        public frmProductOpen()
        {
            InitializeComponent();
        }

        OleDbConnection myConn = new OleDbConnection(dbConnection.dbConnect);
        int prodID;

        private void dtaPop()
        {
            try
            {
                //SQL code to enter a search the database based on the name entered
                string sql = @"SELECT * FROM product WHERE status = @getstatus;";
                //Making a data adapter
                OleDbDataAdapter daSearch = new OleDbDataAdapter(sql, myConn);
                //Parameter passing to avoid SQL injection
                daSearch.SelectCommand.Parameters.AddWithValue("getstatus", "open");
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

        private void frmProductOpen_Load(object sender, EventArgs e)
        {
            dtaPop();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {            
            try
            {
                OleDbCommand mycmd = myConn.CreateCommand();
                mycmd.CommandText = @"UPDATE product SET status = 'closed' WHERE prodid = @getID;";

                mycmd.Parameters.AddWithValue("getID", prodID);

                myConn.Open();

                mycmd.ExecuteNonQuery();

                myConn.Close();

                dtaPop();
            }
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
            if (e.RowIndex > -1)
            {
                prodID = int.Parse(dtaResults[0, e.RowIndex].Value.ToString());
            }
        }
    }
}

