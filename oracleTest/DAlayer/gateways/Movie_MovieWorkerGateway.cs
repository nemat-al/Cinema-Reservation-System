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
    class Movie_MovieWorkerGateway
    {
        //OracleConnection con;
        //public Movie_MovieWorkerGateway(OracleConnection temCon)
        
        public Movie_MovieWorkerGateway()
        {
        //    this.Con = temCon;
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
    public DataTable selectAllMovie_MovieWorker()
        {
            DataSet ds = new DataSet();
            OracleDataAdapter ad = new OracleDataAdapter();
            ad = new OracleDataAdapter("select * from Movie_MovieWorker", ConnectionBuilder.GetConnection());
            ConnectionBuilder.PutConnection(ConnectionBuilder.GetConnection());
            ad.Fill(ds);
            return ds.Tables[0];
        }
        public void insertMovie_MovieWorker(Movie_MovieWorker currMovie_MovieWorker)
        {

        }
        public void UpdateMovie_MovieWorker(Movie_MovieWorker currMovie_MovieWorker)
        {

        }
        public void deleteMovie_MovieWorker(Movie_MovieWorker currMovie_MovieWorker)
        {

        }
    }
}