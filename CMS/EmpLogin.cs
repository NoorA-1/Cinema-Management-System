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
    public partial class EmpLogin : Form
    {
        FunctionClass f = new FunctionClass();
        public EmpLogin()
        {
            InitializeComponent();
            BackPanel.BackColor = Color.FromArgb(180, Color.Black);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Start s = new Start();
            this.Hide();
            s.Show();
        }

        private void EmpLoginButton_Click(object sender, EventArgs e)
        {
            String sqlquery = "select emp_id from cinema.Employee where emp_username = '" + EmpUsernameTextBox.Text + "' and emp_password = '" + EmpPasswordTextBox.Text + "'";
            DataSet d = f.GetData(sqlquery);
            sqlquery = "select ad_id from cinema.Admin where ad_username = '" + EmpUsernameTextBox.Text + "' and ad_password = '" + EmpPasswordTextBox.Text + "'";
            DataSet ds = f.GetData(sqlquery);
            if (d.Tables[0].Rows.Count != 0)
            {
                try
                {
                    String id = d.Tables[0].Rows[0][0].ToString();
                    sqlquery = "update cinema.Employee set emp_signedin = 'YES' where emp_id =" + id + "";
                    f.SetData(sqlquery);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                EmpHome h = new EmpHome();
                this.Hide();
                h.Show();
            }
            else if (ds.Tables[0].Rows.Count != 0)
            {
                try
                {
                    String id = ds.Tables[0].Rows[0][0].ToString();
                    sqlquery = "update cinema.Admin set ad_signedin = 'YES' where ad_id =" + id + "";
                    f.SetData(sqlquery);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                EmpHome h = new EmpHome();
                this.Hide();
                h.Show();
            }
            else
            {
                InvalidUserPass.Visible = true;
                EmpPasswordTextBox.Clear();
            }
        }
    }
}
