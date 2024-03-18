using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oracleTest
{
    public partial class UCMovieStatis : UserControl
    {
        DataTable table;
        MovieGateWay movieGW = new MovieGateWay();
        public UCMovieStatis()
        {
            InitializeComponent();
        }

        private void BfindStat_Click(object sender, EventArgs e)
        {
            DateTime startDate = startDatePicker.Value.Date;
            DateTime endDate = endDatePicker.Value.Date;
            if (endDate > startDate)
            {
                if (RBMostSelling.Checked)
                { table = movieGW.MovieMostSold(startDate, endDate);
                    dataGridView1.DataSource = table;
                }
                else if (RBMostShown.Checked)
                { table = movieGW.MostShownMovie(startDate, endDate);
                    dataGridView1.DataSource = table;
                }
                else
                { MessageBox.Show("Please check one of the choices"); }
                

            }
            else
                MessageBox.Show("start date must be earlier than end date :)");
        }
    }
}
