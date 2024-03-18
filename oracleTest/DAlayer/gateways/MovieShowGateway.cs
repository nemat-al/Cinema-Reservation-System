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
    class MovieShowGateway
    {
        //OracleConnection con;
        public MovieShowGateway()
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
        /*  the function return  movieName ,movieCategory,  showId ,  showDate ,  showTime, m showPoints
    , availableSeats, addedPrice, num_notConfirmed, hallId*/

        public DataTable selectAllMovieShowAfterToday(DateTime nowDate)
        {
            OracleDbType retType = OracleDbType.RefCursor;
            string funcName = "All_MovieShows";
            OracleConnection conn = ConnectionBuilder.GetConnection();
            List<string> para = new List<string>();
            para.Add("now_date");
            // Function Arguments values
            List<object> procValues = new List<object>();
            procValues.Add(nowDate);

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
        //return the movieshows for a certain movie
        public DataTable selectMovieShowByMovieName(string movieName, DateTime nowDate)
        {
            OracleDbType retType = OracleDbType.RefCursor;
            string funcName = "showsForOneMovie";
            OracleConnection conn = ConnectionBuilder.GetConnection();
            List<string> para = new List<string>();
            para.Add("movieName");
            para.Add("nowDate");
            // Function Arguments values
            List<object> procValues = new List<object>();
            procValues.Add(movieName);
            procValues.Add(nowDate);

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
        public void addMovieShow(MovieShow currMovieShow)
        {
            string procName = "add_movieShow";
            // Connect to DB
            OracleConnection conn = ConnectionBuilder.GetConnection();
            // Function Arguments
            List<string> para = new List<string>();
            para.Add("sDate");
            para.Add("sTime");
            para.Add("shPo");
            para.Add("sAddPr");
            para.Add("movId");
            para.Add("sHallId");
            // Function Arguments values
            List<object> procValues = new List<object>();
            procValues.Add(currMovieShow.Date);
            procValues.Add(currMovieShow.Time);
            procValues.Add(currMovieShow.Points);
            procValues.Add(currMovieShow.SeatsAddedPrice);
            procValues.Add(currMovieShow.MovieId);
            procValues.Add(currMovieShow.HallId);

            //execute
            QueryBuilder.procedureCall(conn, procName, para, procValues);
            ConnectionBuilder.PutConnection(conn);

        }
        public void updateMovieShow(MovieShow currMovieShow)
        {
            string procName = "Update_MovieShows";
            // Connect to DB
            OracleConnection conn = ConnectionBuilder.GetConnection();
            // Function Arguments
            List<string> para = new List<string>();
            para.Add("sIdu");
            para.Add("sDate");
            para.Add("sTime");
            para.Add("shPo");
            para.Add("sAddPr");

            // Function Arguments values
            List<object> procValues = new List<object>();

            procValues.Add(currMovieShow.Id);
            procValues.Add(currMovieShow.Date);
            procValues.Add(currMovieShow.Time);
            procValues.Add(currMovieShow.Points);
            procValues.Add(currMovieShow.SeatsAddedPrice);


            //execute
            QueryBuilder.procedureCall(conn, procName, para, procValues);
            ConnectionBuilder.PutConnection(conn);

        }

        public void deleteMovieShow(MovieShow currMovieShow)
        {

        }
        public DataTable AllOfferOverCategory(int curr_show_id)
        {
            OracleDbType retType = OracleDbType.RefCursor;
            string funcName = "ALLOFFEROVERCATEGORY";
            OracleConnection conn = ConnectionBuilder.GetConnection();
            List<string> para = new List<string>();
            para.Add("current_show_id");
            // Function Arguments values
            List<object> procValues = new List<object>();
            procValues.Add(curr_show_id);

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
        public DataTable AllOfferOverShow(int curr_show_id, int curr_cus_id)
        {
            OracleDbType retType = OracleDbType.RefCursor;
            string funcName = "ALLOFFEROVERSHOW";
            OracleConnection conn = ConnectionBuilder.GetConnection();
            List<string> para = new List<string>();
            para.Add("current_show_id");
            para.Add("curr_customer_id");
            // Function Arguments values
            List<object> procValues = new List<object>();
            procValues.Add(curr_show_id);
            procValues.Add(curr_cus_id);
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
        public int decreaseAvailableSeats(int showId)
        {
            OracleDbType retType = OracleDbType.Int32;
            string funcName = "decrease_availableSeats";
            // Connect to DB
            OracleConnection conn = ConnectionBuilder.GetConnection();
            List<string> para = new List<string>();
            para.Add("show_id");
            // Function Arguments values
            List<object> procValues = new List<object>();
            procValues.Add(showId);

            //execute
            int result = int.Parse(QueryBuilder.functionCall(conn, funcName, retType, para, procValues).ToString());

            ConnectionBuilder.PutConnection(conn);
            return result;
        }
        public int num_notConfirmed(int movieShow_id)
        {
            OracleDbType retType = OracleDbType.Int32;
            string funcName = "num_Tickets_Phone_Emp";
            OracleConnection conn = ConnectionBuilder.GetConnection();
            List<string> para = new List<string>();
            para.Add("curr_show_id");
            // Function Arguments values
            List<object> procValues = new List<object>();
            procValues.Add(movieShow_id);
            //execute
            int result = int.Parse(QueryBuilder.functionCall(conn, funcName, retType, para, procValues).ToString());
            ConnectionBuilder.PutConnection(conn);
            return result;
        }
        public DataTable unConfTickShow(int curr_show_id)
        {
            OracleDbType retType = OracleDbType.RefCursor;
            string funcName = "movieShow_notConfirmed";
            OracleConnection conn = ConnectionBuilder.GetConnection();
            List<string> para = new List<string>();
            para.Add("curr_show_id");
            // Function Arguments values
            List<object> procValues = new List<object>();
            procValues.Add(curr_show_id);
            //execute
            Oracle.DataAccess.Types.OracleRefCursor result = (Oracle.DataAccess.Types.OracleRefCursor)QueryBuilder.functionCall(conn, funcName, retType, para, procValues);
            //if (!(result.IsNull))

            OracleDataReader rdr = result.GetDataReader();
            DataTable table = new DataTable();
            table.Load(rdr);
            ConnectionBuilder.PutConnection(conn);
            return table;

        }

    }
}