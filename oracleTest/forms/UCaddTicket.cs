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
    public partial class UCaddTicket : UserControl
    {
        string user;
        EmployeeGateWay empGetWay= new EmployeeGateWay();
        TicketGateway ticGateWay = new TicketGateway();
        private Ticket certainTicket ;
        Employee emp;
        int ShowId = 0;
        int pre = 0;
        Ticket added;
        Customer tempadded;
        bool updateTic = false;
        bool customerChosed = false;
        bool offersChecked = false;
        int off_id;
        FlowLayoutPanel pnl = new FlowLayoutPanel();
        public UCaddTicket()
        {
            InitializeComponent();
            cBHall.Items.Add("Central");
            cBHall.Items.Add("Right");
            cBHall.Items.Add("Left");
            
        }

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

        public void update()
        {
            if (updateTic == false)
            {
                ChangeEnabled(true);
                GBupdate.Visible = false;
                GBupdate.Enabled = false;
            }
            else
            {
                ChangeEnabled(false);
                GBupdate.Visible = true;
                GBupdate.Enabled = true;
            }
        }
        public bool UpdateTic
        {
            get
            {
                return updateTic;
            }

            set
            {
                updateTic = value;
            }
        }

        internal Ticket CertainTicket
        {
            get
            {
                return certainTicket;
            }

            set
            {
                certainTicket = value;
            }
        }
        public void toUpdateTicket(Ticket tic)
        {
            CertainTicket = tic;
        }
        private void BAdd_Click(object sender, EventArgs e)
        {
            string tempwayreserved;
            DateTime PayedTime = DateTime.Now;
            //Employee phoneEm;
            String phoneEmployee = "";
            if (rBPerson.Checked)
            {
                 tempwayreserved = "person";
                LEmployeeWhoRecevedPaymentValue.Text = User;
                LREservedEmployeeVslue.Text = User;
                LStatusValue.Text = "Confirmed";
                LDatePAymentValue.Text = PayedTime.ToString();
            }
            else
            {
                tempwayreserved = "phone";
                LREservedEmployeeVslue.Text = User;
                phoneEmployee = user;
                LEmployeeWhoRecevedPaymentValue.Text = "waiting for payment";
                LStatusValue.Text = "Not Confirmed";
                LDatePAymentValue.Text = "Not Payed";
            }
            DateTime dateReserved = DateTime.Now;
            LDateReserveValue.Text = dateReserved.ToString();
            String ReservedEmployee = LREservedEmployeeVslue.Text;
            String ResevedPaymentEmployee = LEmployeeWhoRecevedPaymentValue.Text;
            int seatId = int.Parse(nUDSeat.Value.ToString());
            int rowId = int.Parse(nUDRow.Value.ToString());
            LREservedEmployeeVslue.Text = User;
            //if(PayedTime!=null)
            //{
            //    LEmployeeWhoRecevedPaymentValue.Text = User;
            //    LStatusValue.Text = "Confirmed";
            //}
            //else
            //{
            //    LEmployeeWhoRecevedPaymentValue.Text = "waiting for payment";
            //    LStatusValue.Text = "Not Confirmed";
            //}
            string status = LStatusValue.Text;
            string hall = cBHall.Text;
            int seat = int.Parse(nUDSeat.Value.ToString());
          
            Regex regShowId = new Regex("\\d");
            if(regShowId.IsMatch(TBMovieShowId.Text))
            {
                ShowId = int.Parse(TBMovieShowId.Text);
            }
            //get the selected radio buttomn
            RadioButton rbSelected = pnl.Controls
                          .OfType<RadioButton>()
                          .FirstOrDefault(r => r.Checked);
            if (rbSelected==null) { off_id = 0; }
            else { string text = rbSelected.Text; string[] precentage = text.Split('/');
                off_id = Int32.Parse(precentage[0]);
            }
            
            if (customerChosed && (rBPhone.Checked|| rBPerson.Checked) && (nUDSeat.Value!=0) && 
                (nUDRow.Value!=0) && (TBMovieShowId.Text!="") )
            {
                EmployeeGateWay empGetWay = new EmployeeGateWay();
                Employee emp = empGetWay.employeeByUsername(User);
                added = new Ticket(0, off_id, status, tempwayreserved, dateReserved, DateTime.Now, PayedTime, tempadded.Id, ShowId, emp.Id, emp.Id, emp.Id, emp.Id, rowId, seat);
                TicketGateway ticGateWay = new TicketGateway();
                MovieShowGateway movGatWay = new MovieShowGateway();
                if (movGatWay.decreaseAvailableSeats(ShowId) == 1)
                {
                    int addOrNot = ticGateWay.addTicket_func(added);
                    if (addOrNot == 0)
                    {
                        MessageBox.Show("Sorry either The seat is already taken or the seat number doesn't exists");
                        nUDSeat.Value = 0;
                    }
                    else if(addOrNot==1)
                    {
                        MessageBox.Show("The Ticket was added successfully");
                        nUDSeat.Value = 1;
                    }

                }
                else {
                    TBMovieShowId.Text = "";
                    MessageBox.Show("Sorry all the seats are taken for this Show :("); }
            }
                
            else
            {
                MessageBox.Show("please Insert all the information, they are all required !");
            }
   }

        private void BCustomer_Click(object sender, EventArgs e)
        {
           
            FsearchCustomer searchCustomer = new FsearchCustomer();         
            ChangeEnabled(false);
            searchCustomer.FormClosed += searchCustomer_FormClosed;
            searchCustomer.ShowDialog();
            tempadded = searchCustomer.FoundCustomer;
            if (tempadded!=null)
            {
                customerChosed = true;
            }
        }
        public void update_Ticket()
        {
            cBHall.Enabled = false;
            nUDSeat.Enabled = false;
            BCustomer.Enabled = false;


        }
        private void searchCustomer_FormClosed(object sender, FormClosedEventArgs e)
        {
            ChangeEnabled(true);

        }
        void ChangeEnabled(bool enabled)
        {
            foreach (Control c in this.Controls)
            {
                c.Enabled = enabled;
            }
        }

        private void RBCancel_CheckedChanged(object sender, EventArgs e)
        {
            if (RBCancel.Checked)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to Cancel this Ticket??\n you won't be able to undo that :/", "Confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //change Status of this Ticket
                    emp = empGetWay.employeeByUsername(User);
                    ticGateWay.cancelTicket(certainTicket.Id);
                    MessageBox.Show("This Ticket Was Canceled");
                    LStatusValue.Text = "Canceled";
                    ChangeEnabled(false);
                    this.Visible = false;
                    this.Enabled = false;
                    UCtable dady = new UCtable();
                    dady = (UCtable)this.Parent;
                    dady.showIndex = 1;
                    dady.showData();
                }
                else if (dialogResult == DialogResult.No)
                {
                    RBCancel.Checked = false;
                    this.update();
                }
            }  
            
        }

        private void RB_CheckedChanged(object sender, EventArgs e)
        {
            //to pay for the Ticket
            if (RB.Checked)
            {
                LEmployeeWhoRecevedPaymentValue.Text = User;
                LStatusValue.Text = "Confirmed";
                LDatePAymentValue.Text = DateTime.Now.ToString();

                emp = empGetWay.employeeByUsername(User);
                if (ticGateWay.confirmTicket(certainTicket.Id, emp.Id, DateTime.Now) == 1)
                {
                    MessageBox.Show("This Ticket Was Confirmed");
                    this.Visible = false;
                    this.Enabled = false;
                    UCtable dady = new UCtable();
                    dady = (UCtable)this.Parent;
                    dady.showIndex = 1;
                    dady.showData();
                }
                else
                    MessageBox.Show("This Ticket Wasn't able to be Confirmed");
                ChangeEnabled(false);
            }
        }

        private void findOffersButtom_Click(object sender, EventArgs e)
        {
            if (TBMovieShowId.Text != "" && tempadded != null)
            {
                offersChecked = true;
                MovieShowGateway msc = new MovieShowGateway();
                ShowId = int.Parse(TBMovieShowId.Text);
                DataTable tableCategory = msc.AllOfferOverCategory(ShowId);
                DataTable tableShow = msc.AllOfferOverShow(ShowId, tempadded.Id);
                int num = tableShow.Rows.Count + tableCategory.Rows.Count;
                pnl.Controls.Clear();
                if (num > 0)
                {

                    if (tableShow.Rows.Count > 0)
                    {
                        pnl.Dock = DockStyle.Fill;
                        //Label lab = new Label();
                        //lab.Text = "offer_id - least Points - precentage";
                        //pnl.Controls.Add(lab);
                        for (int i = 0; i < tableShow.Rows.Count; i++)
                        {
                            pnl.Controls.Add(new RadioButton() { Text = tableShow.Rows[i].ItemArray[0] + "/" + tableShow.Rows[i].ItemArray[1] + "/" + tableShow.Rows[i].ItemArray[2] });
                        }
                    }
                    if (tableCategory.Rows.Count > 0)
                    {
                        pnl.Dock = DockStyle.Fill;
                        //Label lab = new Label();
                        //lab.Text = "offer_id - precentage";
                        //pnl.Controls.Add(lab);
                        for (int i = 0; i < tableCategory.Rows.Count; i++)
                        {
                            pnl.Controls.Add(new RadioButton() { Text = tableCategory.Rows[i].ItemArray[0] + "/" + tableCategory.Rows[i].ItemArray[2] });
                        }
                    }

                    chooseOffers.Controls.Add(pnl);

                }
                else { MessageBox.Show("Sorry, No offers found "); }
            }
            else { MessageBox.Show("Both customer id and movie show id must be chosen"); }


        }

    }


    }
