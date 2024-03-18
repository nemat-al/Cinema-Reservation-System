using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess;
namespace oracleTest
{
    public partial class FWelcome : Form
    {
        string userName="love";
        string pass = "love";
        string sid="xe";
        bool isConnected = false;
        public OracleConnection Con { get; private set; }

        public FWelcome()
        {
            InitializeComponent();
            isConnected = false;
        }

        

        private bool Connect()
        {
            string exceptionMessage = "";
            bool state = ConnectionBuilder.InitializeConnection(userName, pass, sid, exceptionMessage);
            if (state)
            {
                //MessageBox.Show("Connected Succeessfully");
                return true;
            }
            else
            {
                //MessageBox.Show("Error :" + exceptionMessage);
                return false;
            }


        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            Movie ne = new Movie(1, "inception", 120, 2014, "good");
            MovieGateWay te = new MovieGateWay();

            // te.insert(ne);
        }

        private void Blogin_Click(object sender, EventArgs e)
        {
            //if (!isConnected)
            //{
            //    if (Connect())
            //    {
            //        // panel2.Enabled = true;
            //        isConnected = true;

            //        panel2.Enabled = true;
            //    }
            //}
            //else
            //{
            //    ConnectionBuilder.PutConnection(ConnectionBuilder.GetConnection());
            //    ConnectBtn.Text = "Connect";
            //    isConnected = false;
            //    panel2.Enabled = false;
            //}
            

            string user = tBUserName.Text;
            string pass = tBPassword.Text;
            string rol = " ";
            if (rBManager.Checked)
                rol = "manager";
            else if (rBReceptionist.Checked)
                rol = "receptionist";
           
                if (Connect())
                {
                EmployeeGateWay egwc = new EmployeeGateWay();
                Employee r = egwc.checkUnamePass(user, pass, rol);
                if (r != null)
                {
                    if (rBManager.Checked)
                    {

                        forms.FManagement fman = new forms.FManagement(user);
                        this.Hide();
                        fman.ShowDialog();
                    }
                    else if (rBReceptionist.Checked)
                    {
                        forms.FReceptionist frec = new forms.FReceptionist(user,false);
                        this.Hide();
                        frec.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("please choose an option from management or receptiomist");
                    }
                }
                else { MessageBox.Show("Either username , password or role are not true"); }
            }
            else
                {
                    MessageBox.Show("There is a problem connecting to the database");
                }
            }
          
        ///////////////////////////////////////////////////////////////
        
      
        //private void getButton_Click(object sender, EventArgs e)
        //{
        //    DataSet ds = new DataSet();
        //    OracleDataAdapter ad = new OracleDataAdapter();
        //    if (cmbDataType.Text == "Employees")
        //    {

        //        OracleCommand cmd = new OracleCommand();
        //        cmd.Connection = con;
        //        cmd.CommandText = "getemps";
        //        cmd.CommandType = CommandType.StoredProcedure;

        //        cmd.Parameters.Add(new OracleParameter("p_cursor", OracleDbType.RefCursor, ParameterDirection.Output));

        //        cmd.ExecuteNonQuery();
        //        Oracle.DataAccess.Types.OracleRefCursor t =
        //            (Oracle.DataAccess.Types.OracleRefCursor)cmd.Parameters[0].Value;
        //        OracleDataReader rdr = t.GetDataReader();
        //        DataTable table = new DataTable();
        //        table.Load(rdr);

        //        dataGridView1.DataSource = table;

        //    }
        //    else if (cmbDataType.Text == "Departments")
        //    {
        //        ad = new OracleDataAdapter("select * from Departments", con);
        //        ad.Fill(ds);
        //        dataGridView1.DataSource = ds.Tables[0];
        //    }
        //}

        //private void insertBtn_Click(object sender, EventArgs e)
        //{
        //    OracleDataAdapter da = new OracleDataAdapter();
        //    OracleCommand cmd = new OracleCommand();
        //    cmd.Connection = con;
        //    cmd.CommandText = "INSERTTEACHER";
        //    cmd.CommandType = CommandType.StoredProcedure;

        //    cmd.Parameters.Add("TID", 10041);
        //    cmd.Parameters.Add("TFNAME", "عمار") ;
        //    cmd.Parameters.Add("TLNAME", "مخلوف");
        //    cmd.Parameters.Add("DEGREE", "");
        //    cmd.Parameters.Add("TPHONE", "");
        //    cmd.Parameters.Add("MAIL", "");
        //    cmd.Parameters.Add("MOBILE", "");
        //    cmd.Parameters.Add("NOTES", "");

        //    int rowsUpdated = cmd.ExecuteNonQuery();
        //    if (rowsUpdated == 0) 
        //     MessageBox.Show("Record not inserted"); 
        //    else 
        //     MessageBox.Show("Success!"); 
        //}

        //private void editBtn_Click(object sender, EventArgs e)
        //{

        //}

        //private void dataGridView1_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        //{

        //}
    }
}
