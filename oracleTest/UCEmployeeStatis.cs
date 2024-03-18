using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oracleTest
{
    public partial class UCEmployeeStatis : UserControl
    {
        EmployeeGateWay empGateWay=new EmployeeGateWay();
        Employee certainEmployee;
        DataTable table;
        public UCEmployeeStatis()
        {
            InitializeComponent();
        }

        public Employee CertainEmployee
        {
            get
            {
                return certainEmployee;
            }

            set
            {
                certainEmployee = value;
            }
        }
        public void showData()
        {
            table = empGateWay.allTickManagedBy(CertainEmployee.Id);
            TB_EmployeeId.Text = CertainEmployee.Id.ToString();
        //    TBEmpName.Text = empGateWay.employeeById;
            dataGridView1.DataSource = table;
        }

        private void filterButtom_Click(object sender, EventArgs e)
        {
            string type = "";
            DateTime StartDate = startDatePicker.Value.Date;
            DateTime EndDate = endDatePicker.Value.Date;
            if (EndDate > StartDate)
            {
                int empId = Int32.Parse(TB_EmployeeId.Text);
                table = empGateWay.allTickManagedBy(empId);
                int tableRowCount = table.Rows.Count;
                int tempIndex = 0;
                if (RBOverPhone.Checked)
                    type = "OverPhone";
                else if (RBpayedBy.Checked)
                    type = "Payement";
                else if (RBreservedBy.Checked)
                    type = "Reservation";

                if (type == "")
                    for (int i = 0; i < tableRowCount; i++)
                    {
                        if ((!((DateTime)(table.Rows[tempIndex].ItemArray[6]) > StartDate &&
                            (DateTime)(table.Rows[tempIndex].ItemArray[6]) < EndDate)) || (Int32.Parse(table.Rows[tempIndex].ItemArray[0].ToString()) != empId))
                        {
                            table.Rows.Remove(table.Rows[tempIndex]); tempIndex--;
                        }
                        tempIndex++;
                    }
                else
                    for (int i = 0; i < tableRowCount; i++)
                    {
                        string temp = table.Rows[tempIndex].ItemArray[1].ToString();
                        bool b = string.Equals(temp, type);
                        if ((!((DateTime)(table.Rows[tempIndex].ItemArray[6]) > StartDate &&
                            (DateTime)(table.Rows[tempIndex].ItemArray[6]) < EndDate))
                            || (Int32.Parse(table.Rows[tempIndex].ItemArray[0].ToString()) != empId)
                            || (!b))
                        {
                            table.Rows.Remove(table.Rows[tempIndex]); tempIndex--;
                        }
                        tempIndex++;
                    }
                dataGridView1.DataSource = table;
            }
            else
                MessageBox.Show("Start date must be earlier than the end date :)");
        }
    }
}
