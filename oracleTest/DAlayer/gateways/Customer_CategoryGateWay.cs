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
    class Customer_CategoryGateWay
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

        //  public Customer_CategoryGateWay(OracleConnection temCon)
        public Customer_CategoryGateWay()
        {
            //this.Con = temCon;
        }
        public DataTable selectAllCustomer_Category()
        {
            DataSet ds = new DataSet();
            OracleDataAdapter ad = new OracleDataAdapter();
            ad = new OracleDataAdapter("select * from CUSTOMER_CATEGORY", ConnectionBuilder.GetConnection());
            ConnectionBuilder.PutConnection(ConnectionBuilder.GetConnection());
            ad.Fill(ds);
            return ds.Tables[0];

        }
        public void insertCustomer_Category(Customer_Category temCustomer_Category)
        {

        }
        public void deleteCustomer_Category(Customer_Category temCustomer_Category)
        {

        }

    }
}