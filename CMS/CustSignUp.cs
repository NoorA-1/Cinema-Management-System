using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS
{
    public partial class CustSignUp : Form
    {
        public CustSignUp()
        {
            InitializeComponent();
            BackPanel.BackColor = Color.FromArgb(180, Color.Black);
        }
        String emailpattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,3})$";
        String usernamepattern = "^[a-zA-Z0-9]{4,15}$";
        String phonepattern = "^0\\d{3}\\d{7}$";
        String passwordpattern = "^[a-zA-Z0-9]{5,15}$";
        String sqlquery;
        FunctionClass f = new FunctionClass();
        private void CustFirstNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CustLastNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CustEmailTextBox_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(CustEmailTextBox.Text, emailpattern) == true)
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.CustEmailTextBox, "Enter valid email address.");
                return;
            }
        }

        private void CustUsernameTextBox_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(CustUsernameTextBox.Text, usernamepattern) == true)
            {
                errorProvider2.Clear();
            }
            else
            {
                errorProvider2.SetError(this.CustUsernameTextBox, "Enter valid username. (Only alphabets and numbers are allowed)");
                return;
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            CustLogin custLogin = new CustLogin();
            this.Hide();
            custLogin.Show();
        }

        private void CustSignUpButton_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrWhiteSpace(CustFirstNameTextBox.Text) && !String.IsNullOrWhiteSpace(CustLastNameTextBox.Text) && !String.IsNullOrWhiteSpace(CustPhoneTextBox.Text) && !String.IsNullOrWhiteSpace(CustDOB.Text) && !String.IsNullOrWhiteSpace(CustEmailTextBox.Text) && !String.IsNullOrWhiteSpace(CustUsernameTextBox.Text) && !String.IsNullOrWhiteSpace(CustPasswordTextBox.Text) && Regex.IsMatch(CustEmailTextBox.Text, emailpattern) == true && Regex.IsMatch(CustUsernameTextBox.Text, usernamepattern) == true && Regex.IsMatch(CustPhoneTextBox.Text, phonepattern) == true && Regex.IsMatch(CustPasswordTextBox.Text, passwordpattern) == true)
            {
                errorProvider1.Clear();
                errorProvider2.Clear();
                errorProvider3.Clear();
                errorProvider4.Clear();
                try
                {
                    sqlquery = "insert into cinema.customer (cust_firstname,cust_lastname,cust_phone,cust_dob,cust_email,cust_username,cust_password) values ('" + CustFirstNameTextBox.Text+"','"+CustLastNameTextBox.Text+"',"+CustPhoneTextBox.Text+",'"+CustDOB.Text+"','"+CustEmailTextBox.Text+"','"+CustUsernameTextBox.Text+"','"+CustPasswordTextBox.Text+"')";
                    f.SetData(sqlquery, "Sign Up Completed.");
                    ClearAllFields();
                }
                catch (SqlException exp)
                {
                    if (exp.Number == 2627)  
                    {
                        MessageBox.Show("Email or Username Already Exists, Enter a unique Email or Username.", "Duplication", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                if (Regex.IsMatch(CustEmailTextBox.Text, emailpattern) == false)
                {
                    MessageBox.Show("Enter valid Email", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (Regex.IsMatch(CustUsernameTextBox.Text, usernamepattern) == false)
                {
                    MessageBox.Show("Enter valid username. (Only alphabets and numbers are allowed)", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (Regex.IsMatch(CustPhoneTextBox.Text, phonepattern) == false)
                {
                    MessageBox.Show("Enter valid phone number (03331234567), Length should be 11", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (Regex.IsMatch(CustPasswordTextBox.Text, passwordpattern) == false)
                {
                    MessageBox.Show("Enter valid password. Minimum Length: 5", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Insert All Data.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public void ClearAllFields()
        {
            CustFirstNameTextBox.Clear();
            CustLastNameTextBox.Clear();
            CustPhoneTextBox.Clear();
            CustEmailTextBox.Clear();
            CustUsernameTextBox.Clear();
            CustPasswordTextBox.Clear();
        }

        private void CustPhoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CustPhoneTextBox_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(CustPhoneTextBox.Text, phonepattern) == true)
            {
                errorProvider3.Clear();
            }
            else
            {
                errorProvider3.SetError(this.CustPhoneTextBox, "Enter valid phone number (03331234567), Length should be 11");
                return;
            }
        }

        private void CustPasswordTextBox_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(CustPasswordTextBox.Text, passwordpattern) == true)
            {
                errorProvider4.Clear();
            }
            else
            {
                errorProvider4.SetError(this.CustPasswordTextBox, "Enter valid password. Minimum Length: 5");
                return;
            }
        }

        private void CustUsernameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CustPasswordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
