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
    class RowInHallGateway
    {
        //OracleConnection con;
        public RowInHallGateway()
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
        public DataTable selectAllRowInHall()
        {
            DataSet ds = new DataSet();
            OracleDataAdapter ad = new OracleDataAdapter();
            ad = new OracleDataAdapter("select * from RowInHall", ConnectionBuilder.GetConnection());
            ConnectionBuilder.PutConnection(ConnectionBuilder.GetConnection());
            ad.Fill(ds);
            return ds.Tables[0];
        }
        public void insertRowInHall(RowInHall currRowInHall)
        {

        }
        public void UpdateRowInHall(RowInHall currRowInHall)
        {

        }
        public void deleteRowInHall(RowInHall currRowInHall)
        {

        }
    }
}