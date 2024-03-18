using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oracleTest.forms
{
    public partial class FManagement : Form
    {
        string user;

        public string User
        {
            get
            {
                return user;
            }

            set
            {
                user = value;
            }
        }

        public FManagement(string user)
        {
            InitializeComponent();
            ucAddMovieFromManagment.Enabled = false;
            ucAddMovieFromManagment.Visible = false;
            uCtableFromManagment.Enabled = false;
            uCtableFromManagment.Visible = false;
            ucMovieStatis1.Enabled = false;
            ucMovieStatis1.Visible = false;
            ucAddOfferfromManagmentButton.Enabled = false;
            ucAddOfferfromManagmentButton.Visible = false;
            this.User = user;
        }

        private void BAddMovie_Click(object sender, EventArgs e)
        {
            uCtableFromManagment.Enabled = false;
            uCtableFromManagment.Visible = false;
            ucMovieStatis1.Enabled = false;
            ucMovieStatis1.Visible = false;
            ucAddMovieFromManagment.Enabled = true;
            ucAddMovieFromManagment.Visible = true;
            ucAddOfferfromManagmentButton.Enabled = false;
            ucAddOfferfromManagmentButton.Visible = false;

        }

        private void BShowEmployees_Click(object sender, EventArgs e)
        {

            ucAddOfferfromManagmentButton.Enabled = false;
            ucAddOfferfromManagmentButton.Visible = false;
            ucAddMovieFromManagment.Enabled = false;
            ucAddMovieFromManagment.Visible = false;
            ucMovieStatis1.Enabled = false;
            ucMovieStatis1.Visible = false;
            uCtableFromManagment.Enabled = true;
            uCtableFromManagment.Visible = true;
            uCtableFromManagment.showIndex = 4;
            uCtableFromManagment.showData();
        }

        private void BViewAndEditShows_Click(object sender, EventArgs e)
        {
            uCtableFromManagment.Enabled = true;
            uCtableFromManagment.Visible = true;
            uCtableFromManagment.showIndex = 2;
            uCtableFromManagment.showData();
            ucAddOfferfromManagmentButton.Enabled = false;
            ucAddOfferfromManagmentButton.Visible = false;
            ucAddMovieFromManagment.Enabled = false;
            ucAddMovieFromManagment.Visible = false;
            ucMovieStatis1.Enabled = false;
            ucMovieStatis1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //a manager can do every thing a receptionest can do
            FReceptionist recep = new FReceptionist(User,true);
            recep.ShowDialog();
        }

        private void FManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BMovies_Click(object sender, EventArgs e)
        {
            ucAddOfferfromManagmentButton.Enabled = false;
            ucAddOfferfromManagmentButton.Visible = false;
            ucAddMovieFromManagment.Enabled = false;
            ucAddMovieFromManagment.Visible = false;
            uCtableFromManagment.Enabled = true;
            uCtableFromManagment.Visible = true;
            ucMovieStatis1.Enabled = false;
            ucMovieStatis1.Visible = false;
            uCtableFromManagment.showIndex = 5;
            uCtableFromManagment.showData();
        }

        private void BMovieStatistics_Click(object sender, EventArgs e)
        {
            ucAddMovieFromManagment.Enabled = false;
            ucAddMovieFromManagment.Visible = false;
            uCtableFromManagment.Enabled = false;
            uCtableFromManagment.Visible = false;
            ucMovieStatis1.Enabled = true;
            ucMovieStatis1.Visible = true;
            ucAddOfferfromManagmentButton.Enabled = false;
            ucAddOfferfromManagmentButton.Visible = false;

        }

        private void bAddOfferOverCategory_Click(object sender, EventArgs e)
        {
            ucAddOfferfromManagmentButton.Enabled = true;
            ucAddOfferfromManagmentButton.Visible = true;
            ucAddMovieFromManagment.Enabled = false;
            ucAddMovieFromManagment.Visible = false;
            uCtableFromManagment.Enabled = false;
            uCtableFromManagment.Visible = false;
            ucMovieStatis1.Enabled = false;
            ucMovieStatis1.Visible = false;
        }

        private void BAddOfferOverShow_Click(object sender, EventArgs e)
        {
            uCtableFromManagment.Enabled = true;
            uCtableFromManagment.Visible = true;
            uCtableFromManagment.showIndex = 6;
            uCtableFromManagment.showData();
            ucAddOfferfromManagmentButton.Enabled = false;
            ucAddOfferfromManagmentButton.Visible = false;
            ucAddMovieFromManagment.Enabled = false;
            ucAddMovieFromManagment.Visible = false;
            ucMovieStatis1.Enabled = false;
            ucMovieStatis1.Visible = false;
        }

        private void ucMovieStatis1_Load(object sender, EventArgs e)
        {

        }
    }
}