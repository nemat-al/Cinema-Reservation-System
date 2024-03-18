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
    class Offer_Over_CategoryGateway
    {
        // OracleConnection con;
        public Offer_Over_CategoryGateway()
        {
            //   this.Con = temCon;
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
        public DataTable selectAllOffer_Over_Category()
        {
            DataSet ds = new DataSet();
            OracleDataAdapter ad = new OracleDataAdapter();
            ad = new OracleDataAdapter("select * from Offer_Over_Category", ConnectionBuilder.GetConnection());
            ConnectionBuilder.PutConnection(ConnectionBuilder.GetConnection());
            ad.Fill(ds);
            return ds.Tables[0];
        }
        public void insertOffer_Over_Category(Offer cocorrespondentOfer, Offer_Over_Category currOfferCat)
        {
            string procName = "add_Offer_over_Category";

            // Connect to DB
            OracleConnection conn = ConnectionBuilder.GetConnection();
            // Function Arguments
            List<string> para = new List<string>();
            para.Add("ofPer");
            para.Add("catId");
            para.Add("stDate");
            para.Add("enDate");

            // Function Arguments values
            List<object> procValues = new List<object>();
            procValues.Add(cocorrespondentOfer.Percentage);
            procValues.Add(currOfferCat.CategoryId);
            procValues.Add(currOfferCat.StartDate);
            procValues.Add(currOfferCat.EndDate);

            //execute
            QueryBuilder.procedureCall(conn, procName, para, procValues);
            ConnectionBuilder.PutConnection(conn);

        }
        public void UpdateOffer_Over_Category(Offer_Over_Category currOfferCat)
        {

        }
        public void deleteOffer_Over_Category(Offer_Over_Category currOfferCat)
        {

        }
    }
}