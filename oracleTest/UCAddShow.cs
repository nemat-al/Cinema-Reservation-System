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
    public partial class UCAddShow : UserControl
    {
        Movie movieWithNewShow;
        public UCAddShow()
        {
            InitializeComponent();
            cBHall.Items.Add("central");
            cBHall.Items.Add("Right");
            cBHall.Items.Add("Left");
            DTMPShowDate.Format = DateTimePickerFormat.Custom;
            DTMPShowDate.CustomFormat = "MM/dd/yyyy";
            DTMPShowTime.Format = DateTimePickerFormat.Time;
            DTMPShowTime.ShowUpDown = true;
        }

        internal Movie MovieWithNewShow
        {
            get
            {
                return movieWithNewShow;
            }

            set
            {
                movieWithNewShow = value;
            }
        }
        public void printName()
        {
            LMovieNameValue.Text = MovieWithNewShow.Name;
        }

        private void BAdd_Click(object sender, EventArgs e)
        {
            DateTime ShowDate = DTMPShowDate.Value.Date;
            int ShowPoints = int.Parse(NUDShowPoints.Value.ToString());
            double showPrice = int.Parse(NUDShowPrice.Value.ToString());
            int hallId = cBHall.SelectedIndex+1;
            int movieId = MovieWithNewShow.Id;
            TimeSpan ShowTime = DTMPShowTime.Value.TimeOfDay;
            //there could be some shows with 0 added price or 0 points
            if (ShowDate + ShowTime > DateTime.Now && hallId!=0 )
            {
                MovieShow mShow = new MovieShow(ShowDate, ShowTime, ShowPoints, showPrice, movieId, hallId);
                MovieShowGateway mShowGate = new MovieShowGateway();
                mShowGate.addMovieShow(mShow);
                MessageBox.Show("we have just added a new show for the movie " + MovieWithNewShow.Name + " on " + DTMPShowDate.Value);

            }
            else
            {
                MessageBox.Show("couldn't add new show :( you either chose an invalid date or an entered value is null");
            }

        }

        
    }
}