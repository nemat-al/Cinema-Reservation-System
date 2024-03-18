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
    class EmployeeGateWay
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

       // public EmployeeGateWay(OracleConnection temCon)
            public EmployeeGateWay()
        {
         //   this.Con = temCon;
        }

        //public DataTable selectAllEmployee()
        //{
        //    DataSet ds = new DataSet();
        //    OracleDataAdapter ad = new OracleDataAdapter();
        //    ad = new OracleDataAdapter("select * from EMPLOYEE", Con);
        //    ad.Fill(ds);
        //    return ds.Tables[0];

        //}
        public void insertEmployee(Employee temEmployee)
        {

        }
        public void deleteEmployee(Employee temEmployee)
        {

        }
        public Employee employeeByUsername(string uname)
        {

            OracleDbType retType = OracleDbType.RefCursor;
            string funcName = "getEmpByUserName";
            OracleConnection conn = ConnectionBuilder.GetConnection();
            List<string> para = new List<string>();
            para.Add("currUserName");
            // Function Arguments values
            List<object> procValues = new List<object>();
            procValues.Add(uname);
            //execute
            Oracle.DataAccess.Types.OracleRefCursor result = (Oracle.DataAccess.Types.OracleRefCursor)QueryBuilder.functionCall(conn, funcName, retType, para, procValues);
            if ((result != null))
            {

                OracleDataReader rdr = result.GetDataReader();
                DataTable table = new DataTable();
                table.Load(rdr);
                /*
                new Ticket(0, 0, status, tempwayreserved, dateReserved, DateTime.Now, PayedTime, tempadded.Id, ShowId, emp.Id, emp.Id, emp.Id, emp.Id, 1,seat);
                
                */
                Employee currEmployee = new Employee(Int32.Parse((table.Rows[0].ItemArray[0]).ToString()),
                    table.Rows[0].ItemArray[1].ToString(), table.Rows[0].ItemArray[2].ToString(), table.Rows[0].ItemArray[3].ToString(), table.Rows[0].ItemArray[4].ToString(), table.Rows[0].ItemArray[5].ToString(), table.Rows[0].ItemArray[6].ToString(), table.Rows[0].ItemArray[7].ToString(), table.Rows[0].ItemArray[8].ToString());
                ConnectionBuilder.PutConnection(conn);
                return currEmployee;
            }
            else
            {
                ConnectionBuilder.PutConnection(conn);
                return null;
            }
        }
        public Employee checkUnamePass(string currUsername, string currPassword, string currEmployeeRole)
        {
            string funcName = "find_emp";
            List<string> para = new List<string>();
            para.Add("uname");
            para.Add("pass");
            para.Add("rol");
            // Function Arguments values
            List<object> procValues = new List<object>();
            procValues.Add(currUsername);
            procValues.Add(currPassword);
            procValues.Add(currEmployeeRole);
            OracleDbType retType = OracleDbType.RefCursor;
            OracleConnection conn = ConnectionBuilder.GetConnection();
            //execute
            Oracle.DataAccess.Types.OracleRefCursor result = (Oracle.DataAccess.Types.OracleRefCursor)QueryBuilder.functionCall(conn, funcName, retType, para, procValues);

            OracleDataReader rdr = result.GetDataReader();
            DataTable table = new DataTable();
            table.Load(rdr);
            if (table.Rows.Count > 0)
            {

                Employee currEmployee = new Employee(Int32.Parse((table.Rows[0].ItemArray[0]).ToString()),
                    table.Rows[0].ItemArray[1].ToString(), table.Rows[0].ItemArray[2].ToString(), table.Rows[0].ItemArray[3].ToString(), table.Rows[0].ItemArray[4].ToString(), table.Rows[0].ItemArray[5].ToString(), table.Rows[0].ItemArray[6].ToString(), table.Rows[0].ItemArray[7].ToString(), table.Rows[0].ItemArray[8].ToString());
                ConnectionBuilder.PutConnection(conn);
                return currEmployee;
            }
            else { ConnectionBuilder.PutConnection(conn); return null; }

        }

        public DataTable allWorkForEmployees()
        {
            OracleDbType retType = OracleDbType.RefCursor;
            string funcName = "employees_work";
            OracleConnection conn = ConnectionBuilder.GetConnection();
            Oracle.DataAccess.Types.OracleRefCursor result = (Oracle.DataAccess.Types.OracleRefCursor)QueryBuilder.functionCall(conn, funcName, retType, null, null);

            if (result!=null)
            {
                OracleDataReader rdr = result.GetDataReader();
                DataTable table = new DataTable();
                table.Load(rdr);
                ConnectionBuilder.PutConnection(conn);
                return table;
            }
            ConnectionBuilder.PutConnection(conn);
            return null;
        }
        public int numOfTickManagedBy(Employee tempEmployee)
        {
            OracleDbType retType = OracleDbType.Int32;
            //OracleDbType retType = OracleDbType.RefCursor;
            string funcName = "all_Tickets_Emp";
            OracleConnection conn = ConnectionBuilder.GetConnection();
            List<string> para = new List<string>();
            para.Add("emp_id");
            // Function Arguments values
            List<object> procValues = new List<object>();
            procValues.Add(tempEmployee.Id);
            //execute
            int result = int.Parse(QueryBuilder.functionCall(conn, funcName, retType, para, procValues).ToString());
            ConnectionBuilder.PutConnection(conn);
            return result;
        }
        public int numOfPhoneTicketManagedBy(Employee tempEmployee)
        {
            OracleDbType retType = OracleDbType.Int32;
            string funcName = "num_Tickets_Phone_Emp";
            OracleConnection conn = ConnectionBuilder.GetConnection();
            List<string> para = new List<string>();
            para.Add("emp_id");
            // Function Arguments values
            List<object> procValues = new List<object>();
            procValues.Add(tempEmployee.Id);
            //execute
            int result = int.Parse(QueryBuilder.functionCall(conn, funcName, retType, para, procValues).ToString());
            ConnectionBuilder.PutConnection(conn);
            return result;
        }
        public int numOfPayingTickManagedBy(Employee tempEmployee)
        {

            OracleDbType retType = OracleDbType.Int32;
            string funcName = "num_Tickets_Pay_Emp";
            OracleConnection conn = ConnectionBuilder.GetConnection();
            List<string> para = new List<string>();
            para.Add("emp_id");
            // Function Arguments values
            List<object> procValues = new List<object>();
            procValues.Add(tempEmployee.Id);
            //execute
            int result = int.Parse(QueryBuilder.functionCall(conn, funcName, retType, para, procValues).ToString());
            ConnectionBuilder.PutConnection(conn);
            return result;
        }
        public int numOfReservedTickManagedBy(Employee tempEmployee)
        {

            OracleDbType retType = OracleDbType.Int32;
            string funcName = "num_Tickets_Reserved_Emp";
            OracleConnection conn = ConnectionBuilder.GetConnection();
            List<string> para = new List<string>();
            para.Add("emp_id");
            // Function Arguments values
            List<object> procValues = new List<object>();
            procValues.Add(tempEmployee.Id);
            //execute
            int result = int.Parse(QueryBuilder.functionCall(conn, funcName, retType, para, procValues).ToString());
            ConnectionBuilder.PutConnection(conn);
            return result;
        }
        public int numOfCanceledTickManagedBy(Employee tempEmployee)
        {
            OracleDbType retType = OracleDbType.Int32;
            string funcName = "num_Tickets_Canceled_By_Emp";
            OracleConnection conn = ConnectionBuilder.GetConnection();
            List<string> para = new List<string>();
            para.Add("emp_id");
            // Function Arguments values
            List<object> procValues = new List<object>();
            procValues.Add(tempEmployee.Id);
            //execute
            int result = int.Parse(QueryBuilder.functionCall(conn, funcName, retType, para, procValues).ToString());
            ConnectionBuilder.PutConnection(conn);
            return result;
        }
        // return the number of whole operations
        public DataTable numOfAllTicketManagedBy(Employee tempEmployee)
        {
            int nReserve = numOfReservedTickManagedBy(tempEmployee);
            int nPay = numOfPayingTickManagedBy(tempEmployee);
            int nPhone = numOfPhoneTicketManagedBy(tempEmployee);
            int nCan = numOfCanceledTickManagedBy(tempEmployee);
            int all = nCan + nReserve + nPhone + nPay;
            DataTable table = new DataTable();
            table.Columns.Add("OperationType", typeof(String));
            table.Columns.Add("NumberOfManagedTickets", typeof(int));

            table.Rows.Add("AllTickets", all);
            table.Rows.Add("ReservedTickets", nReserve);
            table.Rows.Add("PayedTickets", nPay);
            table.Rows.Add("PhoneTickets", nPhone);
            table.Rows.Add("CancelTickets", nCan);
            return table;
        }
        public DataTable reservedTickManagedBy(int tempEmployee)
        {
            OracleDbType retType = OracleDbType.RefCursor;
            string funcName = "Tickets_Reserved_Emp";
            OracleConnection conn = ConnectionBuilder.GetConnection();
            List<string> para = new List<string>();
            para.Add("emp_id");
            // Function Arguments values
            List<object> procValues = new List<object>();
            procValues.Add(tempEmployee);
            //execute
            Oracle.DataAccess.Types.OracleRefCursor result = (Oracle.DataAccess.Types.OracleRefCursor)QueryBuilder.functionCall(conn, funcName, retType, para, procValues);
            
            //if (!(result.IsNull))
            {
                OracleDataReader rdr = result.GetDataReader();
                DataTable table = new DataTable();
                table.Load(rdr);
                ConnectionBuilder.PutConnection(conn);
                return table;
            }
            ConnectionBuilder.PutConnection(conn);
            return null;
        }
        public DataTable payedTickManagedBy(int tempEmployee)
        {
            OracleDbType retType = OracleDbType.RefCursor;
            string funcName = "Tickets_Pay_Emp";
            OracleConnection conn = ConnectionBuilder.GetConnection();
            List<string> para = new List<string>();
            para.Add("emp_id");
            // Function Arguments values
            List<object> procValues = new List<object>();
            procValues.Add(tempEmployee);
            //execute
            Oracle.DataAccess.Types.OracleRefCursor result = (Oracle.DataAccess.Types.OracleRefCursor)QueryBuilder.functionCall(conn, funcName, retType, para, procValues);
           
            if (!(result.IsNull))
            {
                OracleDataReader rdr = result.GetDataReader();
                DataTable table = new DataTable();
                table.Load(rdr);
                ConnectionBuilder.PutConnection(conn);
                return table;
            }
            ConnectionBuilder.PutConnection(conn);
            return null;
        }

        public DataTable PhoneTickManagedBy(int tempEmployee)
        {

            OracleDbType retType = OracleDbType.RefCursor;
            string funcName = "Tickets_Reserved_Emp_Phone";
            OracleConnection conn = ConnectionBuilder.GetConnection();
            List<string> para = new List<string>();
            para.Add("emp_id");
            // Function Arguments values
            List<object> procValues = new List<object>();
            procValues.Add(tempEmployee);
            //execute
            Oracle.DataAccess.Types.OracleRefCursor result = (Oracle.DataAccess.Types.OracleRefCursor)QueryBuilder.functionCall(conn, funcName, retType, para, procValues);
          
            if (!(result.IsNull))
            {
                OracleDataReader rdr = result.GetDataReader();
                DataTable table = new DataTable();
                table.Load(rdr);
                ConnectionBuilder.PutConnection(conn);
                return table;
            }
            ConnectionBuilder.PutConnection(conn);
            return null;
        }
        public DataTable canceledTickManagedBy(int tempEmployee)
        {
            OracleDbType retType = OracleDbType.RefCursor;
            string funcName = "Tickets_Canceled_By_Employee";
            OracleConnection conn = ConnectionBuilder.GetConnection();
            List<string> para = new List<string>();
            para.Add("emp_id");
            // Function Arguments values
            List<object> procValues = new List<object>();
            procValues.Add(tempEmployee);
            //execute
            Oracle.DataAccess.Types.OracleRefCursor result = (Oracle.DataAccess.Types.OracleRefCursor)QueryBuilder.functionCall(conn, funcName, retType, para, procValues);
            if (!(result.IsNull))
            {
                OracleDataReader rdr = result.GetDataReader();
                DataTable table = new DataTable();
                table.Load(rdr);
                ConnectionBuilder.PutConnection(conn);
                return table;
            }
            ConnectionBuilder.PutConnection(conn);
            return null;
        }
        public DataTable allTickManagedBy(int tempEmployee)
        {
            DataTable reservTable = reservedTickManagedBy(tempEmployee);
            DataTable payTable = payedTickManagedBy(tempEmployee);
            DataTable phoneTable = PhoneTickManagedBy(tempEmployee);
            DataTable allTic=new DataTable();
            if (reservTable != null)
                allTic.Merge(reservTable);
            if (payTable != null)
                allTic.Merge(payTable);
            if (phoneTable != null)
                allTic.Merge(phoneTable);

            return allTic;
        }
    }

}