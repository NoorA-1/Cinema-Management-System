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
    public partial class MoviesUC : UserControl
    {
        FunctionClass f = new FunctionClass();
        String imglocation;
        String editimglocation;
        String sqlquery;
        public MoviesUC()
        {
            InitializeComponent();
        }

        private void BrowseImageButton_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files (*.jpg) |*.jpg|PNG Files (*.png) |*.png";
                dlg.Title = "Select Movie Poster";
                if(dlg.ShowDialog() == DialogResult.OK)
                {
                    imglocation = dlg.FileName.ToString();
                    MoviePosterBox.ImageLocation = imglocation;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        String empid;
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(MovieNameTextBox.Text) && !String.IsNullOrWhiteSpace(MovieLengthTextBox.Text) && !String.IsNullOrWhiteSpace(MovieGenreComBox.Text) && MoviePosterBox.Image != null)
            {
                try
                {
                    sqlquery = "select emp_id from cinema.Employee where emp_signedin = 'YES'";
                    DataSet ds = f.GetData(sqlquery);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        empid = ds.Tables[0].Rows[0][0].ToString();
                        byte[] img = null;
                        FileStream fs = new FileStream(imglocation, FileMode.Open, FileAccess.Read);
                        BinaryReader brr = new BinaryReader(fs);
                        img = brr.ReadBytes((int)fs.Length);
                        sqlquery = "insert into cinema.movie(movie_name,movie_minutes,movie_genre,movie_releasedate,movie_poster,emp_id) values ('" + MovieNameTextBox.Text + "'," + MovieLengthTextBox.Text + ",'" + MovieGenreComBox.Text + "','" + MovieReleaseDate.Text + "',@img," + empid + ")";
                        f.SetMovieData(sqlquery, img, "Movie Added.");
                        ClearAllFields();
                    }
                    else
                    {
                        byte[] img = null;
                        FileStream fs = new FileStream(imglocation, FileMode.Open, FileAccess.Read);
                        BinaryReader brr = new BinaryReader(fs);
                        img = brr.ReadBytes((int)fs.Length);
                        sqlquery = "insert into cinema.movie(movie_name,movie_minutes,movie_genre,movie_releasedate,movie_poster) values ('" + MovieNameTextBox.Text + "'," + MovieLengthTextBox.Text + ",'" + MovieGenreComBox.Text + "','" + MovieReleaseDate.Text + "',@img)";
                        f.SetMovieData(sqlquery, img, "Movie Added.");
                        ClearAllFields();
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627)
                    {
                        MessageBox.Show("Movie Already Added (Movie name should be different)", "Duplication", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Insert All Data.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void ClearAllFields() 
        {
            MovieNameTextBox.Clear();
            MovieLengthTextBox.Clear();
            MovieGenreComBox.SelectedIndex = -1;
            MoviePosterBox.Image = null;
            EditMovieIDTextBox.Clear();
            EditMovieNameTextBox.Clear();
            EditMovieLengthTextBox.Clear();
            EditMovieGenreComBox.SelectedIndex = -1;
            EditMoviePosterBox.Image = null;
            DelMovieIDTextBox.Clear();
            DelMovieNameTextBox.Clear();
            DelMoviePosterBox.Image = null; 
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                ClearAllFields();
                sqlquery = "select movie_id as MovieID, movie_name as MovieName,movie_minutes as Length,movie_genre as Genre,movie_releasedate as ReleaseDate, movie_poster as Poster from cinema.movie";
                DataSet d = f.GetData(sqlquery);
                EditMovieDetailsGridView.DataSource = d.Tables[0];
                for (int i = 0; i < EditMovieDetailsGridView.Columns.Count; i++)
                    if (EditMovieDetailsGridView.Columns[i] is DataGridViewImageColumn)
                    {
                        ((DataGridViewImageColumn)EditMovieDetailsGridView.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                        break;
                    }       
            }

            if (tabControl1.SelectedIndex == 2)
            {
                ClearAllFields();
                sqlquery = "select movie_id as MovieID, movie_name as MovieName,movie_minutes as Length,movie_genre as Genre,movie_releasedate as ReleaseDate, movie_poster as Poster from cinema.movie";
                DataSet d = f.GetData(sqlquery);
                DelMovieDetailsGridView.DataSource = d.Tables[0];
                for (int i = 0; i < DelMovieDetailsGridView.Columns.Count; i++)
                    if (DelMovieDetailsGridView.Columns[i] is DataGridViewImageColumn)
                    {
                        ((DataGridViewImageColumn)DelMovieDetailsGridView.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                        break;
                    }
            }
        }

        private void EditMovieDetailsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && EditMovieDetailsGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    EditMovieDetailsGridView.CurrentRow.Selected = true;
                    DataGridViewRow selrow = this.EditMovieDetailsGridView.Rows[e.RowIndex];
                    EditMovieIDTextBox.Text = selrow.Cells["MovieID"].FormattedValue.ToString();
                    EditMovieNameTextBox.Text = selrow.Cells["MovieName"].FormattedValue.ToString();
                    EditMovieLengthTextBox.Text = selrow.Cells["Length"].FormattedValue.ToString();
                    EditMovieGenreComBox.Text = selrow.Cells["Genre"].FormattedValue.ToString();
                    EditMovieReleaseDate.Text = selrow.Cells["ReleaseDate"].FormattedValue.ToString();
                    sqlquery = "select movie_poster from cinema.movie where movie_id = " + EditMovieIDTextBox.Text+"";
                    DataSet ds = f.GetData(sqlquery);
                    if(ds.Tables[0].Rows.Count > 0)
                    {
                        MemoryStream m = new MemoryStream((byte[])ds.Tables[0].Rows[0]["movie_poster"]);
                        EditMoviePosterBox.Image = new Bitmap(m);
                    }
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EditMovieBrowseButton_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files (*.jpg) |*.jpg|PNG Files (*.png) |*.png";
                dlg.Title = "Select New Movie Poster";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    editimglocation = dlg.FileName.ToString();
                    EditMoviePosterBox.ImageLocation = editimglocation;
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    MessageBox.Show("Movie Already Added (Movie name should be different)", "Duplication", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void EditMovieButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(EditMovieIDTextBox.Text) && !String.IsNullOrWhiteSpace(EditMovieNameTextBox.Text) && !String.IsNullOrWhiteSpace(EditMovieLengthTextBox.Text) && !String.IsNullOrWhiteSpace(EditMovieGenreComBox.Text) && EditMoviePosterBox.Image != null)
            {
                try
                {
                    if (editimglocation != null)
                    {
                        byte[] img = null;
                        FileStream fs = new FileStream(editimglocation, FileMode.Open, FileAccess.Read);
                        BinaryReader brr = new BinaryReader(fs);
                        img = brr.ReadBytes((int)fs.Length);
                        sqlquery = "update cinema.movie set movie_name ='" + EditMovieNameTextBox.Text + "', movie_minutes = " + EditMovieLengthTextBox.Text + ",movie_genre = '" + EditMovieGenreComBox.Text + "',movie_releasedate = '" + EditMovieReleaseDate.Text + "',movie_poster = @img where movie_id =" + EditMovieIDTextBox.Text + "";
                        f.SetMovieData(sqlquery, img, "Movie Details Updated.");
                        tabControl1_SelectedIndexChanged(this, null);
                        ClearAllFields();
                    }
                    else
                    {
                        sqlquery = "update cinema.movie set movie_name ='" + EditMovieNameTextBox.Text + "', movie_minutes = " + EditMovieLengthTextBox.Text + ",movie_genre = '" + EditMovieGenreComBox.Text + "',movie_releasedate = '" + EditMovieReleaseDate.Text + "' where movie_id =" + EditMovieIDTextBox.Text + "";
                        f.SetData(sqlquery, "Movie Details Updated.");
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
                MessageBox.Show("Insert All Data.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MovieLengthTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void EditMovieLengthTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void SearchMovieTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                String sqlquery = "select movie_id as MovieID, movie_name as MovieName,movie_minutes as Length,movie_genre as Genre,movie_releasedate as ReleaseDate, movie_poster as Poster from cinema.movie where movie_name like '" + SearchEditMovieTextBox.Text+"%'";
                DataSet ds = f.GetData(sqlquery);
                EditMovieDetailsGridView.DataSource = ds.Tables[0];
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SearchDelMovieTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                String sqlquery = "select movie_id as MovieID, movie_name as MovieName,movie_minutes as Length,movie_genre as Genre,movie_releasedate as ReleaseDate, movie_poster as Poster from cinema.movie where movie_name like '" + SearchDelMovieTextBox.Text + "%'";
                DataSet ds = f.GetData(sqlquery);
                DelMovieDetailsGridView.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DelMovieDetailsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && DelMovieDetailsGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    DelMovieDetailsGridView.CurrentRow.Selected = true;
                    DataGridViewRow selrow = this.DelMovieDetailsGridView.Rows[e.RowIndex];
                    DelMovieIDTextBox.Text = selrow.Cells["MovieID"].FormattedValue.ToString();
                    DelMovieNameTextBox.Text = selrow.Cells["MovieName"].FormattedValue.ToString();            
                    sqlquery = "select movie_poster from cinema.movie where movie_id = " + DelMovieIDTextBox.Text + "";
                    DataSet ds = f.GetData(sqlquery);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        MemoryStream m = new MemoryStream((byte[])ds.Tables[0].Rows[0]["movie_poster"]);
                        DelMoviePosterBox.Image = new Bitmap(m);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DelMovieButton_Click(object sender, EventArgs e)
        {
            if (DelMovieIDTextBox.Text != "" && DelMovieNameTextBox.Text != "")
            {
                try
                {
                    sqlquery = "select * from cinema.Screening where movie_id =" + DelMovieIDTextBox.Text + "";
                    DataSet ds = f.GetData(sqlquery);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        MessageBox.Show("Cannot delete this movie, It has already been assigned a showtime before.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (MessageBox.Show("Delete Movie?", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            sqlquery = "delete from cinema.movie where movie_id =" + DelMovieIDTextBox.Text + "";
                            f.SetData(sqlquery, "Movie Deleted.");
                            tabControl1_SelectedIndexChanged(this, null); //reload form
                            DelMovieIDTextBox.Clear();
                            DelMovieNameTextBox.Clear();
                        }
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

        private void MoviesUC_Leave(object sender, EventArgs e)
        {
            ClearAllFields();
        }

        private void MoviesUC_Enter(object sender, EventArgs e)
        {
            tabControl1_SelectedIndexChanged(this, null);
        }
    }
}
