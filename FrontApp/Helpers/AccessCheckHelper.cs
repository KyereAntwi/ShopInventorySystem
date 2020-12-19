using System.Data.OleDb;

namespace FrontApp.Helpers
{
    public class AccessCheckHelper
    {
        OleDbConnection cn;
        public AccessCheckHelper(string connectionString)
        {
            cn = new OleDbConnection(connectionString);
        }

        public bool IsConnection 
        {
            get 
            {
                if (cn.State == System.Data.ConnectionState.Closed)
                    cn.Open();

                return true;
            }
        }

        public string ConnectionString 
        {
            get 
            {
                return cn.ConnectionString;
            }
        }
    }
}
