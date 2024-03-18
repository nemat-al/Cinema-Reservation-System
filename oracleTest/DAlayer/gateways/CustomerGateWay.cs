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
    class CustomerGateWay
    {
        //OracleConnection con;

        //public OracleConnection Con
        //{
        //    get
        //    {
        //        return con;
        //    }

        //    set
        //    {
        //        con = value;
        //    }
        //}

        //public CustomerGateWay(OracleConnection temCon)
        public CustomerGateWay()
        {
            //this.Con = temCon;
        }
        public DataTable selectAllCustomer()
        {
            DataSet ds = new DataSet();
            OracleDataAdapter ad = new OracleDataAdapter();
            ad = new OracleDataAdapter("select * from CUSTOMER", ConnectionBuilder.GetConnection());
            ConnectionBuilder.PutConnection(ConnectionBuilder.GetConnection());
            ad.Fill(ds);
            return ds.Tables[0];

        }
        public void addCustomer(Customer currCus)
        {
            string procName = "add_customer";
            // Connect to DB
            OracleConnection conn = ConnectionBuilder.GetConnection();
            // Function Arguments
            //Customer maha = new Customer(0, "Maha", "Qarqout", "0938045442", "mahaQ@gmail.com", 0);
            List<string> para = new List<string>();
            para.Add("fname");
            para.Add("lname");
            para.Add("pn");
            para.Add("ema");
            para.Add("po");

            // Function Arguments values
            List<object> procValues = new List<object>();
            procValues.Add(currCus.FirstName);
            procValues.Add(currCus.LastName);
            procValues.Add(currCus.PhoneNumber);
            procValues.Add(currCus.Email);
            procValues.Add(currCus.Points);

            //execute
            QueryBuilder.procedureCall(conn, procName, para, procValues);
            ConnectionBuilder.PutConnection(conn);

        }
        //return the customer if found , otherwise null
        public DataTable findCustomerInfo(string fname, string lname)
        {
            string funcName = "find_Customer";
            List<string> para = new List<string>();
            // Function Arguments
            para.Add("fname");
            para.Add("lname");
            // Function Arguments values
            List<object> procValues = new List<object>();
            procValues.Add(fname);
            procValues.Add(lname);
            //execute
            // Oracle.DataAccess.Types.OracleRefCursor result = (Oracle.DataAccess.Types.OracleRefCursor)QueryBuilder.procedureReturnVCall(conn, funcName, retType, para, procValues, "p_recordset");
            /// DataTable table = QueryBuilder.procedureReturnVCall(conn, funcName, retType, para, procValues, "p_recordset");
            OracleConnection conn = ConnectionBuilder.GetConnection();
            OracleDbType retType = OracleDbType.RefCursor;
            Oracle.DataAccess.Types.OracleRefCursor result = (Oracle.DataAccess.Types.OracleRefCursor)QueryBuilder.functionCall(conn, funcName, retType, para, procValues);
            OracleDataReader rdr = result.GetDataReader();
                DataTable table = new DataTable();
                table.Load(rdr);
              // if (table.Rows.Count > 0)
                {
                return table;
                ConnectionBuilder.PutConnection(conn);
            }
            
           // else
 { ConnectionBuilder.PutConnection(conn);  return null; }
            /////////////////////
            //    if (table!=null )
            //    {

            //        try
            //        {
            //            //OracleDataReader rdr= result.GetDataReader();
            //            //DataTable table = new DataTable();
            //            //table.Load(rdr);
            //            Customer currCustomer = new Customer(Int32.Parse((table.Rows[0].ItemArray[0]).ToString()),
            //                table.Rows[0].ItemArray[1].ToString(), table.Rows[0].ItemArray[2].ToString(), table.Rows[0].ItemArray[3].ToString(), table.Rows[0].ItemArray[4].ToString(), Int32.Parse(table.Rows[0].ItemArray[5].ToString()));
            //            ConnectionBuilder.PutConnection(conn);

            //            return currCustomer;
            //        }
            //        catch (Exception e)
            //        { ConnectionBuilder.PutConnection(conn);  return null; }
            //    }

            //    ConnectionBuilder.PutConnection(conn); return null;
         
        }

    }
}