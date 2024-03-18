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
    class OfferOverShowGateway
    {
        //OracleConnection con;
        public OfferOverShowGateway()
        {
            //this.Con = temCon;
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
        public DataTable selectAllOfferOverShow()
        {
            DataSet ds = new DataSet();
            OracleDataAdapter ad = new OracleDataAdapter();
            ad = new OracleDataAdapter("select * from OfferOverShow", ConnectionBuilder.GetConnection());
            ConnectionBuilder.PutConnection(ConnectionBuilder.GetConnection());
            ad.Fill(ds);
            return ds.Tables[0];
        }
        public void insertOfferOverShow(Offer cocorrespondentOfer, OfferOverShow currOfferOverShow)
        {

            string procName = "add_Offer_over_Show";
            /*showId OFFER_OVER_SHOW.SHOW_ID%Type,
showLePo OFFER_OVER_SHOW.LEASTPOINTS%type)
             * 
             */
            // Connect to DB
            OracleConnection conn = ConnectionBuilder.GetConnection();
            // Function Arguments
            List<string> para = new List<string>();
            para.Add("ofPer");
            para.Add("showId");
            para.Add("showLePo");

            // Function Arguments values
            List<object> procValues = new List<object>();
            procValues.Add(cocorrespondentOfer.Percentage);
            procValues.Add(currOfferOverShow.Show_id);
            procValues.Add(currOfferOverShow.LeastPoints);

            //execute
            QueryBuilder.procedureCall(conn, procName, para, procValues);
            ConnectionBuilder.PutConnection(conn);

        }

        public void UpdateOfferOverShow(OfferOverShow currOfferOverShow)
        {

        }
        public void deleteOfferOverShow(OfferOverShow currOfferOverShow)
        {

        }
    }
}