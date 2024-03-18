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
    public partial class UCPrintTicket : UserControl
    {
        DataTable toPrint = new DataTable();
        int indexForTable = 0;
        public UCPrintTicket()
        {
            InitializeComponent();


        }

        public DataTable ToPrint
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

        public int IndexForTable
        {
            get
            {
                return indexForTable;
            }

            set
            {
                indexForTable = value;
            }
        }

        // this func return table that containes : 
        //Ticket_Id , customerId,  Customer_Name,  Movie_name,  Movie_Show_Date,
        // Movie_Show_Time, hall_id, status,  seatId
        public void print()
        {

            LCustomerIdValue.Text = (ToPrint.Rows[IndexForTable].ItemArray[1]).ToString();
            LCustomerNameValue.Text = (ToPrint.Rows[IndexForTable].ItemArray[2]).ToString();
            LMovieNAmeValue.Text = (ToPrint.Rows[IndexForTable].ItemArray[3]).ToString();
            LShowDateValue.Text = (ToPrint.Rows[IndexForTable].ItemArray[4]).ToString();
            // LShowHourVlaue.Text = (ToPrint.Rows[0].ItemArray[5]).ToString();
            LHallNameValue.Text = (ToPrint.Rows[IndexForTable].ItemArray[6]).ToString();
            LStatus.Text = (ToPrint.Rows[IndexForTable].ItemArray[7]).ToString();
            LSeatNumberValue.Text = (ToPrint.Rows[IndexForTable].ItemArray[9]).ToString();
        }

    }
}
