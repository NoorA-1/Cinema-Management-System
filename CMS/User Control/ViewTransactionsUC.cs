using iTextSharp.text;
using iTextSharp.text.pdf;
using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.User_Control
{
    public partial class ViewTransactionsUC : UserControl
    {
        public ViewTransactionsUC()
        {
            InitializeComponent();
        }
        String sqlquery;
        String cust_id;
        FunctionClass f = new FunctionClass();
        private void ViewTransactionsUC_Load(object sender, EventArgs e)
        {
            LoadRecords();
        }
        public void LoadRecords()
        {
            try
            {
                sqlquery = "select cust_id from cinema.Customer where cust_signedin = 'YES'";
                DataSet ds = f.GetData(sqlquery);
                cust_id = ds.Tables[0].Rows[0][0].ToString();
                sqlquery = "select A.cust_id as ID, cust_firstname +' '+cust_lastname as Name, tr_id as TransactionID, tr_amount as TransactionAmount, tr_date as Date, tr_tickquantity as TicketQuantity, screening_id as ScreeningNumber from cinema.Customer as A inner join cinema.Transactions as B on A.cust_id = B.cust_id where A.cust_id = " + cust_id + "";
                DataSet d = f.GetData(sqlquery);

                if (d.Tables[0].Rows.Count > 0)
                {
                    transactionlabel.Visible = false;
                    TransactionDataGridView.Visible = true;
                    TransactionDataGridView.DataSource = d.Tables[0];
                    SaveButton.Visible = true;
                }
                else
                {
                    transactionlabel.Visible = true;
                    SaveButton.Visible = false;
                }
            }
            catch (Exception ex)
            {

            }
        }
        private void ViewTransactionsUC_Enter(object sender, EventArgs e)
        {
            LoadRecords();
        }
        String tickquantity;
        String tramount;
        String paymthd;
        String trdate;
        private void TransactionDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && TransactionDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {

                    TransactionDataGridView.CurrentRow.Selected = true;
                    DataGridViewRow selrow = this.TransactionDataGridView.Rows[e.RowIndex];
                    TrxNumberTextBox.Text = selrow.Cells["TransactionID"].FormattedValue.ToString();
                    ScreeningTextBox.Text = selrow.Cells["ScreeningNumber"].FormattedValue.ToString();
                    tickquantity = selrow.Cells["TicketQuantity"].FormattedValue.ToString();
                    tramount = selrow.Cells["TransactionAmount"].FormattedValue.ToString();
                    sqlquery = "select paymthd from cinema.PaymentMethod as A inner join cinema.Transactions as B on A.paymthd_id = B.paymthd_id where tr_id = " + TrxNumberTextBox.Text + "";
                    DataSet ds = f.GetData(sqlquery);
                    paymthd = ds.Tables[0].Rows[0][0].ToString();
                    trdate = selrow.Cells["Date"].FormattedValue.ToString();
                }
            }
            catch (Exception ex)
            {

            }
            }
        
        

        private void SaveButton_Click(object sender, EventArgs e) { 
        
            if (!String.IsNullOrWhiteSpace(TrxNumberTextBox.Text) && !String.IsNullOrWhiteSpace(ScreeningTextBox.Text))
            {
                try
                {
                String moviename;
                String cinemahall;
                String custname;
                String showdate;
                String showtime;
                sqlquery = "select cust_firstname +' '+cust_lastname from cinema.Customer where cust_signedin = 'YES'";
                DataSet ds1 = f.GetData(sqlquery);
                custname = ds1.Tables[0].Rows[0][0].ToString();
                sqlquery = "select movie_name from cinema.Movie as A inner join cinema.Screening as B on A.movie_id = B.movie_id where screening_id =" + ScreeningTextBox.Text + "";
                DataSet ds2 = f.GetData(sqlquery);
                moviename = ds2.Tables[0].Rows[0][0].ToString();
                sqlquery = "select cinema_name from cinema.CinemaHall as A inner join cinema.Screening as B on A.cinema_id = B.cinema_id where screening_id =" + ScreeningTextBox.Text + "";
                DataSet ds3 = f.GetData(sqlquery);
                cinemahall = ds3.Tables[0].Rows[0][0].ToString();
                sqlquery = "select tick_showdate from cinema.Ticket where tr_id = " + TrxNumberTextBox.Text+"";
                DataSet ds4 = f.GetData(sqlquery);
                showdate = ds4.Tables[0].Rows[0][0].ToString();
                showdate = DateTime.Parse(showdate).Date.ToString("yyyy-MM-dd");
                trdate = DateTime.Parse(trdate).Date.ToString("yyyy-MM-dd");
                sqlquery = "select screening_showtime from cinema.Screening as A inner join cinema.Ticket as B on A.screening_id = B.screening_id where tr_id = " + TrxNumberTextBox.Text+"";
                DataSet ds5 = f.GetData(sqlquery);
                showtime = ds5.Tables[0].Rows[0][0].ToString(); 
                ReceiptTextBox.Clear();
                ReceiptTextBox.Text += "---------------------NPLEX CINEMAS--------------------\n";
                ReceiptTextBox.Text += "                    Invoice:\n";
                ReceiptTextBox.Text += "Customer ID: " + cust_id + "\n";
                ReceiptTextBox.Text += "Customer Name: " + custname + "\n";
                ReceiptTextBox.Text += "Movie: " + moviename + "\n";
                ReceiptTextBox.Text += "Cinema Hall: " + cinemahall + "\n";
                ReceiptTextBox.Text += "Ticket Quantity: " + tickquantity + "\n";
                f.SetSeatNumAndRow(ReceiptTextBox, TrxNumberTextBox.Text,tickquantity);
                ReceiptTextBox.Text += "Show Date: " + showdate + "\n";
                ReceiptTextBox.Text += "Show Time: " + showtime + "\n";
                ReceiptTextBox.Text += "Transaction ID: " + TrxNumberTextBox.Text + "\n";
                ReceiptTextBox.Text += "Transaction Amount: " + tramount + "\n";
                ReceiptTextBox.Text += "Payment Method: " + paymthd + "\n";
                ReceiptTextBox.Text += "Transaction Date: " + trdate + "\n";
                ReceiptTextBox.Text += "---------------------Thank you--------------------";
                f.SavePDF(ReceiptTextBox);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No Record Selected.");
            }
        }
        private void RefreshButton_Click(object sender, EventArgs e)
        {
            LoadRecords();
        }
    }
}

        
    
