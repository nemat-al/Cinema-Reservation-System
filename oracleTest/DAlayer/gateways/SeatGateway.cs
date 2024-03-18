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
    class SeatGateway
    {
     //   OracleConnection con;
        public SeatGateway()
        {
          //  this.Con = temCon;
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
        public DataTable selectAllSeat()
        {
            DataSet ds = new DataSet();
            OracleDataAdapter ad = new OracleDataAdapter();
            ad = new OracleDataAdapter("select * from Seat", ConnectionBuilder.GetConnection());
            ConnectionBuilder.PutConnection(ConnectionBuilder.GetConnection());
            ad.Fill(ds);
            return ds.Tables[0];
        }
        public void insertSeat(Seat currSeat)
        {

        }
        public void UpdateSeat(Seat currSeat)
        {

        }
        public void deleteSeat(Seat currSeat)
        {

        }
    }
}