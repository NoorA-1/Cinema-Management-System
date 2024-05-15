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
    public partial class CinemaCUC : UserControl
    {
        public CinemaCUC()
        {
            InitializeComponent();
        }
        String sqlquery;
        public int[] bookedseats = new int[10];
        public String[] seatids = new String[10];
        public int counter = 0;
        int totalprice;
        public String totalcount;
        FunctionClass f = new FunctionClass();
        public void setComBox(String sqlquery, ComboBox comboBox)
        {
            try
            {
                SqlDataReader dr = f.GetDataReader(this.sqlquery);
                while (dr.Read())
                {
                    for (int i = 0; i < dr.FieldCount; i++)
                    {
                        comboBox.Items.Add(dr.GetString(i));
                    }
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Button lastButton = null;
        public void IsClicked(Button button)
        {
            if (lastButton != null)
            {
                lastButton.BackColor = Color.LightBlue;
            }
            button.BackColor = Color.Green;
            SeatNumberTextBox.Text = button.Text;
            lastButton = button;
        }

        public void IsBooked(Button button)
        {
                lastButton = null;
                button.Enabled = false;
                button.BackColor = Color.Coral;
                bookedseats[counter++] = int.Parse(button.Text);
        }

        public void GetSeatID()
        {
            for (int i = 0; i < seatids.Length; i++)
            {
                if (bookedseats[i] != 0)
                {
                    sqlquery = "select seat_id from cinema.Seat where seat_number = " + bookedseats[i] + " and cinema_id = " + BookTicketsUC.instance.cinemaid + "";
                    DataSet ds = f.GetData(sqlquery);
                    seatids[i] = ds.Tables[0].Rows[0][0].ToString();
                }
                else
                {
                    return;
                }
            }
        }

        private void seat1_Click(object sender, EventArgs e)
        {
            IsClicked(seat1);
        }

        private void seat2_Click(object sender, EventArgs e)
        {
            IsClicked(seat2);
        }

        private void seat3_Click(object sender, EventArgs e)
        {
            IsClicked(seat3);
        }

        private void seat4_Click(object sender, EventArgs e)
        {
            IsClicked(seat4);
        }

        private void seat5_Click(object sender, EventArgs e)
        {
            IsClicked(seat5);
        }

        private void seat6_Click(object sender, EventArgs e)
        {
            IsClicked(seat6);
        }

        private void seat7_Click(object sender, EventArgs e)
        {
            IsClicked(seat7);
        }

        private void seat8_Click(object sender, EventArgs e)
        {
            IsClicked(seat8);
        }

        private void seat9_Click(object sender, EventArgs e)
        {
            IsClicked(seat9);
        }

        private void seat10_Click(object sender, EventArgs e)
        {
            IsClicked(seat10);
        }


        private void BookButton_Click(object sender, EventArgs e)
        {
            sqlquery = "select count(tick_id) from cinema.Ticket where cust_id = (select cust_id from cinema.Customer where cust_signedin = 'YES') and screening_id = " + BookTicketsUC.instance.screeningid + " and tick_showdate = '" + BookTicketsUC.instance.showdate + "'";
            DataSet ds = f.GetData(sqlquery);
            int tickcount = int.Parse(ds.Tables[0].Rows[0][0].ToString());
            //int sum = tickcount + counter;
            if (lastButton != null)
            {
                    if (SeatNumberTextBox.Text == "1")
                    {
                        IsBooked(seat1);
                    }
                    else if (SeatNumberTextBox.Text == "2")
                    {
                        IsBooked(seat2);
                    }
                    else if (SeatNumberTextBox.Text == "3")
                    {
                        IsBooked(seat3);
                    }
                    else if (SeatNumberTextBox.Text == "4")
                    {
                        IsBooked(seat4);
                    }
                    else if (SeatNumberTextBox.Text == "5")
                    {
                        IsBooked(seat5);
                    }
                    else if (SeatNumberTextBox.Text == "6")
                    {
                        IsBooked(seat6);
                    }
                    else if (SeatNumberTextBox.Text == "7")
                    {
                        IsBooked(seat7);
                    }
                    else if (SeatNumberTextBox.Text == "8")
                    {
                        IsBooked(seat8);
                    }
                    else if (SeatNumberTextBox.Text == "9")
                    {
                        IsBooked(seat9);
                    }
                    else if (SeatNumberTextBox.Text == "10")
                    {
                        IsBooked(seat10);
                    }
            }
            else
            {
                MessageBox.Show("No Seats Selected", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            }


        private void ResetButton_Click(object sender, EventArgs e)
        {
            Array.Clear(bookedseats, 0, 10);
            counter = 0;
            this.Controls.Clear();
            this.InitializeComponent();
            CinemaCUC_Load(this, null);
        }

        private void CinemaCUC_Load(object sender, EventArgs e)
        {
            GetBookedSeats();
            BookedSeats();
            TransactionPanel.Enabled = false;
        }

        private void CheckOutButton_Click(object sender, EventArgs e)
        {
            try
            {

                if (bookedseats[0] != 0)
                {
                    GetSeatID();
                    TransactionPanel.Visible = true;
                    TransactionPanel.Enabled = true;
                    MainPanel.Enabled = false;
                    TransactionPanel_Enter(this, null);
                }
                else
                {
                    MessageBox.Show("No Seats Booked.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        String[] alreadybookedseatids = new String[10];
        String[] alreadybookedseatnum = new String[10];
        private string paymthdid;
        public void GetBookedSeats()
        {
            try
            {
                int countrow = 0;
                sqlquery = "select seat_id from cinema.Ticket where screening_id =" + BookTicketsUC.instance.screeningid + " and tick_showdate = '" + BookTicketsUC.instance.showdate + "'";

                SqlDataReader dr = f.GetDataReader(sqlquery);
                while (dr.Read())
                {
                    for (int i = 0; i < dr.FieldCount; i++)
                    {
                        alreadybookedseatids[countrow++] = dr.GetInt32(i).ToString();
                    }
                }
                dr.Close();

                for (int i = 0; i < alreadybookedseatids.Length; i++)
                {
                    if (alreadybookedseatids[i] != null)
                    {
                        sqlquery = "select seat_number from cinema.Seat where seat_id = " + alreadybookedseatids[i] + "";
                        DataSet ds = f.GetData(sqlquery);
                        alreadybookedseatnum[i] = ds.Tables[0].Rows[0][0].ToString();
                    }
                    else
                    {
                        return;
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public void DisableSeat(Button button)
        {
            button.Enabled = false;
            button.BackColor = Color.Red;
        }
        public void BookedSeats()
        {
            for (int i = 0; i < alreadybookedseatnum.Length; i++)
            {
                if (alreadybookedseatnum[i] != null)
                {
                    switch (alreadybookedseatnum[i])
                    {
                        case "1":
                            DisableSeat(seat1);
                            break;

                        case "2":
                            DisableSeat(seat2);
                            break;
                        case "3":
                            DisableSeat(seat3);
                            break;
                        case "4":
                            DisableSeat(seat4);
                            break;
                        case "5":
                            DisableSeat(seat5);
                            break;
                        case "6":
                            DisableSeat(seat6);
                            break;
                        case "7":
                            DisableSeat(seat7);
                            break;
                        case "8":
                            DisableSeat(seat8);
                            break;
                        case "9":
                            DisableSeat(seat9);
                            break;
                        case "10":
                            DisableSeat(seat10);
                            break;
                    }
                }
                else
                {
                    return;
                }
            }
        }


        private void SaveButton_Click(object sender, EventArgs e)
        {
            f.SavePDF(ReceiptTextBox);
            ResetButton_Click(this, null);
            this.Hide();
        }

        private void PaymentMethodComBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            sqlquery = "select paymthd_id from cinema.PaymentMethod where paymthd = '" + PaymentMethodComBox.Text + "'";
            DataSet ds = f.GetData(sqlquery);
            paymthdid = ds.Tables[0].Rows[0][0].ToString();
        }


        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(PaymentMethodComBox.Text))
            {
                if (MessageBox.Show("Confirm Transaction?", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    try
                    {
                        GetTotalPrice();
                        sqlquery = "insert into cinema.Transactions (tr_amount,tr_date,tr_tickquantity,cust_id,paymthd_id,screening_id) output inserted.tr_id values (" + totalprice + ",'" + DateTime.Now.Date.ToString("yyyy-MM-dd") + "'," + counter + "," + custid + "," + paymthdid + "," + BookTicketsUC.instance.screeningid + ")";
                        DataSet ds1 = f.GetData(sqlquery);
                        SaveButton.Enabled = true;
                        String tr_id = ds1.Tables[0].Rows[0][0].ToString();
                        sqlquery = "select tr_amount from cinema.Transactions where tr_id = " + tr_id + "";
                        DataSet ds2 = f.GetData(sqlquery);
                        String tr_amount = ds2.Tables[0].Rows[0][0].ToString();
                        sqlquery = "select tr_tickquantity from cinema.Transactions where tr_id = " + tr_id + "";
                        DataSet ds4 = f.GetData(sqlquery);
                        String tr_tickquantity = ds4.Tables[0].Rows[0][0].ToString();
                        for (int i = 0; i < seatids.Length; i++)
                        {
                            if (seatids[i] != null)
                            {
                                sqlquery = "insert into cinema.Ticket (seat_id,cust_id,screening_id,tick_showdate,tr_id) values (" + seatids[i] + "," + custid + "," + BookTicketsUC.instance.screeningid + ",'" + BookTicketsUC.instance.showdate + "'," + tr_id + ")";
                                f.SetData(sqlquery);
                            }
                            else
                            {
                                break;
                            }
                        }
                        ReceiptTextBox.Clear();
                        ReceiptTextBox.Text += "---------------------NPLEX CINEMAS--------------------\n";
                        ReceiptTextBox.Text += "                    Invoice:\n";
                        ReceiptTextBox.Text += "Customer ID: " + custid + "\n";
                        ReceiptTextBox.Text += "Customer Name: " + custname + "\n";
                        ReceiptTextBox.Text += "Movie: " + BookTicketsUC.instance.moviename + "\n";
                        ReceiptTextBox.Text += "Cinema Hall: " + cinemaname + "\n";
                        ReceiptTextBox.Text += "Ticket Quantity: " + tr_tickquantity + "\n";
                        f.SetSeatNumAndRow(ReceiptTextBox, tr_id,tr_tickquantity);
                        ReceiptTextBox.Text += "Show Date: " + BookTicketsUC.instance.showdate + "\n";
                        ReceiptTextBox.Text += "Show Time: " + BookTicketsUC.instance.showtime + "\n";
                        ReceiptTextBox.Text += "Transaction ID: " + tr_id + "\n";
                        ReceiptTextBox.Text += "Transaction Amount: " + tr_amount + "\n";
                        ReceiptTextBox.Text += "Payment Method: " + PaymentMethodComBox.Text + "\n";
                        ReceiptTextBox.Text += "Transaction Date: " + DateTime.Now.Date.ToString("yyyy-MM-dd") + "\n";
                        ReceiptTextBox.Text += "---------------------Thank you--------------------";
                        SaveButton.Visible = true;
                        ConfirmButton.Visible = false;
                        CancelButton.Visible = false;
                        PaymentMethodComBox.Visible = false;
                        label8.Visible = false;
                        f.AutoFileSave(custname, tr_id,ReceiptTextBox);
                    }



                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }


            }
            else
            {
                MessageBox.Show("No Payment Method Selected.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        String custid;
        String custname;
        String cinemaname;
        private void TransactionPanel_Enter(object sender, EventArgs e)
        {
            try
            {
                PaymentMethodComBox.Items.Clear();
                sqlquery = "select paymthd from cinema.PaymentMethod";
                setComBox(sqlquery, PaymentMethodComBox);
                sqlquery = "select cust_id from cinema.Customer where cust_signedin = 'YES'";
                DataSet ds1 = f.GetData(sqlquery);
                custid = ds1.Tables[0].Rows[0][0].ToString();
                sqlquery = "select cust_firstname+' '+cust_lastname from cinema.Customer where cust_signedin = 'YES'";
                DataSet ds2 = f.GetData(sqlquery);
                custname = ds2.Tables[0].Rows[0][0].ToString();
                sqlquery = "select cinema_name from cinema.CinemaHall where cinema_id = 3";
                DataSet ds3 = f.GetData(sqlquery);
                cinemaname = ds3.Tables[0].Rows[0][0].ToString();

                ReceiptTextBox.Text = "Movie: " + BookTicketsUC.instance.moviename + "\n";
                ReceiptTextBox.Text += "Cinema Hall: " + cinemaname + "\n";
                ReceiptTextBox.Text += "Ticket Quantity: " + counter + "\n";
                ReceiptTextBox.Text += "Show Date: " + BookTicketsUC.instance.showdate + "\n";
                ReceiptTextBox.Text += "Transaction Amount: " + (800 * counter) + "\n";
            }
            catch (Exception ex)
            {

            }
        }

        public void GetTotalPrice()
        {
            for (int i = 0; i < seatids.Length; i++)
            {
                if (seatids[i] != null)
                {
                    totalprice += 800;
                }
                else
                {
                    break;
                }
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            MainPanel.Enabled = true;
            TransactionPanel.Enabled = false;
            TransactionPanel.Visible = false;
            ResetButton_Click(this, null);
        }
    }

}

