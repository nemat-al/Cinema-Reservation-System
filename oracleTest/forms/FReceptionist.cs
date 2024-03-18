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
    public partial class FReceptionist : Form
    {
        int showIndex = 0;
        string user;
        bool manager;

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

        public bool Manager
        {
            get
            {
                return manager;
            }

            set
            {
                manager = value;
            }
        }

        public FReceptionist(string user, bool manager)
        {
            InitializeComponent();
            ucAddCustomerIn.Enabled = false;
            ucAddCustomerIn.Visible = false;
           // ucSearchCustomerIn.Visible = false;
            //ucSearchCustomerIn.Enabled = false;
            uCtableShow.Enabled = false;
            uCtableShow.Visible = false;
            uCsearchTicketfromReceptionist.Visible = false;
            uCsearchTicketfromReceptionist.Enabled = false;
            uCaddTicketfromRecep.Enabled = false;
            uCaddTicketfromRecep.Visible = false;
            this.User = user;
            this.Manager = manager;
        }

        private void BShowMovies_Click(object sender, EventArgs e)
        {
            ucAddCustomerIn.Enabled = false;
            ucAddCustomerIn.Visible = false;
            //ucSearchCustomerIn.Visible = false;
            //ucSearchCustomerIn.Enabled = false;
            uCsearchTicketfromReceptionist.Visible = false;
            uCsearchTicketfromReceptionist.Enabled = false;
            uCaddTicketfromRecep.Enabled = false;
            uCaddTicketfromRecep.Visible = false;
            uCtableShow.Enabled = true;
            uCtableShow.Visible = true;
            uCtableShow.showIndex = 3;
            uCtableShow.showData();
            uCtableShow.User = User;
        }

        private void BAddCustomer_Click(object sender, EventArgs e)
        {
            //ucSearchCustomerIn.Visible = false;
            //ucSearchCustomerIn.Enabled = false;
            uCtableShow.Enabled = false;
            uCtableShow.Visible = false;
            uCsearchTicketfromReceptionist.Visible = false;
            uCsearchTicketfromReceptionist.Enabled = false;
            ucAddCustomerIn.Visible = true;
            ucAddCustomerIn.Enabled = true;
            uCaddTicketfromRecep.Enabled = false;
            uCaddTicketfromRecep.Visible = false;
        }

        private void BPrintCustumer_Click(object sender, EventArgs e)
        {
            ucAddCustomerIn.Enabled = false;
            ucAddCustomerIn.Visible = false;
            uCtableShow.Enabled = false;
            uCtableShow.Visible = false;
            uCsearchTicketfromReceptionist.Visible = false;
            uCsearchTicketfromReceptionist.Enabled = false;
            uCaddTicketfromRecep.Enabled = false;
            uCaddTicketfromRecep.Visible = false;
            FsearchCustomer FsearchCustomerTemp = new FsearchCustomer();
            FsearchCustomerTemp.ShowDialog();
            // FsearchCustomerTemp
           // ChangeEnabled(true);


        }
        void ChangeEnabled(bool enabled)
        {
            foreach (Control c in this.Controls)
            {
                c.Enabled = enabled;
            }
        }
        private void BShowTickets_Click(object sender, EventArgs e)
        {

            ucAddCustomerIn.Enabled = false;
            ucAddCustomerIn.Visible = false;
            //ucSearchCustomerIn.Visible = false;
            //ucSearchCustomerIn.Enabled = false;
            uCsearchTicketfromReceptionist.Visible = false;
            uCsearchTicketfromReceptionist.Enabled = false;
            uCaddTicketfromRecep.Enabled = false;
            uCaddTicketfromRecep.Visible = false;
            uCtableShow.Enabled = true;
            uCtableShow.Visible = true;
            uCtableShow.showIndex = 1;
            uCtableShow.showData();
            uCtableShow.User = User;
        }

        private void BPrintTicket_Click(object sender, EventArgs e)
        {
            uCsearchTicketfromReceptionist.returnToSearch();
            ucAddCustomerIn.Enabled = false;
            ucAddCustomerIn.Visible = false;
            //ucSearchCustomerIn.Visible = false;
            //ucSearchCustomerIn.Enabled = false;
            uCtableShow.Enabled = false;
            uCtableShow.Visible = false;
            uCsearchTicketfromReceptionist.Enabled = true;
            uCsearchTicketfromReceptionist.Visible = true;
            uCaddTicketfromRecep.Enabled = false;
            uCaddTicketfromRecep.Visible = false;
        }

        private void BaddTicket_Click(object sender, EventArgs e)
        {
            uCaddTicketfromRecep.UpdateTic = false;
            uCaddTicketfromRecep.update();
            uCaddTicketfromRecep.Enabled = true;
            uCaddTicketfromRecep.Visible = true;
            ucAddCustomerIn.Enabled = false;
            ucAddCustomerIn.Visible = false;
          
            //ucSearchCustomerIn.Visible = false;
            //ucSearchCustomerIn.Enabled = false;
            uCtableShow.Enabled = false;
            uCtableShow.Visible = false;
            uCsearchTicketfromReceptionist.Enabled = false;
            uCsearchTicketfromReceptionist.Visible = false;
            uCaddTicketfromRecep.User = User;
        }

        private void FReceptionist_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(Manager)
            {
                
            }else
            {
                Application.Exit();
            }
        }
    }
}
