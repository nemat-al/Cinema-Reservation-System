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
    class OfferGateway
    {
    //    OracleConnection con;
        public OfferGateway()
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
        public DataTable selectAllOffer()
        {
            DataSet ds = new DataSet();
            OracleDataAdapter ad = new OracleDataAdapter();

            ad = new OracleDataAdapter("select * from Offer", ConnectionBuilder.GetConnection());

            ConnectionBuilder.PutConnection(ConnectionBuilder.GetConnection());
            ad.Fill(ds);
            return ds.Tables[0];
        }
        public void insertOffer(Offer currGateway)
        {

        }
        public void UpdateOffer(Offer currGateway)
        {

        }
        public void deleteOffer(Offer currGateway)
        {

        }
    }
}