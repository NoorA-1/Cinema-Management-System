using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.User_Control
{
    public partial class CustChangePassword : UserControl
    {
        public CustChangePassword()
        {
            InitializeComponent();
        }
        String passwordpattern = "^[a-zA-Z0-9]{5,15}$";
        String sqlquery;
        FunctionClass f = new FunctionClass();
        private void CurrentPassTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void CurrentPassTextBox_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(CurrentPassTextBox.Text, passwordpattern) == true)
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.CurrentPassTextBox, "Enter valid password. Minimum Length: 5");
                return;
            }
        }

        private void NewPassTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void NewPassTextBox_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(NewPassTextBox.Text, passwordpattern) == true)
            {
                errorProvider2.Clear();
            }
            else
            {
                errorProvider2.SetError(this.NewPassTextBox, "Enter valid password. Minimum Length: 5");
                return;
            }
        }

        private void ChangePassButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(CurrentPassTextBox.Text) && !String.IsNullOrWhiteSpace(NewPassTextBox.Text) && Regex.IsMatch(CurrentPassTextBox.Text,passwordpattern) == true && Regex.IsMatch(NewPassTextBox.Text, passwordpattern) == true)
            {
                try
                {
                    sqlquery = "select cust_id from cinema.Customer where cust_signedin = 'YES'";
                    DataSet ds = f.GetData(sqlquery);
                    String custid = ds.Tables[0].Rows[0][0].ToString();
                    sqlquery = "select cust_password from cinema.Customer where cust_password = '" + CurrentPassTextBox.Text + "' and cust_id = " + custid + "";
                    ds = f.GetData(sqlquery);
                    if (ds.Tables[0].Rows.Count != 0)
                    {
                        sqlquery = "update cinema.Customer set cust_password = '" + NewPassTextBox.Text + "' where cust_id =" + custid + "";
                        f.SetData(sqlquery);
                        MessageBox.Show("Password changed successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CurrentPassTextBox.Clear();
                        NewPassTextBox.Clear();
                    }
                    else
                    {
                        MessageBox.Show("You have entered wrong current password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                if (Regex.IsMatch(CurrentPassTextBox.Text, passwordpattern) == false)
                {
                    MessageBox.Show("Enter valid current password. Minimum Length: 5", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (Regex.IsMatch(NewPassTextBox.Text, passwordpattern) == false)
                {
                    MessageBox.Show("Enter valid new password. Minimum Length: 5", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Insert All Data", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void CustChangePassword_Leave(object sender, EventArgs e)
        {
            CurrentPassTextBox.Clear();
            NewPassTextBox.Clear();
        }

        private void CustChangePassword_Load(object sender, EventArgs e)
        {
            CurrentPassTextBox.Clear();
            NewPassTextBox.Clear();
        }
    }
}
    
