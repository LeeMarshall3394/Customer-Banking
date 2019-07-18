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
    public partial class frmProductEdit : Form
    {
        public frmProductEdit()
        {
            InitializeComponent();
        }

        //Make a new connection using the connection settings kept in the dbconnection class.
        OleDbConnection myConn = new OleDbConnection(dbConnection.dbConnect);

        private void frmProductEdit_Load(object sender, EventArgs e)
        {
            try
            {
                //Open connection
                myConn.Open();
                //Make a new command
                OleDbCommand myCmd = myConn.CreateCommand();
                //SQL code to pull products from the database
                myCmd.CommandText = @"SELECT * FROM product;";
                //Making a data reader so i can extract data from the database
                OleDbDataReader myDr = myCmd.ExecuteReader();

                //While there's another matching record to read
                while (myDr.Read())
                {
                    //Add the product ID to the combobox
                    cboID.Items.Add(myDr["prodid"].ToString());
                }

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

        private void cboID_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Declare a variable
            int transin;
            try
            {
                //Open connection
                myConn.Open();
                //Make a new command
                OleDbCommand myCmd = myConn.CreateCommand();
                //SQL code to enter a new customer into the database
                myCmd.CommandText = @"SELECT * FROM product WHERE prodid = @getID;";
                //Parameter passing
                myCmd.Parameters.AddWithValue("getID", cboID.SelectedItem.ToString());
                //Making a data reader so i can extract data from the database
                OleDbDataReader myDr = myCmd.ExecuteReader();

                //Read the database
                myDr.Read();
                //Change the value of 'transin' depending on whether the transin
                //field is true or false.
                if (myDr[3].ToString() == "True")
                {
                    transin = 1;
                }
                else
                {
                    transin = 0;
                }
                txtName.Text = myDr[1].ToString();
                cboStatus.Text = myDr[2].ToString();
                cboTransin.SelectedIndex = transin;
                txtIntRate.Text = myDr[4].ToString();
                
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                //Open the connection
                myConn.Open();
                //Make a command
                OleDbCommand myCmd = myConn.CreateCommand();
                //Setting sql command
                myCmd.CommandText = @"UPDATE product SET product.name = @getName, product.status = @getStatus, 
                                        product.transin = @getTransin, product.intrate = @getIntrate
                                        WHERE product.prodid = @getID;";

                //Parameter passing
                myCmd.Parameters.AddWithValue("getName",txtName.Text);
                myCmd.Parameters.AddWithValue("getStatus", cboStatus.Text);
                myCmd.Parameters.AddWithValue("getTransin", cboTransin.SelectedIndex);
                myCmd.Parameters.AddWithValue("getIntrate", double.Parse(txtIntRate.Text));
                myCmd.Parameters.AddWithValue("getID", cboID.SelectedItem);
                myCmd.ExecuteNonQuery();

                //Close the connection
                myConn.Close();
                //Open message box saying product updated
                MessageBox.Show("Product updated");
            }
            catch (Exception ex)
            {
                //Open a message box showing the error
                MessageBox.Show(ex.Message);
                //Close the connection
                myConn.Close();
            }
        }
    }
}
