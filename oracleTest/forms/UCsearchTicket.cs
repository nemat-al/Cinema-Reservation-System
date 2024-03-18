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
    public partial class UCsearchTicket : UserControl
    {
        DataTable result;
        TicketGateway ticGW = new TicketGateway();
        DataTable table, table2;
        public UCsearchTicket()
        {
            InitializeComponent();
            ucPrintTicketFromFindTicket.Visible = false;
            ucPrintTicketFromFindTicket.Enabled = false;
            dataGridView1.Visible = false;
        }

        private void BFindTicket_Click(object sender, EventArgs e)
        {
            if(table!=null|| table2!= null)
            {
                table.Clear();
                table2.Clear();
            }
            string name = TBFindTicketById.Text;
            string[] twoNames = name.Split(' ');
            if (twoNames.Count() > 2)
                MessageBox.Show("The name consists of only two individual names ");
            else if (twoNames.Count() == 2)
                result = ticGW.ticketByName(twoNames[0], twoNames[1]);
            else if (twoNames.Count() == 1)
            {
                table = ticGW.ticketByName(twoNames[0], "");
                table2 = ticGW.ticketByName("", twoNames[0]);
                if (table.Rows.Count > 0 && table2.Rows.Count > 0)
                {
                    result=table; result.Merge(table2);
                }
                else if (table.Rows.Count > 0)
                    result = table;
                else if (table2.Rows.Count > 0)
                    result = table2;
                else
                { result = null; }
            }
            ///
            if (result == null)
            { MessageBox.Show("sorry either the customer doesn't exists or the customer has no tickets"); }

            else if (result.Rows.Count == 1)
            {

                ucPrintTicketFromFindTicket.ToPrint = result;
                ucPrintTicketFromFindTicket.IndexForTable = 0;
                ucPrintTicketFromFindTicket.print();
                ucPrintTicketFromFindTicket.Visible = true;
                ucPrintTicketFromFindTicket.Enabled = true;
                dataGridView1.Visible = false;

            }
            else if (result.Rows.Count > 1)
            {
                DataGridViewButtonColumn printTicket;
                printTicket = new DataGridViewButtonColumn();
                ////
                printTicket.HeaderText = "print ticket";
                printTicket.Name = "print_ticket_but";
                printTicket.Text = "print ticket";
                printTicket.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(printTicket);
                dataGridView1.CellClick += DGVShowTables_CellClick_print_ticket;

                ////

                dataGridView1.DataSource = result;

                dataGridView1.Visible = true;
                ucPrintTicketFromFindTicket.Visible = false;
                ucPrintTicketFromFindTicket.Enabled = false;

            }
        }

        private void DGVShowTables_CellClick_print_ticket(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == dataGridView1.Columns["print_ticket_but"].Index)
            {

                int x = e.RowIndex;

                ucPrintTicketFromFindTicket.ToPrint = result;
                ucPrintTicketFromFindTicket.IndexForTable = x;
                ucPrintTicketFromFindTicket.print();
                ucPrintTicketFromFindTicket.Visible = true;
                ucPrintTicketFromFindTicket.Enabled = true;
                dataGridView1.Visible = false;



            }
        }
        public void returnToSearch()
        {
            TBFindTicketById.Text = "";
            ucPrintTicketFromFindTicket.Visible = false;
            ucPrintTicketFromFindTicket.Enabled = false;
        }
    }
}
