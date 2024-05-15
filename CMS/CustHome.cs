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
    public partial class CustHome : Form
    {
        public CustHome()
        {
            InitializeComponent();
        }
        String sqlquery;
        FunctionClass f = new FunctionClass();
        private void BackButton_Click(object sender, EventArgs e)
        {
            sqlquery = "update cinema.Customer set cust_signedin = 'NO' where cust_signedin = 'YES' ";
            f.SetData(sqlquery);
            CustLogin custLogin = new CustLogin();
            this.Hide();
            custLogin.Show();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            sqlquery = "update cinema.Customer set cust_signedin = 'NO' where cust_signedin = 'YES' ";
            f.SetData(sqlquery);
            Application.Exit();
        }

        private void CustHome_Load(object sender, EventArgs e)
        {
            sqlquery = "select cust_firstname + ' ' + cust_lastname from cinema.Customer where cust_signedin = 'YES'";
            DataSet ds = f.GetData(sqlquery);
            String Name = ds.Tables[0].Rows[0][0].ToString();
            NameLabel.Text = Name;
            sqlquery = "select cust_id from cinema.Customer where cust_signedin = 'YES'";
            DataSet d = f.GetData(sqlquery);
            String id = d.Tables[0].Rows[0][0].ToString();
            IDLabel.Text = id;
        }

        private void BookTicketsButton_Click(object sender, EventArgs e)
        {
            bookTicketsUC2.Visible = true;
            bookTicketsUC2.BringToFront();
        }

        private void ViewTransactionsButton_Click(object sender, EventArgs e)
        {
            viewTransactionsUC2.Visible = true;
            viewTransactionsUC2.BringToFront();
        }

        private void NowPlayingButton_Click(object sender, EventArgs e)
        {
            nowPlayingUC1.Visible = true;
            nowPlayingUC1.BringToFront();
        }

        private void ShowtimeButton_Click(object sender, EventArgs e)
        {
            comingSoonUC1.Visible = true;
            comingSoonUC1.BringToFront();
        }

        private void EmpBtn_Click(object sender, EventArgs e)
        {
            custChangePassword1.Visible = true;
            custChangePassword1.BringToFront();
        }

        private void HomePageButton_Click(object sender, EventArgs e)
        {
            custHomePage1.Visible = true;
            custHomePage1.BringToFront();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
