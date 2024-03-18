using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace oracleTest.forms
{
    public partial class UCAddMovie : UserControl
    {
        Movie temMovie;
        public UCAddMovie()
        {
            InitializeComponent();

        }
        //comedy Drama Adventure Animation Horror Action thriller Romance
        private void BAdd_Click(object sender, EventArgs e)
        {
            Regex regDigit = new Regex("\\d");
            Regex regDigit2 = new Regex("\\d");
            string MovieName = TBMovieName.Text;
            int MovieDuration = 0;
            int MovieYear = 0;
            if (regDigit.IsMatch(TBYear.Text))
            {
                MovieYear = int.Parse(TBYear.Text);
            }
            if (regDigit2.IsMatch(TBDuration.Text))
            {
                MovieDuration = int.Parse(TBDuration.Text);
            }
            string MovieDescription = TBDescription.Text;
            temMovie = new Movie(0, MovieName, MovieDuration, MovieYear, MovieDescription);
            MovieGateWay tempMovieGate = new MovieGateWay();
            string[] category = new string[8];
            int i = 0;
            foreach (CheckBox c in gbCategory.Controls)//when the form loads, make sure all the checkboxes are selected.
            {
                if (c.Checked == true)
                {
                    category[i] = c.Text.ToString();
                    i++;
                }
            }
            string[] newarr = new string[i];
            for (int k = 0; k < i; k++)
            {
                newarr[k] = category[k];
            }

            tempMovieGate.addMovie1(temMovie, newarr);
            MessageBox.Show("The Movie   " + MovieName + "   was added");

        }
    }
}