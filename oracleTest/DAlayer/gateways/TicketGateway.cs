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
    class TicketGateway
    {
       // OracleConnection con;
        public TicketGateway()
        {
           // this.Con = temCon;
        }

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
        public DataTable selectAllTicket()
        {
            OracleDbType retType = OracleDbType.RefCursor;
            
            string funcName = "All_Tickets";
            OracleConnection conn = ConnectionBuilder.GetConnection();

            //execute
            Oracle.DataAccess.Types.OracleRefCursor result = (Oracle.DataAccess.Types.OracleRefCursor)QueryBuilder.functionCall(conn, funcName, retType, null, null);
            //if (!(result.IsNull))
            {
                OracleDataReader rdr = result.GetDataReader();
                DataTable table = new DataTable();
                table.Load(rdr);
                ConnectionBuilder.PutConnection(conn);
                return table;
            }
            ConnectionBuilder.PutConnection(conn); return null;
        }
        // this func return table that containes : 
        //Ticket_Id , customerId,  Customer_Name,  Movie_name,  Movie_Show_Date,
        // Movie_Show_Time, hall_id, status,  seatId

        public DataTable ticketById(int temId)
        {
            OracleDbType retType = OracleDbType.RefCursor;
            string funcName = "certainTicket";
            OracleConnection conn = ConnectionBuilder.GetConnection();
            List<string> para = new List<string>();
            para.Add("tic_id");
            // Function Arguments values
            List<object> procValues = new List<object>();
            procValues.Add(temId);
            //execute
            Oracle.DataAccess.Types.OracleRefCursor result = (Oracle.DataAccess.Types.OracleRefCursor)QueryBuilder.functionCall(conn, funcName, retType, para, procValues);
            if ( result!=null)
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
        public DataTable ticketByName(string fname, string lname)
        {
            OracleDbType retType = OracleDbType.RefCursor;
            string funcName = "customerTickets";
            OracleConnection conn = ConnectionBuilder.GetConnection();
            List<string> para = new List<string>();
            para.Add("fname");
            para.Add("lname");
            // Function Arguments values
            List<object> procValues = new List<object>();
            procValues.Add(fname);
            procValues.Add(lname);
            //execute
            Oracle.DataAccess.Types.OracleRefCursor result = (Oracle.DataAccess.Types.OracleRefCursor)QueryBuilder.functionCall(conn, funcName, retType, para, procValues);
            if (result != null)
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
        public void addTicket(Ticket currTic)
        {
            string procName = "add_Ticket";
            // Connect to DB
            OracleConnection conn = ConnectionBuilder.GetConnection();
            // Function Arguments
            //Customer maha = new Customer(0, "Maha", "Qarqout", "0938045442", "mahaQ@gmail.com", 0);
            List<string> para = new List<string>();
            para.Add("st");
            para.Add("wReserved");
            para.Add("dreserved");
            para.Add("dpayed");
            para.Add("cId");
            para.Add("seatId");

            para.Add("rowsId");
            para.Add("showId");
            para.Add("empPh");
            para.Add("empRE");
            para.Add("empPa");
            para.Add("off_id");
            // Function Arguments values
            List<object> procValues = new List<object>();
            procValues.Add(currTic.State);
            procValues.Add(currTic.WayReserved);
            procValues.Add(currTic.DateReserved);
            procValues.Add(currTic.DatePayed);
            procValues.Add(currTic.Customer_id);
            procValues.Add(currTic.Seat_id);
            procValues.Add(currTic.MovieShow_id);
            procValues.Add(currTic.Employee_Phone);
            procValues.Add(currTic.Employee_Reserve);
            procValues.Add(currTic.Employee_Pay);
            procValues.Add(currTic.Row_id);
            procValues.Add(currTic.Price);
            //execute
            QueryBuilder.procedureCall(conn, procName, para, procValues);
            ConnectionBuilder.PutConnection(conn);

        }
        public int addTicket_func(Ticket currTic)
        {
            OracleDbType retType = OracleDbType.Int32;
            string funcName = "add_Ticket_func";
            // Connect to DB
            OracleConnection conn = ConnectionBuilder.GetConnection();
            // Function Arguments
            //Customer maha = new Customer(0, "Maha", "Qarqout", "0938045442", "mahaQ@gmail.com", 0);
            List<string> para = new List<string>();
            para.Add("st");
            para.Add("wReserved");
            para.Add("dreserved");
            para.Add("dpayed");
            para.Add("cId");
            para.Add("seatId");
            para.Add("rowsId");
            para.Add("showId");
            para.Add("empPh");
            para.Add("empRE");
            para.Add("empPa");
            para.Add("off_id");
            // Function Arguments values
            List<object> procValues = new List<object>();
            procValues.Add(currTic.State);
            procValues.Add(currTic.WayReserved);
            procValues.Add(currTic.DateReserved);
            procValues.Add(currTic.DatePayed);
            procValues.Add(currTic.Customer_id);
            procValues.Add(currTic.Seat_id);
            procValues.Add(currTic.Row_id);
            procValues.Add(currTic.MovieShow_id);
            procValues.Add(currTic.Employee_Phone);
            procValues.Add(currTic.Employee_Reserve);
            procValues.Add(currTic.Employee_Pay);
            procValues.Add(currTic.Price);
            //execute
            int result = int.Parse(QueryBuilder.functionCall(conn, funcName, retType, para, procValues).ToString());

            ConnectionBuilder.PutConnection(conn);
            return result;
        }
        public void UpdateTicket(Ticket currTic)
        {

        }
        public void cancelTicket(int currTicId)
        {
            string procName = "cancel_Ticket";
            // Connect to DB
            OracleConnection conn = ConnectionBuilder.GetConnection();
            List<string> para = new List<string>();
            para.Add("tic_id"); 
            // Function Arguments values
            List<object> procValues = new List<object>();
            procValues.Add(currTicId);
            //execute
            QueryBuilder.procedureCall(conn, procName, para, procValues);
            ConnectionBuilder.PutConnection(conn);
        }
        public int confirmTicket(int currTicId, int currEmp, DateTime date)
        {
            OracleDbType retType = OracleDbType.Int32;
            string funcName = "update_pay_ticket";
            // Connect to DB
            OracleConnection conn = ConnectionBuilder.GetConnection();
            // Function Arguments
            //Customer maha = new Customer(0, "Maha", "Qarqout", "0938045442", "mahaQ@gmail.com", 0);
            List<string> para = new List<string>();
            para.Add("tic_id");
            para.Add("emp_pay");
            para.Add("date_pay");
            // Function Arguments values
            List<object> procValues = new List<object>();
            procValues.Add(currTicId);
            procValues.Add(currEmp);
            procValues.Add(date);
            //execute
            int result = int.Parse(QueryBuilder.functionCall(conn, funcName, retType, para, procValues).ToString());

            ConnectionBuilder.PutConnection(conn);
            return result;
        }
        //    public void insert(Ticket temTicket)
        //    {
        //        //Con.Open();
        //        try
        //        {
        //            // Insert statement.
        //            string sql = "Insert into TICKET (price, state, wayReserved, dateReserved, dateCancelled, datePayed,customer_id,takenSeat_Seat_id, movieShow_id,employee_Phone,employee_Reserve,employee_Cancel,employee_Pay) "
        //                 + " values (@price, @state, @wayReserved, @dateReserved, @dateCancelled, @datePayed, @customer_id, @takenSeat_Seat_id, @movieShow_id, @employee_Phone, @employee_Reserve, @employee_Cancel, @employee_Pay) ";

        //            OracleCommand cmd = con.CreateCommand();
        //            cmd.CommandText = sql;

        //            // Create Parameter.
        //            OracleParameter priceParam = new OracleParameter("@price", SqlDbType.Money);
        //            priceParam.Value = currentTicket.Price;
        //            cmd.Parameters.Add(priceParam);


        //            OracleParameter stateParam = new OracleParameter("@state", SqlDbType.VarChar);
        //            stateParam.Value = currentTicket.State;
        //            cmd.Parameters.Add(stateParam);

        //            OracleParameter wayR = new OracleParameter("@wayReserved", SqlDbType.VarChar);
        //            wayR.Value = currentTicket.State;
        //            cmd.Parameters.Add(wayR);

        //            OracleParameter dateRParam = new OracleParameter("@dateReserved", SqlDbType.Date);
        //            dateRParam.Value = currentTicket.DateReserved;
        //            cmd.Parameters.Add(dateRParam);

        //            OracleParameter datePParam = new OracleParameter("@datePayed", SqlDbType.Date);
        //            datePParam.Value = currentTicket.DatePayed;
        //            cmd.Parameters.Add(datePParam);

        //            OracleParameter dateCParam = new OracleParameter("@dateCancelled", SqlDbType.Date);
        //            dateCParam.Value = currentTicket.DateCancelled;
        //            cmd.Parameters.Add(dateCParam);

        //            OracleParameter CusParam = new OracleParameter("@customer_id", SqlDbType.Int);
        //            CusParam.Value = currentTicket.Customer_id;
        //            cmd.Parameters.Add(CusParam);

        //            OracleParameter SeatParam = new OracleParameter("@takenSeat_Seat_id", SqlDbType.Int);
        //            SeatParam.Value = currentTicket.TakenSeat_Seat_id;
        //            cmd.Parameters.Add(SeatParam);

        //            OracleParameter MovParam = new OracleParameter("@movieShow_id", SqlDbType.Int);
        //            MovParam.Value = currentTicket.MovieShow_id;
        //            cmd.Parameters.Add(MovParam);

        //            OracleParameter EmpParam = new OracleParameter("@employee_Phone", SqlDbType.Int);
        //            EmpParam.Value = currentTicket.Employee_Phone;
        //            cmd.Parameters.Add(EmpParam);

        //            OracleParameter EmpRParam = new OracleParameter("@employee_Reserve", SqlDbType.Int);
        //            EmpRParam.Value = currentTicket.Employee_Reserve;
        //            cmd.Parameters.Add(EmpRParam);

        //            OracleParameter EmpCParam = new OracleParameter("@employee_Cancel", SqlDbType.Int);
        //            EmpCParam.Value = currentTicket.Employee_Cancel;
        //            cmd.Parameters.Add(EmpCParam);

        //            OracleParameter EmpPParam = new OracleParameter("@employee_Pay", SqlDbType.Int);
        //            EmpPParam.Value = currentTicket.Employee_Pay;
        //            cmd.Parameters.Add(EmpPParam);

        //            // Execute Command (for Delete,Insert or Update).
        //            int rowCount = cmd.ExecuteNonQuery();

        //            Console.WriteLine("Row Count affected = " + rowCount);
        //        }
        //        catch (Exception e)
        //        {
        //            Console.WriteLine("Error: " + e);
        //            Console.WriteLine(e.StackTrace);
        //        }
        //        //finally
        //        //{
        //        //    con.Close();
        //        //    con.Dispose();
        //        //    con = null;
        //        //}
        //        Console.Read();
        //    }


        //public void Update(Ticket temTicket)
        //{
        //    //Con.Open();
        //    try
        //    {
        //            string sql = "Update TICKET set State = @state where ID = @ticId ";
        //            OracleCommand cmd = con.CreateCommand();
        //            cmd.CommandText = sql;

        //            OracleParameter stateParam = new OracleParameter("@state", SqlDbType.Int);
        //            stateParam.Value = currentTicket.State;
        //            cmd.Parameters.Add(stateParam);

        //            OracleParameter EmpPParam = new OracleParameter("@ticId", SqlDbType.Int);
        //            EmpPParam.Value = currentTicket.Employee_Pay;
        //            cmd.Parameters.Add(EmpPParam);
        //        }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine("Error: " + e);
        //        Console.WriteLine(e.StackTrace);
        //    }
        //    //finally
        //    //{
        //    //    con.Close();
        //    //    con.Dispose();
        //    //    con = null;
        //    //}
        //    Console.Read();
        //}
    }
}