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
    class CategoryGateWay
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

       // public CategoryGateWay(OracleConnection temCon)
                public CategoryGateWay()
        {
         //   this.Con = temCon;
        }
        public DataTable selectAllCategory()
        {
            DataSet ds = new DataSet();
            OracleDataAdapter ad = new OracleDataAdapter();
            ad = new OracleDataAdapter("select * from CATEGORY", ConnectionBuilder.GetConnection());
            ConnectionBuilder.PutConnection(ConnectionBuilder.GetConnection());
            ad.Fill(ds);
            return ds.Tables[0];

        }
        public void insertCategory(Category temCategory)
        {

        }
        public void deleteCategory(Category temCategory)
        {

        }

    }
}
