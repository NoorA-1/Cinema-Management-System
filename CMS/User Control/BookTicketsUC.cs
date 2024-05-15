using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.User_Control
{
    public partial class BookTicketsUC : UserControl
    {
        public static BookTicketsUC instance;
        public BookTicketsUC()
        {
            InitializeComponent();
            instance = this;
            screeningid = ScreeningIDTextBox.Text;
            cinemaid = CinemaIDTextBox.Text;
            showdate = ShowDate.Text;
        }
        String sqlquery;
        public String movieid;
        public String moviename;
        public String showtime;
        public String cinemaid = "";
        public String screeningid = "";
        public String showdate = "";
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

        public void setTimeComBox(String sqlquery, ComboBox comboBox)
        {
            try
            {
                SqlDataReader dr = f.GetDataReader(this.sqlquery);
                while (dr.Read())
                {
                    for (int i = 0; i < dr.FieldCount; i++)
                    {

                        comboBox.Items.Add(dr.GetTimeSpan(i).ToString());
                    }
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        public void GenerateShowDates(String sqlquery)
        {
            DataSet ds = f.GetData(sqlquery);
            DateTime enddate = DateTime.Parse(ds.Tables[0].Rows[0][0].ToString());
            ShowDate.MinDate = DateTime.Parse(DateTime.Now.Date.ToString("yyyy-MM-dd"));
            ShowDate.MaxDate = enddate;
        }

        private void MoviesComBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ShowtimeComBox.Items.Clear();
                CinemaComBox.Items.Clear();
                sqlquery = "select distinct(screening_showtime) from cinema.Screening as A inner join cinema.Movie as B on A.movie_id = B.movie_id where B.movie_name = '" + MoviesComBox.Text + "' and screening_startdate <= '" + DateTime.Now.ToString("yyyy-MM-dd") + "' and screening_enddate >= '" + DateTime.Now.ToString("yyyy-MM-dd") + "' and screening_isactive = 'YES'";
                setTimeComBox(sqlquery, ShowtimeComBox);
                moviename = MoviesComBox.Text;
                sqlquery = "select movie_id from cinema.Movie where movie_name = '" + moviename + "'";
                DataSet ds = f.GetData(sqlquery);
                movieid = ds.Tables[0].Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    

        private void ShowtimeComBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CinemaComBox.Items.Clear();
                sqlquery = "select cinema_name from cinema.CinemaHall as A inner join cinema.Screening as B on A.cinema_id = B.cinema_id where screening_showtime = '" + ShowtimeComBox.Text + "' and movie_id = " + movieid + " and screening_startdate <= '" + DateTime.Now.ToString("yyyy-MM-dd") + "' and screening_enddate >= '" + DateTime.Now.ToString("yyyy-MM-dd") + "' and screening_isactive = 'YES'";
                setComBox(sqlquery, CinemaComBox);
                showtime = ShowtimeComBox.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CinemaComBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
            sqlquery = "select cinema_id from cinema.CinemaHall where cinema_name = '" + CinemaComBox.Text+"'";
            DataSet ds = f.GetData(sqlquery);
            cinemaid = ds.Tables[0].Rows[0][0].ToString();
            CinemaIDTextBox.Text = cinemaid;
            sqlquery = "select screening_id from cinema.Screening where screening_showtime  = '" + showtime+"' and movie_id = "+movieid+" and cinema_id = "+cinemaid+ " and screening_isactive = 'YES'";
            DataSet d = f.GetData(sqlquery);
            screeningid = d.Tables[0].Rows[0][0].ToString();
            ScreeningIDTextBox.Text = screeningid;
            sqlquery = "select screening_enddate from cinema.Screening where screening_id =" + screeningid + " and screening_isactive = 'YES'";
            GenerateShowDates(sqlquery);
            ShowDate.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            BookTicketsUC_Enter(this,null);
        }

        private void ShowDate_ValueChanged(object sender, EventArgs e)
        {
            showdate = ShowDate.Text;
        }

        public void DisableComponents()
        {
            MoviesComBox.Enabled = false;
            ShowtimeComBox.Enabled = false;
            CinemaComBox.Enabled = false;
            ChangeButton.Visible = true;
            ChangeButton.BringToFront();
            ShowDate.Enabled = false;
        }
        private void ShowDate_CloseUp(object sender, EventArgs e)
        {
            if (CinemaComBox.Text == "A")
            {
                sqlquery = "select count(tick_id) from cinema.Ticket where screening_id =" + screeningid + " and tick_showdate = '" + ShowDate.Text + "'";
                DataSet ds1 = f.GetData(sqlquery);
                int tickcount = int.Parse(ds1.Tables[0].Rows[0][0].ToString());
                if (tickcount != 20)
                {

                        cinemaAUC1.Visible = true;
                        cinemaAUC1.BringToFront();
                        DisableComponents();


                }
                else
                {
                    MessageBox.Show("Show is Fully Booked", "Fully Booked", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            if(CinemaComBox.Text == "B")
            {
                sqlquery = "select count(tick_id) from cinema.Ticket where screening_id =" + screeningid + " and tick_showdate = '" + ShowDate.Text + "'";
                DataSet ds1 = f.GetData(sqlquery);
                int tickcount = int.Parse(ds1.Tables[0].Rows[0][0].ToString());
                if (tickcount != 15)
                {

                            cinemaBUC1.Visible = true;
                            cinemaBUC1.BringToFront();
                            DisableComponents();

                }
                else
                {
                    MessageBox.Show("Show is Fully Booked", "Fully Booked", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }

            if (CinemaComBox.Text == "C")
            {
                sqlquery = "select count(tick_id) from cinema.Ticket where screening_id =" + screeningid + " and tick_showdate = '" + ShowDate.Text + "'";
                DataSet ds1 = f.GetData(sqlquery);
                int tickcount = int.Parse(ds1.Tables[0].Rows[0][0].ToString());
                if (tickcount != 10)
                {

                        cinemaCUC1.Visible = true;
                        cinemaCUC1.BringToFront();
                        DisableComponents();

                }
                else
                {
                    MessageBox.Show("Show is Fully Booked", "Fully Booked", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void BookTicketsUC_Enter(object sender, EventArgs e)
        {
            try
            {
                MoviesComBox.Items.Clear();
                sqlquery = "select distinct(movie_name) from cinema.Screening as A inner join cinema.Movie as B on A.movie_id = B.movie_id and screening_startdate <= '" + DateTime.Now.ToString("yyyy-MM-dd") + "' and screening_enddate >= '" + DateTime.Now.ToString("yyyy-MM-dd") + "' and screening_isactive = 'YES'";
                setComBox(sqlquery, MoviesComBox);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
