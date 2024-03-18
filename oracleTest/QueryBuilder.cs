using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess;
using System.Collections.Generic;
using System.Data;

namespace oracleTest
{
    class QueryBuilder
    {
        public static object functionCall(OracleConnection conn, string funcName, OracleDbType retType, List<string> args, List<object> values)
        {
            // Init command
            OracleCommand cmd = new OracleCommand(funcName, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.BindByName = true;
            if (args != null)
            {
                for (int i = 0; i < args.Count; i++)
                {
                    OracleParameter param = new OracleParameter();
                    param.ParameterName = args[i];
                    param.Value = values[i];
                    cmd.Parameters.Add(param);
                }
            }

            OracleParameter outval = new OracleParameter("out", retType, ParameterDirection.ReturnValue);
            cmd.Parameters.Add(outval);
            //cmd.ExecuteNonQuery();
            cmd.ExecuteNonQuery();

            return cmd.Parameters["out"].Value;
        }

        public static void procedureCall(OracleConnection conn, string procName, List<string> args, List<object> values)
        {
            // Init command
            OracleCommand cmd = new OracleCommand(procName, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.BindByName = true;

            for (int i = 0; i < args.Count; i++)
            {
                OracleParameter param = new OracleParameter();
                param.ParameterName = args[i];
                param.Value = values[i];
                cmd.Parameters.Add(param);
            }
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {



            }
        }
        public static void queryExcute(OracleConnection conn, string query)
        {
            DataSet ds = new DataSet();
            OracleDataAdapter ad = new OracleDataAdapter();
            ad = new OracleDataAdapter(query, conn);
            ad.Fill(ds);
            //MUST RETURN ACCORING TO THE QUERY :/ 
            //return ds.Tables[0];

        }
        public static void StoredProcedureWithArray(OracleConnection conn, string[] anArrayOfKeys, List<string> args, List<object> values)
        {
            OracleCommand cmd = new OracleCommand("p.pp", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.BindByName = true;
            cmd.Parameters.Add("inp", OracleDbType.Varchar2, anArrayOfKeys, ParameterDirection.Input).CollectionType = OracleCollectionType.PLSQLAssociativeArray;
            for (int i = 0; i < args.Count; i++)
            {
                OracleParameter param = new OracleParameter();
                param.ParameterName = args[i];
                param.Value = values[i];
                cmd.Parameters.Add(param);
            }
            string exc = "";
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {

                exc = e.Message;

            }
        }
    }
}
