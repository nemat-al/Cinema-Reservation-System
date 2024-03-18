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
    public partial class UCAddCustomer : UserControl
    {
        bool allIsGood;

        public bool AllIsGood
        {
            get
            {
                return allIsGood;
            }

            set
            {
                allIsGood = value;
            }
        }

        public UCAddCustomer()
        {
            InitializeComponent();   
        }

        private void LPoints_Click(object sender, EventArgs e)
        {

        }

        private void LFirstName_Click(object sender, EventArgs e)
        {

        }

        private void UCAddCustomer_Load(object sender, EventArgs e)
        {

        }

        private void LEmail_Click(object sender, EventArgs e)
        {

        }

        private void LPhoneNumber_Click(object sender, EventArgs e)
        {

        }

        private void LLastName_Click(object sender, EventArgs e)
        {

        }

        private void BAddCustomer_Click(object sender, EventArgs e)
        {
            allIsGood = true;
            Regex RegMail = new Regex("^([a-zA-Z0-9_.]+)@([a-zA-Z0-9_.]+).([a-zA-Z]{2,5})$");//mail regex
            Regex regPhone = new Regex("\\d");
            string temFName = TBFirstName.Text;
            string temLName = TBLastNAme.Text;
            if(temFName==null&& temLName==null)
            {
                AllIsGood = false;
            }
            string temPhoneNumber="default";
            string temEmail= "default";
            int temPoints = 0 ;
            if (RegMail.IsMatch(TBEmail.Text))//check if entered value is avail mail address
            {
                temEmail = TBEmail.Text;
            }
            else
            {
                TBEmail.Text = "please enter a valid email";
                AllIsGood = false;
            }
            if(regPhone.IsMatch(TBPhoneNumber.Text))
            {
                 temPhoneNumber = TBPhoneNumber.Text;
            }else
            {
                TBPhoneNumber.Text = "please make sure that phone number contains only numbers";
                AllIsGood = false;
            }
            if (regPhone.IsMatch(TBPoints.Text))
            {
                temPoints = int.Parse(TBPoints.Text);
            }
            else
            {
                TBPoints.Text = "please make sure that this textBox has numbers only";
                AllIsGood = false;
            }
            if (AllIsGood)
            {
                Customer tempCustomer = new Customer(0, temFName, temLName, temPhoneNumber, temEmail, temPoints);
                CustomerGateWay tempCustemerGateWay = new CustomerGateWay();
                tempCustemerGateWay.addCustomer(tempCustomer);
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult dialog = MessageBox.Show("Customer " + temFName + " has been added", "Succes", buttons);
            }else
            {
                MessageBox.Show("couldn't add this customer :( please check the entered values");
            }
           
        }
    }
}
