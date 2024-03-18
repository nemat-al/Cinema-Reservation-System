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
    public partial class UCtable : UserControl
    {
        public int showIndex = 0;
        string user;
        public Employee certain_Employee;
        DataGridViewButtonColumn uninstallButtonColumn;
        DataTable table = new DataTable();
        List<MovieShow> updatedShows = new List<MovieShow>();

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


        public UCtable()
        {
            InitializeComponent();
            //uCaddTicketfromShows.Enabled = false;
            //uCaddTicketfromShows.Visible = false;
            //add another column to the DataGridView
            uninstallButtonColumn = new DataGridViewButtonColumn();
            DGVShowTables.Columns.Add(uninstallButtonColumn);
            uninstallButtonColumn.Visible = false;
            BconfirmUpdate.Visible = false;
            BconfirmUpdate.Enabled = false;
            ucAddOfferOverShowfromTables.Visible = false;
            ucAddOfferOverShowfromTables.Enabled = false;
        }
        public void showData()
        {       
            ucAddOfferOverShowfromTables.Visible = false;
            ucAddOfferOverShowfromTables.Enabled = false;
            uCaddTicketfromShows.Enabled = false;
            uCaddTicketfromShows.Visible = false;
            ucAddShowfromDGV.Enabled = false;
            ucAddShowfromDGV.Visible = false;
            uninstallButtonColumn.Visible = false;
            BconfirmUpdate.Visible = false;
            BconfirmUpdate.Enabled = false;
            ucEmployeeStatis1.Enabled = false;
            ucEmployeeStatis1.Visible = false;
            DGVShowTables.Enabled = true;
            DGVShowTables.Visible = true;
            BShowData.Visible = true;
            BShowData.Enabled = true;
            if (showIndex == 1)//show tickets
            {
                // DGVShowTables.Columns.Remove(uninstallButtonColumn);

                TicketGateway ticketGateay = new TicketGateway();
                table.Clear();
                table = ticketGateay.selectAllTicket();
                DGVShowTables.DataSource = table;
                uninstallButtonColumn.HeaderText = "Update Ticket";
                uninstallButtonColumn.Name = "Update_Ticket";
                uninstallButtonColumn.Text = "Update Ticket";
                DGVShowTables.Enabled = true;
                DGVShowTables.Visible = true;
                uninstallButtonColumn.UseColumnTextForButtonValue = true;
                //DGVShowTables.Columns.Add(uninstallButtonColumn);

                uninstallButtonColumn.Visible = true;
                //when we press this button here we should update the Ticket
                //call something to update the ticket
                DGVShowTables.CellClick += DGVShowTables_CellClick_Update_Ticket;
            }
            else if (showIndex == 2)//show Shows/Management/ to update
            {
                //call a function to get the data
                //MovieGateWay movieGateway = new MovieGateWay(ConnectionBuilder.GetConnection());
                //table.Clear();
                //table = movieGateway.selectAllMovie();
                //DGVShowTables.DataSource = table;
                //SHOW MOVIES

                //MovieShowGateway showGateway = new MovieShowGateway(ConnectionBuilder.GetConnection());
                // DGVShowTables.Columns.Remove(uninstallButtonColumn);
                MovieShowGateway showGateway = new MovieShowGateway();

                if (table.Rows.Count != 0)
                {
                    table.Clear();
                }
                table = showGateway.selectAllMovieShowAfterToday(DateTime.Now);
                DGVShowTables.DataSource = table;
                BconfirmUpdate.Visible = true;
                BconfirmUpdate.Enabled = true;
                DGVShowTables.CellValueChanged += DGVShowTables_CellValueChanged;
                //uninstallButtonColumn.HeaderText = "Add Offer Over Show";
                //uninstallButtonColumn.Name = "Add_Offer_Over_Show";
                //uninstallButtonColumn.Text = "Add Offer";
                //uninstallButtonColumn.UseColumnTextForButtonValue = true;
                //DGVShowTables.Columns.Add(uninstallButtonColumn);
                uninstallButtonColumn.Visible = false;
                //When we cahnge Cells value
                //DGVShowTables.CellClick += DGVShowTables_CellClick_Add_Offer;
                // DGVShowTables.CellValueChanged += DGVShowTables_CellValueChanged_Update_Shows();

            }
            else if (showIndex == 3)//show shows
            {
                //call a function to get the data
                // DGVShowTables.Columns.Remove(uninstallButtonColumn);
                MovieShowGateway showGateway = new MovieShowGateway();
                if (table.Rows.Count != 0)
                {
                    table.Clear();
                }
                table = showGateway.selectAllMovieShowAfterToday(DateTime.Now);
                DGVShowTables.DataSource = table;
                uninstallButtonColumn.HeaderText = "Add Ticket";
                uninstallButtonColumn.Name = "Add_Ticket";
                uninstallButtonColumn.Text = "Add Ticket";
                uninstallButtonColumn.UseColumnTextForButtonValue = true;
                // DGVShowTables.Columns.Add(uninstallButtonColumn);
                DGVShowTables.Enabled = true;
                DGVShowTables.Visible = true;
                uninstallButtonColumn.Visible = true;
                DGVShowTables.CellClick += DGVShowTables_CellClick_Add_Ticket;

            }
            else if (showIndex == 4)//show Employee
            {
                EmployeeGateWay employeeGateWay = new EmployeeGateWay();
                if (table.Rows.Count != 0)
                {
                    table.Clear();
                }
                table = employeeGateWay.allWorkForEmployees();
                DGVShowTables.DataSource = table;
                DGVShowTables.Enabled = true;
                DGVShowTables.Visible = true;
                /////////
                uninstallButtonColumn.HeaderText = "the Tickets";
                uninstallButtonColumn.Name = "show_managed_tickets";
                uninstallButtonColumn.Text = "managed tickets";
                uninstallButtonColumn.UseColumnTextForButtonValue = true;
                // DGVShowTables.Columns.Add(uninstallButtonColumn);
                uninstallButtonColumn.Visible = true;
                DGVShowTables.CellClick += DGVShowTables_CellClick_show_employee_work;
            }
            else if (showIndex == 5)//show Movies
            {
                //DGVShowTables.Columns.Remove(uninstallButtonColumn);
                MovieGateWay movieGateway = new MovieGateWay();
                table.Clear();
                table = movieGateway.selectAllMovie();
                DGVShowTables.DataSource = table;
                uninstallButtonColumn.HeaderText = "Add Show";
                uninstallButtonColumn.Name = "Add_Show";
                uninstallButtonColumn.Text = "Add Show";
                uninstallButtonColumn.UseColumnTextForButtonValue = true;
                // DGVShowTables.Columns.Add(uninstallButtonColumn);
                DGVShowTables.Enabled = true;
                DGVShowTables.Visible = true;
                uninstallButtonColumn.Visible = true;
                DGVShowTables.CellClick += DGVShowTables_CellClick_Add_Show;

            }
            else if(showIndex==6)//show Shows/Management/ to add offer
            {
                MovieShowGateway showGateway = new MovieShowGateway();

                if (table.Rows.Count != 0)
                {
                    table.Clear();
                }
                table = showGateway.selectAllMovieShowAfterToday(DateTime.Now);
                DGVShowTables.DataSource = table;
                uninstallButtonColumn.HeaderText = "Add Offer Over Show";
                uninstallButtonColumn.Name = "Add_Offer_Over_Show";
                uninstallButtonColumn.Text = "Add Offer";
                uninstallButtonColumn.UseColumnTextForButtonValue = true;
                //DGVShowTables.Columns.Add(uninstallButtonColumn);
                uninstallButtonColumn.Visible = true;
                //When we cahnge Cells value
                DGVShowTables.CellClick += DGVShowTables_CellClick_Add_Offer;
                // DGVShowTables.CellValueChanged += DGVShowTables_CellValueChanged_Update_Shows();

            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Some thing went wrong 😞", "Error", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {


                }
                else if (dialogResult == DialogResult.No)
                {


                }


            }
        }

        //private DataGridViewCellEventHandler DGVShowTables_CellValueChanged_Update_Shows()
        //{
        //   // throw new NotImplementedException();
        //}

        private void DGVShowTables_CellClick_Add_Ticket(object sender, DataGridViewCellEventArgs e)
        {
            if (showIndex == 3)
            {
                
                //MovieShowGateway showGateway = new MovieShowGateway(ConnectionBuilder.GetConnection());
                if (e.ColumnIndex == DGVShowTables.Columns["Add_ticket"].Index)
                {
                    ucAddOfferOverShowfromTables.Visible = false;
                    ucAddOfferOverShowfromTables.Enabled = false;
                    ucAddShowfromDGV.Enabled = false;
                    ucAddShowfromDGV.Visible = false;
                    BconfirmUpdate.Visible = false;
                    BconfirmUpdate.Enabled = false;
                    ucEmployeeStatis1.Enabled = false;
                    ucEmployeeStatis1.Visible = false;
                    DGVShowTables.Enabled = false;
                    DGVShowTables.Visible = false;
                    BShowData.Visible = false;
                    BShowData.Enabled = false;
                    uCaddTicketfromShows.Enabled = true;
                    uCaddTicketfromShows.Visible = true;
                    uCaddTicketfromShows.User = User;
                    uCaddTicketfromShows.UpdateTic = false;
                    uCaddTicketfromShows.update();
                }
            }

        }
        private void DGVShowTables_CellClick_Add_Show(object sender, DataGridViewCellEventArgs e)
        {
            if (showIndex == 5)
            {
                BShowData.Visible = false;
                BShowData.Enabled = false;
                if (e.ColumnIndex == DGVShowTables.Columns["Add_Show"].Index)
                {
                    int x = e.RowIndex;
                    uCaddTicketfromShows.Enabled = false;
                    uCaddTicketfromShows.Visible = false;
                    ucAddShowfromDGV.Enabled = true;
                    ucAddShowfromDGV.Visible = true;
                    DGVShowTables.Enabled = false;
                    DGVShowTables.Visible = false;
                    ucAddShowfromDGV.MovieWithNewShow = new Movie(int.Parse((table.Rows[x].ItemArray[0]).ToString()),
                                      table.Rows[x].ItemArray[1].ToString(), int.Parse(table.Rows[x].ItemArray[2].ToString()), int.Parse(table.Rows[x].ItemArray[3].ToString()), table.Rows[x].ItemArray[4].ToString());
                    ucAddShowfromDGV.printName();
                }
            }
        }

        private void DGVShowTables_CellClick_Update_Ticket(object sender, DataGridViewCellEventArgs e)
        {
            if (showIndex == 1)
            {
                if (e.ColumnIndex == DGVShowTables.Columns["Update_Ticket"].Index)
                {
                   
                    int x = e.RowIndex;
                    if (x >= 0)
                    {
                        uCaddTicketfromShows.CertainTicket = new Ticket(int.Parse((table.Rows[x].ItemArray[0]).ToString()));
                        //ucAddShowfromDGV.printName();
                        uCaddTicketfromShows.Enabled = true;
                        uCaddTicketfromShows.Visible = true;
                        uCaddTicketfromShows.User = User;
                        uCaddTicketfromShows.UpdateTic = true;
                        uCaddTicketfromShows.update();
                        //uCaddTicketfromShows.CertainTicket=
                    }

                }
            }
        }





        private void DGVShowTables_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //uCaddTicketfromShows.Enabled = false;
            //uCaddTicketfromShows.Visible = false;
            //ucAddShowfromDGV.Enabled = false;
            //ucAddShowfromDGV.Visible = false;
            if (showIndex == 2)
            {
                if (!(e.ColumnIndex == 2))
                {
                    int x = e.RowIndex;
                    if (x >= 0)
                    {
                        MovieShow temp = new MovieShow(int.Parse((table.Rows[x].ItemArray[1]).ToString()), Convert.ToDateTime((table.Rows[x].ItemArray[2]).ToString()), TimeSpan.Parse((table.Rows[x].ItemArray[3]).ToString()), int.Parse((table.Rows[x].ItemArray[4]).ToString()),
                            double.Parse((table.Rows[x].ItemArray[6]).ToString()));
                        //bool alreadyExist = updatedShows.Contains(temp);
                        //if(!alreadyExist)
                        int index = updatedShows.FindIndex(Item => temp.Id == int.Parse((table.Rows[x].ItemArray[1]).ToString()));
                        //first update to a value in this object
                        if (!(index >= 0))
                        {
                            updatedShows.Add(temp);
                        }
                        //update more than one value in an object
                        else
                        {
                            //taking the changed value
                            string changed = DGVShowTables[e.ColumnIndex, e.RowIndex].Value.ToString();
                            if (e.ColumnIndex == 3)
                                updatedShows[index].Date = Convert.ToDateTime(changed);
                            else if (e.ColumnIndex == 4)
                                updatedShows[index].Time = TimeSpan.Parse(changed);
                            else if (e.ColumnIndex == 5)
                                updatedShows[index].Points = int.Parse(changed);
                            else if (e.ColumnIndex == 7)
                                updatedShows[index].SeatsAddedPrice = double.Parse(changed);
                        }


                    }
                }

            }
        }

        private void BconfirmUpdate_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("are you sure you want to carry out with that updates, you won't be able to undo them 😕 ", "Please Confirm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (updatedShows.Count != 0)
                {
                    foreach (MovieShow ms in updatedShows)
                    {
                        MovieShowGateway tempSGW = new MovieShowGateway();
                        tempSGW.updateMovieShow(ms);
                    }
                }
                MessageBox.Show("updates done 🙂");
                showData();

            }
            else if (dialogResult == DialogResult.No)
            {

                showData();
            }
        }

        private void DGVShowTables_CellClick_show_employee_work(object sender, DataGridViewCellEventArgs e)
        {
            if (showIndex == 4)
            {
                if (e.ColumnIndex == DGVShowTables.Columns["show_managed_tickets"].Index)
                {
                    int x = e.RowIndex;
                    certain_Employee = new Employee(int.Parse((table.Rows[x].ItemArray[0]).ToString()));
                    //////manage the following
                    this.DGVShowTables.Enabled = false;
                    this.DGVShowTables.Visible = false;
                    ucEmployeeStatis1.Enabled = true;
                    ucEmployeeStatis1.Visible = true;
                    ucEmployeeStatis1.CertainEmployee = certain_Employee;
                    ucEmployeeStatis1.showData();
                    
                     //ucAddShowfromDGV.printName();

                }
            }
        }
        /*private void DGVShowTables_CellClick_Add_Offer(object sender, DataGridViewCellEventArgs e)
         {
             if (showIndex == 2)
             {
                 //MovieShowGateway showGateway = new MovieShowGateway(ConnectionBuilder.GetConnection());
                 if (e.ColumnIndex == DGVShowTables.Columns["Add_Offer_Over_Show"].Index)
                 {
                     BconfirmUpdate.Visible = false;
                     BconfirmUpdate.Enabled = false;
                     uCaddTicketfromShows.Enabled = false;
                     uCaddTicketfromShows.Visible = false;
                     ucAddShowfromDGV.Enabled = false;
                     ucAddShowfromDGV.Visible = false;
                     uninstallButtonColumn.Visible = false;
                     ucEmployeeStatis1.Enabled = false;
                     ucEmployeeStatis1.Visible = false;
                     bool done = false;
                     int x = e.RowIndex;
                     ucAddOfferOverShowfromTables.Visible = true;
                     ucAddOfferOverShowfromTables.Enabled = true;
                     ucAddOfferOverShowfromTables.CurrMovieShow = new MovieShow(int.Parse((table.Rows[x].ItemArray[1]).ToString()),
                         Convert.ToDateTime((table.Rows[x].ItemArray[2]).ToString()),
                         TimeSpan.Parse((table.Rows[x].ItemArray[3]).ToString()),
                         int.Parse((table.Rows[x].ItemArray[4]).ToString()),
                         double.Parse((table.Rows[x].ItemArray[6]).ToString()));
                     //this.Visible = false;
                     //this.Enabled = false;
                     ucAddOfferOverShowfromTables.MovieName = (table.Rows[x].ItemArray[0]).ToString();
                     ucAddOfferOverShowfromTables.AddValues();
                     //done = ucAddOfferOverShowfromTables.Done;

                 }
             }
         }*/
        private void DGVShowTables_CellClick_Add_Offer(object sender, DataGridViewCellEventArgs e)
        {
            if (showIndex == 6)
            {
                //MovieShowGateway showGateway = new MovieShowGateway(ConnectionBuilder.GetConnection());
                if (e.ColumnIndex == DGVShowTables.Columns["Add_Offer_Over_Show"].Index)
                {
                    BconfirmUpdate.Visible = false;
                    BconfirmUpdate.Enabled = false;
                    BShowData.Visible = false;
                    BShowData.Enabled = false;
                    DGVShowTables.Visible = false;
                    DGVShowTables.Enabled = false;
                    bool done = false;
                    int x = e.RowIndex;
                    ucAddOfferOverShowfromTables.Visible = true;
                    ucAddOfferOverShowfromTables.Enabled = true;
                                      ucAddOfferOverShowfromTables.CurrMovieShow = new MovieShow(int.Parse((table.Rows[x].ItemArray[1]).ToString()),
                        Convert.ToDateTime((table.Rows[x].ItemArray[2]).ToString()),
                        TimeSpan.Parse((table.Rows[x].ItemArray[3]).ToString()),
                        int.Parse((table.Rows[x].ItemArray[4]).ToString()),
                        double.Parse((table.Rows[x].ItemArray[6]).ToString()));
                    //this.Visible = false;
                    //this.Enabled = false;
                    ucAddOfferOverShowfromTables.MovieName = (table.Rows[x].ItemArray[0]).ToString();
                    ucAddOfferOverShowfromTables.AddValues();
                    //done = ucAddOfferOverShowfromTables.Done;

                }
            }
        }

        private void BShowData_Click(object sender, EventArgs e)
        {
            showData();
        }
    }
}