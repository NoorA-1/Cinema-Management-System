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
    public partial class ComingSoonUC : UserControl
    {
        public ComingSoonUC()
        {
            InitializeComponent();
        }
        String sqlquery;
        FunctionClass f = new FunctionClass();
        private void ComingSoonUC_Load(object sender, EventArgs e)
        {
            try
            {
                sqlquery = "select movie_name as MovieName,movie_poster as MoviePoster,cinema_name as CinemaName,screening_showtime as ShowTime,screening_startdate as StartDate,screening_enddate as EndDate from cinema.screening as A inner join cinema.movie as B on A.movie_id = B.movie_id inner join cinema.cinemahall as C on A.cinema_id = C.cinema_id where screening_startdate > '" + DateTime.Now.Date.ToString("yyyy-MM-dd") + "' and screening_isactive = 'YES'";
                DataSet ds = f.GetData(sqlquery);
                ComingSoonDataGridView.DataSource = ds.Tables[0];
                for (int i = 0; i < ComingSoonDataGridView.Columns.Count; i++)
                    if (ComingSoonDataGridView.Columns[i] is DataGridViewImageColumn)
                    {
                        ((DataGridViewImageColumn)ComingSoonDataGridView.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                        break;
                    }
            }
            catch
            {

            }
        }

        private void ComingSoonUC_Enter(object sender, EventArgs e)
        {
            try
            {
                sqlquery = "select movie_name as MovieName,movie_poster as MoviePoster,cinema_name as CinemaName,screening_showtime as ShowTime,screening_startdate as StartDate,screening_enddate as EndDate from cinema.screening as A inner join cinema.movie as B on A.movie_id = B.movie_id inner join cinemahall as C on A.cinema_id = B.cinema_id where screening_startdate > '" + DateTime.Now.Date.ToString("yyyy-MM-dd") + "' and screening_isactive = 'YES'";
                DataSet ds = f.GetData(sqlquery);
                ComingSoonDataGridView.DataSource = ds.Tables[0];
                for (int i = 0; i < ComingSoonDataGridView.Columns.Count; i++)
                    if (ComingSoonDataGridView.Columns[i] is DataGridViewImageColumn)
                    {
                        ((DataGridViewImageColumn)ComingSoonDataGridView.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                        break;
                    }
            }
            catch
            {

            }
        }
    }
}
