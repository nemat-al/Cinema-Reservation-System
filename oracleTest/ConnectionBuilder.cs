using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess;

namespace oracleTest
{
    class ConnectionBuilder
    {
        private static string uname;
        private static string pass;
        private static string xe;
        private static bool alreadyCreated = false;
        private static OracleConnection connection; // This might be pool

        public static string Uname
        {
            get
            {
                return uname;
            }

            set
            {
                uname = value;
            }
        }

        public static string Pass
        {
            get
            {
                return pass;
            }

            set
            {
                pass = value;
            }
        }

        public static string Xe
        {
            get
            {
                return xe;
            }

            set
            {
                xe = value;
            }
        }

        public static bool InitializeConnection(string uname, string pass, string ex, string exceptionMessage)
        {
            ConnectionBuilder.Uname = uname;
            ConnectionBuilder.Pass = pass;
            ConnectionBuilder.Xe = ex;
            if (alreadyCreated == true)
            {
                return true; // might want to do something else
            }
            try
            {
                connection = new OracleConnection("User Id=" + ConnectionBuilder.Uname + ";Password=" + ConnectionBuilder.Pass + ";Data Source=" + ConnectionBuilder.Xe);
                alreadyCreated = true;
                try
                {
                    connection.Open(); // in general we dequeue a connection from pool
                    return true;
                }
                catch (Exception x)
                {
                    //string exceptionMessage = ex.Message;
                    return false;
                }
                return true;
            }
            catch (Exception exe)
            {
                exceptionMessage = exe.Message;
                return false;
            }
        }

        public static OracleConnection GetConnection()
        {
            string exe = "";
            if (alreadyCreated == false)
            {
                InitializeConnection(Uname, Pass, Xe, exe); // might do something else
            }
            return connection;
        }

        public static void PutConnection(OracleConnection oc)
        {
            try
            {
                alreadyCreated = false;
                oc.Close(); // in general we return connection to pool
                oc.Dispose();
            }
            catch (Exception ex)
            {
                string exceptionMessage = ex.Message;
            }
        }
    }
}
