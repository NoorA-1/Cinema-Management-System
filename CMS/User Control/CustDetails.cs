using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.User_Control
{
    public partial class CustDetails : UserControl
    {
        public CustDetails()
        {
            InitializeComponent();
        }
        String sqlquery;
        FunctionClass f = new FunctionClass();
        private void CustDetails_Load(object sender, EventArgs e)
        {
            CustFilterComBox.SelectedIndex = 0;
        }

        private void CustFilterComBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustFilterComBox.SelectedIndex == 0)
            {
                try
                {
                    sqlquery = "select cust_firstname +' '+cust_lastname as CustomerName, cust_phone as PhoneNumber,cust_email as Email from cinema.Customer order by CustomerName";
                    DataSet ds = f.GetData(sqlquery);
                    CustGridView.DataSource = ds.Tables[0];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (CustFilterComBox.SelectedIndex == 1)
            {
                try
                {
                    sqlquery = "select cust_firstname +' '+cust_lastname as CustomerName, cust_phone as PhoneNumber,cust_email as Email, Sum(tr_amount) as AmountSpent from cinema.Customer as A inner join cinema.Transactions as B on A.cust_id = B.cust_id group by cust_firstname +' '+cust_lastname,cust_phone,cust_email order by AmountSpent desc;";
                    DataSet ds = f.GetData(sqlquery);
                    CustGridView.DataSource = ds.Tables[0];

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (CustFilterComBox.SelectedIndex == 2)
            {
                try
                {
                    sqlquery = "select cust_firstname +' '+cust_lastname as CustomerName, cust_phone as PhoneNumber,cust_email as Email from cinema.Customer where cust_id not in (select cust_id from cinema.Transactions) order by CustomerName;";
                    DataSet ds = f.GetData(sqlquery);
                    CustGridView.DataSource = ds.Tables[0];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}

