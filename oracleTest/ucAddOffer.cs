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
    public partial class ucAddOffer : UserControl
    {
        public ucAddOffer()
        {
            InitializeComponent();
            CBCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            CBCategory.Items.Add("Comedy");
            CBCategory.Items.Add("Drama");
            CBCategory.Items.Add("Adventure");
            CBCategory.Items.Add("Animation");
            CBCategory.Items.Add("Horror");
            CBCategory.Items.Add("Action");
            CBCategory.Items.Add("Thriller");
            CBCategory.Items.Add("Romance");
            DTMPStartDate.Format = DateTimePickerFormat.Custom;
            DTMPStartDate.CustomFormat = "MM/dd/yyyy";
            DTMPEndDate.Format = DateTimePickerFormat.Custom;
            DTMPEndDate.CustomFormat = "MM/dd/yyyy";
        }
        private void BAdd_Click(object sender, EventArgs e)
        {
            double percent = double.Parse(NUDpercentage.Value.ToString());
            Offer of = new Offer(0, percent);
            POfferOverCat.Enabled = true;
            int cat = CBCategory.SelectedIndex + 1;
            DateTime startDate = DTMPStartDate.Value.Date;
            DateTime endDate = DTMPEndDate.Value.Date;
            if (startDate.Date >= DateTime.Now.Date && endDate > startDate && percent!=0 )
            {
                Offer_Over_Category tempoffer = new Offer_Over_Category(0, cat, startDate, endDate);
                Offer_Over_CategoryGateway tempoffgate = new Offer_Over_CategoryGateway();
                //insert offer to insert 
                //Offer_Over_Category
                tempoffgate.insertOffer_Over_Category(of, tempoffer);
                MessageBox.Show("an offer with percentage " + percent.ToString() + " of the type (Offer Over Category) was added to the category " + CBCategory.Text + " from date " + startDate.ToString() + " to date " + endDate.ToString());
            }
            else
            {
                MessageBox.Show("some entered value is not valid");
            }
        }
    }
}