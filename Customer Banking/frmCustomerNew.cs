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
    public partial class frmCustomerNew : Form
    {
        public frmCustomerNew()
        {
            InitializeComponent();
        }

        //Setting up a new connection using a class.
        OleDbConnection myConn = new OleDbConnection(dbConnection.dbConnect);

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            //Set default values for the comboboxes
            cboTitle.SelectedIndex = 0;
            cboDate1.SelectedIndex = 0;
            cboDate2.SelectedIndex = 0;
            cboDate3.SelectedIndex = 0;
        }

        private bool checkTextBox(TextBox x, string name)
        {
            if (x.Text == "")
            {
                MessageBox.Show(name + " has not been filled out.");
                return false;
            }
            else return true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int myInt;
            if (checkTextBox(txtFirstName, "First name"))
            {
                if (checkTextBox(txtLastName, "Last name"))
                {
                    if (checkTextBox(txtNatIns, "Nat ins"))
                    {
                        if (checkTextBox(txtEmail, "Email"))
                        {
                            if (checkTextBox(txtPassword, "Password"))
                            {
                                if (int.TryParse(txtAllowance.Text, out myInt))
                                {
                                    try
                                    {
                                        //Open connection
                                        myConn.Open();
                                        OleDbCommand myCmd = myConn.CreateCommand();
                                        //SQL code to enter a new customer into the database
                                        myCmd.CommandText = @"INSERT INTO customer(title, firstname, lastname, dob, natins, email, pswd, allowance)
                                         VALUES(@gettitle, @getfirstname, @Getlastname, @getdob, @getnatins, @getemail, @getpswd, @getallowance);";

                                        //Parameter passing to avoid SQL injection
                                        myCmd.Parameters.AddWithValue("Gettitle", cboTitle.Text);
                                        myCmd.Parameters.AddWithValue("getfirstname", txtFirstName.Text);
                                        myCmd.Parameters.AddWithValue("getlastname", txtLastName.Text);
                                        myCmd.Parameters.AddWithValue("getdob", cboDate1.Text + "/" + (cboDate2.SelectedIndex + 1) + "/" + cboDate3.Text);
                                        myCmd.Parameters.AddWithValue("getnatins", txtNatIns.Text);
                                        myCmd.Parameters.AddWithValue("getemail", txtEmail.Text);
                                        myCmd.Parameters.AddWithValue("getpassword", txtPassword.Text);
                                        myCmd.Parameters.AddWithValue("getallowance", txtAllowance.Text);

                                        int result = myCmd.ExecuteNonQuery();

                                        //if SQL executed properly
                                        if (result == 1)
                                        {
                                            //Message box saying records added
                                            MessageBox.Show(result + " record(s) added");
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
                                else MessageBox.Show("Allowance hasn't been filled correctly");
                            }
                        }
                    }
                }
            }
        }
    }
}
