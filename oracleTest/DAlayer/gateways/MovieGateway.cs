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
    class MovieGateWay
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

        // public MovieGateWay(OracleConnection temCon)
        public MovieGateWay()
        {
            //this.Con = temCon;
        }
        public DataTable selectAllMovie()
        {
            OracleDbType retType = OracleDbType.RefCursor;

            string funcName = "All_Movies";
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
        public void addMovie(Movie temMovie, string movieCategory)
        {
            string procName = "add_movie";
            // Connect to DB
            OracleConnection conn = ConnectionBuilder.GetConnection();
            // Function Arguments
            List<string> para = new List<string>();
            para.Add("mname");
            para.Add("dura");
            para.Add("myear");
            para.Add("descrip");
            para.Add("movieCate");
            
            List<object> procValues = new List<object>();
            procValues.Add(temMovie.Name);
            procValues.Add(temMovie.Duration);
            procValues.Add(temMovie.Year);
            procValues.Add(temMovie.Description);
            procValues.Add(movieCategory);

            //execute
            QueryBuilder.procedureCall(conn, procName, para, procValues);
            ConnectionBuilder.PutConnection(conn);

        }
        public void deleteMovie(Movie temMovie)
        {

        }
        public DataTable MovieMostSold(DateTime startDate, DateTime endDate)
        {
            /////////////////////////////
            OracleDbType retType = OracleDbType.RefCursor;
            string funcName = "Movie_Most_Selling_Tickets";
            OracleConnection conn = ConnectionBuilder.GetConnection();
            List<string> para = new List<string>();
            para.Add("startDate");
            para.Add("endDate");
            // Function Arguments values
            List<object> procValues = new List<object>();
            procValues.Add(startDate);
            procValues.Add(endDate);
            //execute
            Oracle.DataAccess.Types.OracleRefCursor result = (Oracle.DataAccess.Types.OracleRefCursor)QueryBuilder.functionCall(conn, funcName, retType, para, procValues);
            if (result!=null)
            {
                OracleDataReader rdr = result.GetDataReader();
                DataTable table = new DataTable();
                table.Load(rdr);
                ConnectionBuilder.PutConnection(conn);
                return table;
            }
            else
            ConnectionBuilder.PutConnection(conn);
            return null;
            ///////////////////////////////

        }
        public DataTable MostShownMovie(DateTime startDate, DateTime endDate)
        {
            ////////////////////////////////
            OracleDbType retType = OracleDbType.RefCursor;
            string funcName = "Movie_Most_Shown";
            OracleConnection conn = ConnectionBuilder.GetConnection();
            List<string> para = new List<string>();
            para.Add("startDate");
            para.Add("endDate");
            // Function Arguments values
            List<object> procValues = new List<object>();
            procValues.Add(startDate);
            procValues.Add(endDate);
            //execute
            Oracle.DataAccess.Types.OracleRefCursor result = (Oracle.DataAccess.Types.OracleRefCursor)QueryBuilder.functionCall(conn, funcName, retType, para, procValues);
            
                OracleDataReader rdr = result.GetDataReader();
                DataTable table = new DataTable();
                table.Load(rdr);
                ConnectionBuilder.PutConnection(conn);
                return table;
            
            ConnectionBuilder.PutConnection(conn);
            return null;
            ///////////////////////////////
        }
        public void addMovie1(Movie tempMovie, string[] MovieCate)
        {
            // Connect to DB
            OracleConnection conn = ConnectionBuilder.GetConnection();
            // Function Arguments
            //  SomeMethod(string conn, string[] anArrayOfKeys, List < string > args, List < object > values)
            List<string> para = new List<string>();
            para.Add("mname");
            para.Add("dura");
            para.Add("myear");
            para.Add("descrip");
            //para.Add("movieCate");

            List<object> procValues = new List<object>();
            procValues.Add(tempMovie.Name);
            procValues.Add(tempMovie.Duration);
            procValues.Add(tempMovie.Year);
            procValues.Add(tempMovie.Description);

            //execute
            QueryBuilder.StoredProcedureWithArray(conn, MovieCate, para, procValues);
            ConnectionBuilder.PutConnection(conn);

        }
    }
}