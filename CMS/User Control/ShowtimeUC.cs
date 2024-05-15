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
    public partial class ShowtimeUC : UserControl
    {
        FunctionClass f = new FunctionClass();
        String sqlquery;
        public ShowtimeUC()
        {
            InitializeComponent();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                ClearAllFields();
                sqlquery = "select screening_id as ScreeningID, A.movie_id as MovieID,movie_name as MovieName,movie_poster as MoviePoster,cinema_name as CinemaName,screening_showtime as ShowTime,screening_startdate as StartDate,screening_enddate as EndDate from cinema.screening as A inner join cinema.movie as B on A.movie_id = B.movie_id inner join cinema.cinemahall as C on A.cinema_id = C.cinema_id where screening_isactive = 'YES'";
                DataSet ds = f.GetData(sqlquery);
                EditSTGridView.DataSource = ds.Tables[0];
                for (int i = 0; i < EditSTGridView.Columns.Count; i++)
                    if (EditSTGridView.Columns[i] is DataGridViewImageColumn)
                    {
                        ((DataGridViewImageColumn)EditSTGridView.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                        break;
                    }

                sqlquery = "select movie_id as MovieID,movie_name as MovieName from cinema.movie";
                DataSet d = f.GetData(sqlquery);
                EditSTMovieGridView.DataSource = d.Tables[0];
            }
           if(tabControl1.SelectedIndex == 2)
            {
                ClearAllFields();
                sqlquery = "select screening_id as ScreeningID, A.movie_id as MovieID,movie_name as MovieName,movie_poster as MoviePoster,cinema_name as CinemaName,screening_showtime as ShowTime,screening_startdate as StartDate,screening_enddate as EndDate from cinema.screening as A inner join cinema.movie as B on A.movie_id = B.movie_id inner join cinema.cinemahall as C on A.cinema_id = C.cinema_id where screening_isactive = 'YES'";
                DataSet ds = f.GetData(sqlquery);
                DelSTGridView.DataSource = ds.Tables[0];
                for (int i = 0; i < DelSTGridView.Columns.Count; i++)
                    if (DelSTGridView.Columns[i] is DataGridViewImageColumn)
                    {
                        ((DataGridViewImageColumn)DelSTGridView.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                        break;
                    }
            }
        }
        int cinemaid;

        private void AddShowtimeCinemaComBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                movieid = null;
                moviename = null;
                MoviePosterBox.Image = null;
                sqlquery = "select cinema_id from cinema.cinemahall where cinema_name = '" + AddShowtimeCinemaComBox.Text + "'";
                DataSet ds = f.GetData(sqlquery);
                cinemaid = int.Parse(ds.Tables[0].Rows[0][0].ToString());
                MovieListRefresh(cinemaid);
            }
            catch (Exception ex)
            {
                
            }

        }

        public void MovieListRefresh(int cinemaid)
        {
            try
            {
                sqlquery = "select movie_id from cinema.screening where screening_showtime = '" + AddShowtimeComBox.Text + "' and ((screening_startdate >= '" + AddShowStartDate.Text + "' and screening_startdate <= '" + AddShowEndDate.Text + "') or (screening_enddate >= '" + AddShowStartDate.Text + "' and screening_enddate <= '" + AddShowEndDate.Text + "')) and cinema_id = " + cinemaid + " and screening_isactive = 'YES'";
                DataSet d = f.GetData(sqlquery);
                if(d.Tables[0].Rows.Count != 0)
                {
                    AddSTMovieGridView.DataSource = null;
                    AlreadyBkdLabel.Visible = true;
                }
                else
                {
                    sqlquery = "select movie_id as MovieID,movie_name as MovieName from cinema.movie";
                    DataSet ds = f.GetData(sqlquery);
                    AddSTMovieGridView.DataSource = ds.Tables[0];
                    AlreadyBkdLabel.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ShowtimeUC_Load(object sender, EventArgs e)
        {
            AddShowEndDate.MinDate = AddShowStartDate.Value;
            try
            {
                sqlquery = "select movie_id as MovieID,movie_name as MovieName from cinema.movie order by movie_name";
                DataSet d = f.GetData(sqlquery);
                AddSTMovieGridView.DataSource = d.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        String movieid;
        String moviename;
        DateTime releasedate;
        private void AddSTMovieGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && AddSTMovieGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    AddSTMovieGridView.CurrentRow.Selected = true;
                    DataGridViewRow selrow = this.AddSTMovieGridView.Rows[e.RowIndex];
                    movieid = selrow.Cells["MovieID"].FormattedValue.ToString();
                    moviename = selrow.Cells["MovieName"].FormattedValue.ToString();
                    sqlquery = "select movie_poster from cinema.movie where movie_id = " + movieid + "";
                    DataSet ds = f.GetData(sqlquery);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        MemoryStream m = new MemoryStream((byte[])ds.Tables[0].Rows[0]["movie_poster"]);
                        MoviePosterBox.Image = new Bitmap(m);
                    }
                    sqlquery = "select movie_releasedate from cinema.movie where movie_id = " + movieid+"";
                    DataSet d = f.GetData(sqlquery);
                    releasedate = DateTime.Parse(d.Tables[0].Rows[0][0].ToString());
                    AddShowStartDate.MinDate = releasedate.Date;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        String empid;
        private void AddShowtimeButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(AddShowtimeComBox.Text) && !String.IsNullOrWhiteSpace(AddShowtimeCinemaComBox.Text))
            {
                if (movieid != null && moviename != null)
                {
                    
                    try
                    {
                        sqlquery = "select emp_id from cinema.Employee where emp_signedin = 'YES'";
                        DataSet ds = f.GetData(sqlquery);
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            empid = ds.Tables[0].Rows[0][0].ToString();
                            sqlquery = "insert into cinema.screening (screening_showtime,screening_startdate,screening_enddate,screening.movie_id,screening.cinema_id,emp_id) values ('" + AddShowtimeComBox.Text + "','" + AddShowStartDate.Text + "','" + AddShowEndDate.Text + "'," + movieid + "," + cinemaid + "," + empid + ")";
                            f.SetData(sqlquery, "Show Timing Added.");
                            ClearAllFields();
                        }
                        else
                        {
                            sqlquery = "insert into cinema.screening (screening_showtime,screening_startdate,screening_enddate,screening.movie_id,screening.cinema_id) values ('" + AddShowtimeComBox.Text + "','" + AddShowStartDate.Text + "','" + AddShowEndDate.Text + "'," + movieid + "," + cinemaid + ")";
                            f.SetData(sqlquery, "Show Timing Added.");
                            ClearAllFields();
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            else
            {
                MessageBox.Show("No Movie is Selected.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
            else
            {
                MessageBox.Show("Insert All Data.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void ClearAllFields()
        {
            AddShowtimeComBox.SelectedIndex = -1;
            AddShowtimeCinemaComBox.SelectedIndex = -1;
            AddShowStartDate.MinDate = DateTime.Today;
            AddShowEndDate.MinDate = DateTime.Today;
            MoviePosterBox.Image = null;
            AlreadyBkdLabel.Visible = false;
            EditSTIDTextBox.Clear();
            EditShowtimeComBox.SelectedIndex = -1;
            EditShowtimeCinemaComBox.SelectedIndex = -1;
            //EditShowtimeStartDate.MinDate = DateTime.Today;
            //EditShowtimeEndDate.MinDate = DateTime.Today;
            EditMoviePosterBox.Image = null;
            EditSTMovieNameLabel.Visible = false;
            DelShowIDTextBox.Clear();
            DelShowtimeTextBox.Clear();
            DelSTCinemaHallTextBox.Clear();
            DelSTMovieLabel.Visible = false;
            DelSTMoviePoster.Image = null; 
        }

        private void AddShowtimeComBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //AddShowtimeCinemaComBox.SelectedIndex = -1;
            MovieListRefresh(cinemaid);
        }

        private void AddShowStartDate_ValueChanged(object sender, EventArgs e)
        {
            MovieListRefresh(cinemaid);
            AddShowEndDate.MinDate = AddShowStartDate.Value;
        }

        private void AddShowEndDate_ValueChanged(object sender, EventArgs e)
        {
            MovieListRefresh(cinemaid);
        }
        //String screeningid;
        private void EditSTGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && EditSTGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    EditSTGridView.CurrentRow.Selected = true;
                    DataGridViewRow selrow = this.EditSTGridView.Rows[e.RowIndex];
                    EditSTIDTextBox.Text = selrow.Cells["ScreeningID"].FormattedValue.ToString();
                    movieid = selrow.Cells["MovieID"].FormattedValue.ToString();
                    moviename = selrow.Cells["MovieName"].FormattedValue.ToString();
                    EditShowtimeComBox.Text = selrow.Cells["ShowTime"].FormattedValue.ToString();
                    EditShowtimeStartDate.Text = selrow.Cells["StartDate"].FormattedValue.ToString();
                    EditShowtimeEndDate.Text = selrow.Cells["EndDate"].FormattedValue.ToString();
                    EditShowtimeCinemaComBox.Text = selrow.Cells["CinemaName"].FormattedValue.ToString();
                    EditSTMovieNameLabel.Text = moviename;
                   EditSTMovieNameLabel.Visible = true;
                    sqlquery = "select movie_poster from cinema.movie where movie_id = " + movieid + "";
                    DataSet ds = f.GetData(sqlquery);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        MemoryStream m = new MemoryStream((byte[])ds.Tables[0].Rows[0]["movie_poster"]);
                        EditMoviePosterBox.Image = new Bitmap(m);
                    }
                    sqlquery = "select cinema_id from cinema.cinemahall where cinema_name = '" + EditShowtimeCinemaComBox.Text + "'";
                    DataSet d = f.GetData(sqlquery);
                    cinemaid = int.Parse(d.Tables[0].Rows[0][0].ToString());
                }
            }
            catch (Exception ex)
            {
                
            }
        }

        private void EditShowTimeButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(EditSTIDTextBox.Text) && !String.IsNullOrWhiteSpace(EditShowtimeComBox.Text) && !String.IsNullOrWhiteSpace (EditShowtimeCinemaComBox.Text))
            {
                if (movieid != null && moviename != null)
                {
                    try
                    {
                        
                        sqlquery = "select * from cinema.Screening where not screening_id =" + EditSTIDTextBox.Text + " and screening_showtime = '"+EditShowtimeComBox.Text+ "' and ((screening_startdate >= '" + EditShowtimeStartDate.Text + "' and screening_startdate <= '" + EditShowtimeEndDate.Text + "') or (screening_enddate >= '" + EditShowtimeStartDate.Text + "' and screening_enddate <= '" + EditShowtimeEndDate.Text + "')) and cinema_id ="+cinemaid+ " and screening_isactive = 'YES'";
                        DataSet ds = f.GetData(sqlquery);
                        if(ds.Tables[0].Rows.Count > 0)
                        {
                            MessageBox.Show("Showtime already booked in this time frame.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            sqlquery = "update cinema.Screening set screening_showtime = '" + EditShowtimeComBox.Text + "', screening_startdate = '"+EditShowtimeStartDate.Text+"', screening_enddate = '"+EditShowtimeEndDate.Text+"', cinema_id = "+ cinemaid + ", movie_id = "+movieid+" where screening_id = "+ EditSTIDTextBox.Text + " and screening_isactive = 'YES'";
                            f.SetData(sqlquery, "Showtime Edited.");
                            tabControl1_SelectedIndexChanged(this, null);
                            ClearAllFields();
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("No Movie is Selected.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Insert All Data.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void EditShowtimeCinemaComBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                sqlquery = "select cinema_id from cinema.cinemahall where cinema_name = '" + EditShowtimeCinemaComBox.Text + "'";
                DataSet ds = f.GetData(sqlquery);
                cinemaid = int.Parse(ds.Tables[0].Rows[0][0].ToString());
            }
            catch (Exception ex)
            {

            }
        }

        private void EditSTMovieGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && EditSTMovieGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    EditSTMovieGridView.CurrentRow.Selected = true;
                    DataGridViewRow selrow = this.EditSTMovieGridView.Rows[e.RowIndex];
                    movieid = selrow.Cells["MovieID"].FormattedValue.ToString();
                    moviename = selrow.Cells["MovieName"].FormattedValue.ToString();
                    EditSTMovieNameLabel.Text = moviename;
                    EditSTMovieNameLabel.Visible = true;
                    sqlquery = "select movie_poster from cinema.movie where movie_id = " + movieid + "";
                    DataSet ds = f.GetData(sqlquery);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        MemoryStream m = new MemoryStream((byte[])ds.Tables[0].Rows[0]["movie_poster"]);
                        EditMoviePosterBox.Image = new Bitmap(m);
                    }
                    sqlquery = "select movie_releasedate from cinema.movie where movie_id = " + movieid + "";
                    DataSet d = f.GetData(sqlquery);
                    releasedate = DateTime.Parse(d.Tables[0].Rows[0][0].ToString());
                    EditShowtimeStartDate.MinDate = releasedate.Date;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EditShowtimeStartDate_ValueChanged(object sender, EventArgs e)
        {
            EditShowtimeEndDate.MinDate = EditShowtimeStartDate.Value;
        }

        private void ShowtimeUC_Leave(object sender, EventArgs e)
        {
            ClearAllFields();
            tabControl1_SelectedIndexChanged(0, null);
        }

        private void ShowtimeUC_Enter(object sender, EventArgs e)
        {
            tabControl1_SelectedIndexChanged(this, null);
        }

        private void EditShowtimeComBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void DelSTGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && DelSTGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    DelSTGridView.CurrentRow.Selected = true;
                    DataGridViewRow selrow = this.DelSTGridView.Rows[e.RowIndex];
                    DelShowIDTextBox.Text = selrow.Cells["ScreeningID"].FormattedValue.ToString();
                    movieid = selrow.Cells["MovieID"].FormattedValue.ToString();
                    moviename = selrow.Cells["MovieName"].FormattedValue.ToString();
                    DelShowtimeTextBox.Text = selrow.Cells["ShowTime"].FormattedValue.ToString();
                    DelSTCinemaHallTextBox.Text = selrow.Cells["CinemaName"].FormattedValue.ToString();
                    DelSTMovieLabel.Text = moviename;
                    DelSTMovieLabel.Visible = true;
                    sqlquery = "select movie_poster from cinema.movie where movie_id = " + movieid + "";
                    DataSet ds = f.GetData(sqlquery);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        MemoryStream m = new MemoryStream((byte[])ds.Tables[0].Rows[0]["movie_poster"]);
                        DelSTMoviePoster.Image = new Bitmap(m);
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void DelSTButton_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrWhiteSpace(DelShowIDTextBox.Text) && !String.IsNullOrWhiteSpace(DelShowtimeTextBox.Text) && !String.IsNullOrWhiteSpace(DelSTCinemaHallTextBox.Text) && DelSTMoviePoster.Image != null)
            {
                if (MessageBox.Show("Delete Show?", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    try
                    {
                        sqlquery = "update cinema.Screening set screening_isactive = 'NO' where screening_id = " + DelShowIDTextBox.Text + "";
                        f.SetData(sqlquery, "Show Deleted.");
                        ClearAllFields();
                        tabControl1_SelectedIndexChanged(this, null);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else 
            {
                MessageBox.Show("No Show Selected.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SearchEditSTMovieBox_TextChanged(object sender, EventArgs e)
        {
            sqlquery = "select screening_id as ScreeningID, A.movie_id as MovieID,movie_name as MovieName,movie_poster as MoviePoster,cinema_name as CinemaName,screening_showtime as ShowTime,screening_startdate as StartDate,screening_enddate as EndDate from cinema.screening as A inner join cinema.movie as B on A.movie_id = B.movie_id inner join cinema.cinemahall as C on A.cinema_id = C.cinema_id where movie_name like '" + SearchEditSTMovieBox.Text+ "%' and screening_isactive = 'YES'";
            DataSet ds = f.GetData(sqlquery);
            EditSTGridView.DataSource = ds.Tables[0];
            for (int i = 0; i < EditSTGridView.Columns.Count; i++)
                if (EditSTGridView.Columns[i] is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)EditSTGridView.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                    break;
                }
        }

        private void SearchDelSTMovieBox_TextChanged(object sender, EventArgs e)
        {
            sqlquery = "select screening_id as ScreeningID, A.movie_id as MovieID,movie_name as MovieName,movie_poster as MoviePoster,cinema_name as CinemaName,screening_showtime as ShowTime,screening_startdate as StartDate,screening_enddate as EndDate from cinema.screening as A inner join cinema.movie as B on A.movie_id = B.movie_id inner join cinema.cinemahall as C on A.cinema_id = C.cinema_id where movie_name like '" + SearchDelSTMovieBox.Text + "%' and screening_isactive = 'YES'";
            DataSet ds = f.GetData(sqlquery);
            DelSTGridView.DataSource = ds.Tables[0];
            for (int i = 0; i < DelSTGridView.Columns.Count; i++)
                if (DelSTGridView.Columns[i] is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)DelSTGridView.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                    break;
                }
        }
    } 
    }
