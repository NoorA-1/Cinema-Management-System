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
    public partial class AllShowsUC : UserControl
    {
        public AllShowsUC()
        {
            InitializeComponent();
        }
        FunctionClass f = new FunctionClass();

        private void AllShowsUC_Load(object sender, EventArgs e)
        {
            LoadShows();
        }

        public void LoadShows() {
            try
            {
                String sqlquery = "select screening_id as ScreeningID, A.movie_id as MovieID,movie_name as MovieName,movie_poster as MoviePoster,cinema_name as CinemaName,screening_showtime as ShowTime,screening_startdate as StartDate,screening_enddate as EndDate from cinema.screening as A inner join cinema.movie as B on A.movie_id = B.movie_id inner join cinema.cinemahall as C on A.cinema_id = C.cinema_id where screening_isactive = 'YES'";
                DataSet ds = f.GetData(sqlquery);
                AllShowsGridView.DataSource = ds.Tables[0];
                for (int i = 0; i < AllShowsGridView.Columns.Count; i++)
                    if (AllShowsGridView.Columns[i] is DataGridViewImageColumn)
                    {
                        ((DataGridViewImageColumn)AllShowsGridView.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                        break;
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadShows();
            timer1.Start();
        }

    }
}
