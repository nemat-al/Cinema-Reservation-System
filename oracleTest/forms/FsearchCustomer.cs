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
    public partial class FsearchCustomer : Form
    {
        bool found = false;
        bool whereWasCalled = true;
        private CustomerGateWay custGateWay = new CustomerGateWay();
        private Customer foundCustomer;
        DataTable result=new DataTable();
        public Customer FoundCustomer
        {
            get
            {
                return foundCustomer;
            }

            set
            {
                foundCustomer = value;
            }
        }

        public bool WhereWasCalled
        {
            get
            {
                return whereWasCalled;
            }

            set
            {
                whereWasCalled = value;
            }
        }

        public FsearchCustomer()
        {
            InitializeComponent();
            ucPrintCustomerFromSearch.Visible = false;
            ucPrintCustomerFromSearch.Enabled = false;
        }

        private void DGVShowTables_CellClick_print_customer(object sender, DataGridViewCellEventArgs e)
        {
            
                if (e.ColumnIndex == customerGV.Columns["print_customer_but"].Index)
                {

                int x = e.RowIndex;
                
                 FoundCustomer = new Customer(Int32.Parse((result.Rows[x].ItemArray[0]).ToString()),
                             result.Rows[x].ItemArray[1].ToString(), result.Rows[x].ItemArray[2].ToString(), result.Rows[x].ItemArray[3].ToString(), result.Rows[x].ItemArray[4].ToString(), Int32.Parse(result.Rows[x].ItemArray[5].ToString()));


                customerGV.Visible = false;
                ucAddCustomerSearch.Visible = false;
                ucAddCustomerSearch.Enabled = false;
                panel1.Visible = false;
                ucPrintCustomerFromSearch.Visible = true;
                ucPrintCustomerFromSearch.Enabled = true;
                if (WhereWasCalled)
                {
                    ucPrintCustomerFromSearch.ToPrint = FoundCustomer;
                    ucPrintCustomerFromSearch.print();
                }
              

            }
            
        }
        private void BFind_Click(object sender, EventArgs e)
        {
            DataTable  table, table2;
            string name = TBFName.Text;
            string[] twoNames = name.Split(' ');
            if (twoNames.Count() > 2)
                MessageBox.Show("The name consists of only two individual names ");
            else if (twoNames.Count() == 2)
                result = custGateWay.findCustomerInfo(twoNames[0], twoNames[1]);
            else if (twoNames.Count() == 1)
            {
                table = custGateWay.findCustomerInfo(twoNames[0], "");
                table2 = custGateWay.findCustomerInfo("", twoNames[0]);
                if (table.Rows.Count > 0 && table2.Rows.Count > 0)
                {
                    result.Merge(table); result.Merge(table2);
                }
                else if (table.Rows.Count > 0)
                    result = table;
                else if (table2.Rows.Count > 0)
                    result = table2;
                else
                { result = null; }
            }
            if (result == null)
            {
                DialogResult dialogResult = MessageBox.Show("Sorry we couldn't find such Customer, do you want to add a Customer with this info?", "No Such Customer", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    customerGV.Visible = false;
                    ucAddCustomerSearch.Visible = true;
                    ucAddCustomerSearch.Enabled = true;
                    ucPrintCustomerFromSearch.Visible = false;
                    ucPrintCustomerFromSearch.Enabled = false;
                    // ucPrintCustomerSearch.Enabled = false;
                    //  ucPrintCustomerSearch.Visible = false;
                }
                else if (dialogResult == DialogResult.No)
                {
                    //return to search
                    customerGV.Visible = false;
                    ucAddCustomerSearch.Visible = false;
                    ucAddCustomerSearch.Enabled = false;
                    ucPrintCustomerFromSearch.Visible = false;
                    ucPrintCustomerFromSearch.Enabled = false;
                    //  ucPrintCustomerSearch.Enabled = false;
                    //  ucPrintCustomerSearch.Visible = false;
                }
            }
            else if (result.Rows.Count == 1)
            {
                 FoundCustomer = new Customer(Int32.Parse((result.Rows[0].ItemArray[0]).ToString()),
                             result.Rows[0].ItemArray[1].ToString(), result.Rows[0].ItemArray[2].ToString(), result.Rows[0].ItemArray[3].ToString(), result.Rows[0].ItemArray[4].ToString(), Int32.Parse(result.Rows[0].ItemArray[5].ToString()));


                customerGV.Visible = false;
                ucAddCustomerSearch.Visible = false;
                ucAddCustomerSearch.Enabled = false;
                panel1.Visible = false;
                ucPrintCustomerFromSearch.Visible = true;
                ucPrintCustomerFromSearch.Enabled = true;
                if (WhereWasCalled)
                {
                    ucPrintCustomerFromSearch.ToPrint = FoundCustomer;
                    ucPrintCustomerFromSearch.print();
                }

            }
            else if (result.Rows.Count > 1)
            {
                DataGridViewButtonColumn printCustomer;
                printCustomer = new DataGridViewButtonColumn();
                ////
                printCustomer.HeaderText = "print customer";
                printCustomer.Name = "print_customer_but";
                printCustomer.Text = "print customer";
                printCustomer.UseColumnTextForButtonValue = true;
                customerGV.Columns.Add(printCustomer);
                customerGV.CellClick += DGVShowTables_CellClick_print_customer;

                ////

                customerGV.DataSource = result;

                customerGV.Visible = true;
                ucAddCustomerSearch.Visible = false;
                ucAddCustomerSearch.Enabled = false;
                panel1.Visible = false;
                ucPrintCustomerFromSearch.Visible = false;
                ucPrintCustomerFromSearch.Enabled = false;
            }
            
        }

        private void BClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void ChangeVisible(bool enabled)
        {
            foreach (Control c in this.Controls)
            {
                c.Visible = false;
            }
        }

    }
}