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
    public partial class UCPrintCustomer : UserControl
    {
        public Customer toPrint = new Customer(0, "fadi", "sami", "111", "fadi@sami.com",0);
        public UCPrintCustomer()
        {
            InitializeComponent();
        }
        public void print()
        {
            LFirstNameValue.Text = ToPrint.FirstName;
            LLastNameValue.Text = ToPrint.LastName;
            LEmailValue.Text = ToPrint.Email;
            LPhoneNumberValue.Text = ToPrint.PhoneNumber;
            LPointsValue.Text = ToPrint.Points.ToString();
        }

        public Customer ToPrint
        {
            get
            {
                return toPrint;
            }

            set
            {
                toPrint = value;
            }
        }
    }
}
