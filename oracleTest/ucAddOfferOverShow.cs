using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oracleTest.forms
{
    public partial class ucAddOfferOverShow : UserControl
    {
        MovieShow currMovieShow;
        string movieName;
        bool done = true;

        public ucAddOfferOverShow()
        {
            InitializeComponent();
        }

        public string MovieName
        {
            get
            {
                return movieName;
            }

            set
            {
                movieName = value;
            }
        }

        internal MovieShow CurrMovieShow
        {
            get
            {
                return currMovieShow;
            }

            set
            {
                currMovieShow = value;
            }
        }

        public bool Done
        {
            get
            {
                return done;
            }

            set
            {
                done = value;
            }
        }

        public void AddValues()
        {
            LMovieNameValue.Text = MovieName;
            LShowDateValue.Text = (CurrMovieShow.Date + CurrMovieShow.Time).ToString();
            //more pretty
            NUDpercentage.ResetText();
            NUDMinPoints.ResetText();
        }

        private void BAdd_Click(object sender, EventArgs e)
        {
            double perce = double.Parse(NUDpercentage.Value.ToString());
            int minPoints = int.Parse(NUDMinPoints.Value.ToString());
            if (perce != 0 && minPoints != 0)
            {
                Offer of = new Offer(0, perce);
                OfferOverShow OfOverShow = new OfferOverShow(0, currMovieShow.Id, minPoints);
                OfferOverShowGateway ofOverShowGate = new OfferOverShowGateway();
                ofOverShowGate.insertOfferOverShow(of, OfOverShow);
                MessageBox.Show("an offer over Show was added to the movie " + MovieName + " for the show dated " + LShowDateValue.Text + " wuth the percentage " + perce);
                this.Visible = false;
                this.Enabled = false;
                UCtable dady = new UCtable();
                dady = (UCtable)this.Parent;
                dady.showIndex = 6;
                dady.showData();
            }
            else
            {
                MessageBox.Show("please make sure all entered values are correct");
               
            }
        }

        private void Bcancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Enabled = false;
            UCtable dady = new UCtable();
            dady = (UCtable)this.Parent;
            dady.showIndex = 2;
            dady.showData();
        }
    }
}