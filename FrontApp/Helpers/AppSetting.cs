using System.Configuration;

namespace FrontApp.Helpers
{
    public class AppSetting
    {
        Configuration config;
        public AppSetting()
        {
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        }

        // get the connection string
        public string GetConnectionString(string key) 
        {
            return config.ConnectionStrings.ConnectionStrings[key].ConnectionString;
        }

        public void SaveConnectionString(string key, string path, string databaseType) 
        {
            config.ConnectionStrings.ConnectionStrings[key].ConnectionString = path;

            if (databaseType == "SQLServer")
                config.ConnectionStrings.ConnectionStrings[key].ProviderName = "System.Data.SqlClient";
            else if (databaseType == "Access")
                config.ConnectionStrings.ConnectionStrings[key].ProviderName = "Microsoft.ACE.OLEDB.12.0";

            config.Save(ConfigurationSaveMode.Modified);
        }
    }
}
