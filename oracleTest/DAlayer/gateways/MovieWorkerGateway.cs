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
    class MovieWorkerGateway
    {
        //OracleConnection con;
        public MovieWorkerGateway()
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
        public DataTable selectAllMovieWorker()
        {
            DataSet ds = new DataSet();
            OracleDataAdapter ad = new OracleDataAdapter();
            ad = new OracleDataAdapter("select * from MovieWorker", ConnectionBuilder.GetConnection());

            ConnectionBuilder.PutConnection(ConnectionBuilder.GetConnection());
            ad.Fill(ds);
            return ds.Tables[0];
        }
        public void insertMovieWorker(MovieWorker currMovieWorker)
        {

        }
        public void UpdateMovieShow(MovieShow currMovieWorker)
        {

        }
        public void deleteMovieShow(MovieShow currMovieWorker)
        {

        }
    }
}