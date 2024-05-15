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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
            BackPanel.BackColor = Color.FromArgb(125, Color.Black);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StartEmpButton_Click(object sender, EventArgs e)
        {
            EmpLogin empLogin = new EmpLogin();
            this.Hide();
            empLogin.Show();
        }

        private void StartCustButton_Click(object sender, EventArgs e)
        {
            CustLogin custLogin = new CustLogin();
            this.Hide();
            custLogin.Show();
        }

        private void Start_Load(object sender, EventArgs e)
        {
            FunctionClass f = new FunctionClass();
            String sqlquery = "update cinema.Customer set cust_signedin = 'NO' where cust_signedin = 'YES' ";
            f.SetData(sqlquery);
            sqlquery = "update cinema.Employee set emp_signedin = 'NO' where emp_signedin = 'YES' ";
            f.SetData(sqlquery);
            sqlquery = "update cinema.Admin set ad_signedin = 'NO' where ad_signedin = 'YES'";
            f.SetData(sqlquery);
        }
    }
}
