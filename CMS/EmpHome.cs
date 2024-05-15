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
    public partial class EmpHome : Form
    {
        public EmpHome()
        {
            InitializeComponent();
        }
        String sqlquery;
        FunctionClass f = new FunctionClass();

        private void CloseButton_Click(object sender, EventArgs e)
        {
            sqlquery = "update cinema.Employee set emp_signedin = 'NO' where emp_signedin = 'YES' ";
            f.SetData(sqlquery);
            sqlquery = "update cinema.Admin set ad_signedin = 'NO' where ad_signedin = 'YES' ";
            f.SetData(sqlquery);
            Application.Exit();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            sqlquery = "update cinema.Employee set emp_signedin = 'NO' where emp_signedin = 'YES'";
            f.SetData(sqlquery);
            sqlquery = "update cinema.Admin set ad_signedin = 'NO' where ad_signedin = 'YES' ";
            f.SetData(sqlquery);
            EmpLogin empLogin = new EmpLogin();
            this.Hide();
            empLogin.Show();
        }

        private void EmpBtn_Click(object sender, EventArgs e)
        {
            employeeUC1.Visible = true;
            employeeUC1.BringToFront();
        }

        private void AddMovieBtn_Click(object sender, EventArgs e)
        {
            moviesUC1.Visible = true;
            moviesUC1.BringToFront();
        }

        private void ShowtimeButton_Click(object sender, EventArgs e)
        {
            showtimeUC1.Visible = true;
            showtimeUC1.BringToFront();
        }

        private void AllShowsButton_Click(object sender, EventArgs e)
        {
            allShowsUC1.Visible = true;
            allShowsUC1.BringToFront();
        }

        private void EmpHome_Load(object sender, EventArgs e)
        {
            sqlquery = "select emp_name from cinema.Employee where emp_signedin = 'YES'";
            DataSet ds = f.GetData(sqlquery);
            if (ds.Tables[0].Rows.Count > 0)
            {
                String Name = ds.Tables[0].Rows[0][0].ToString();
                NameLabel.Text = Name;
                sqlquery = "select emp_id from cinema.Employee where emp_signedin = 'YES'";
                DataSet d = f.GetData(sqlquery);
                String id = d.Tables[0].Rows[0][0].ToString();
                IDLabel.Text = id;
                EmpBtn.Visible = false;
            }
            else
            {
                NameLabel.Text = "Admin";
                IDLabel.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                EmpBtn.Visible = true;
                EmpChangePassword.Visible = false;
            }
        }

        private void CustDetailBtn_Click(object sender, EventArgs e)
        {
            custDetails1.Visible = true;
            custDetails1.BringToFront();
        }

        private void EmpChangePassword_Click(object sender, EventArgs e)
        {
            empChangePassword1.Visible = true;
            empChangePassword1.BringToFront();
        }

        private void HomePageButton_Click(object sender, EventArgs e)
        {
            empHomePage1.Visible = true;
            empHomePage1.BringToFront();
        }
    }
}
