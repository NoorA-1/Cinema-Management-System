using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS
{
    public partial class CustLogin : Form
    {
        public CustLogin()
        {
            InitializeComponent();
            BackPanel.BackColor = Color.FromArgb(180, Color.Black);
        }
        FunctionClass f = new FunctionClass();

        private void BackButton_Click(object sender, EventArgs e)
        {
            Start s = new Start();
            this.Hide();
            s.Show();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CustSignUpButton_Click(object sender, EventArgs e)
        {
            CustSignUp custSignUp = new CustSignUp();
            this.Hide();
            custSignUp.Show();
        }

        private void CustLoginButton_Click(object sender, EventArgs e)
        {
            String sqlquery = "select cust_id from cinema.Customer where cust_username = '" + CustUsernameTextBox.Text + "' and cust_password = '" + CustPasswordTextBox.Text + "'";
            DataSet d = f.GetData(sqlquery);
            
            if (d.Tables[0].Rows.Count != 0)
            {
                try
                {
                    String id = d.Tables[0].Rows[0][0].ToString();
                    sqlquery = "update cinema.Customer set cust_signedin = 'YES' where cust_id =" + id+"";
                    f.SetData(sqlquery);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                CustHome custHome = new CustHome();
                this.Hide();
                custHome.Show();

            }
            else
            {
                InvalidUserPass.Visible = true;
                CustPasswordTextBox.Clear();
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
