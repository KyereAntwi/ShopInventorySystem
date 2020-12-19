using FrontApp.Helpers;
using FrontApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;

namespace FrontApp.Services
{
    public class AccountRepository
    {
        AppSetting AppSetting = new AppSetting();

        private string Querry;

        public User LogIn(User authModel)
        {
            using (OleDbConnection dbConnection = new OleDbConnection(AppSetting.GetConnectionString("cn")))
            {
                Querry = "SELECT Role FROM Users";
                Querry += " WHERE Username = @Username AND Password = @Password";

                using (OleDbCommand dbCommand = new OleDbCommand(Querry, dbConnection))
                {
                    dbCommand.Parameters.Add(new OleDbParameter("@Username", authModel.Username.Trim()));
                    dbCommand.Parameters.Add(new OleDbParameter("@Password", authModel.Password.Trim()));

                    dbConnection.Open();

                    using (OleDbDataReader dr = dbCommand.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        while (dr.Read())
                            authModel.Role = dr.GetString(dr.GetOrdinal("Role"));
                    }
                }
            }

            return authModel;
        }

        public User CreateUser(User authModel) 
        {
            int response = 0;

            using (OleDbConnection cnn = new OleDbConnection(AppSetting.GetConnectionString("cn")))
            {
                Querry = "INSERT INTO Users";
                Querry += " VALUES(@Username, @Password, @Role);";

                using (OleDbCommand cmd = new OleDbCommand(Querry, cnn))
                {
                    cmd.Parameters.Add(new OleDbParameter("@Username", authModel.Username.Trim()));
                    cmd.Parameters.Add(new OleDbParameter("@Password", authModel.Password.Trim()));
                    cmd.Parameters.Add(new OleDbParameter("@Role", authModel.Role.Trim()));

                    cnn.Open();

                    response = (int)cmd.ExecuteNonQuery();
                }
            }

            if (response == 1)
                return authModel;
            return null;
        }

        public List<User> AllUsers() 
        {
            List<User> Users = new List<User>();

            using (OleDbConnection cnn = new OleDbConnection(AppSetting.GetConnectionString("cn")))
            {
                Querry = "SELECT * FROM Users;";

                using (OleDbCommand cmd = new OleDbCommand(Querry, cnn))
                {
                    cnn.Open();

                    using (OleDbDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        while (dr.Read())
                        {
                            Users.Add(new User
                            {
                                Username = dr.GetString(dr.GetOrdinal("Username")),
                                Password = dr.GetString(dr.GetOrdinal("Password")),
                                Role = dr.GetString(dr.GetOrdinal("Role"))
                            });
                        }
                    }
                }
            }

            return Users;
        }

        public bool RemoveUser(string username) 
        {
            int response = 0;

            try
            {
                using (OleDbConnection cnn = new OleDbConnection(AppSetting.GetConnectionString("cn")))
                {
                    Querry = "DELETE FROM Users WHERE Username=@Username";
                    using (OleDbCommand cmd = new OleDbCommand(Querry, cnn))
                    {
                        cmd.Parameters.Add(new OleDbParameter("@Username", username));
                        cnn.Open();
                        response = (int)cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }

            if (response == 1)
                return true;
            return false;
        }

        public List<string> AllUsernames() 
        {
            List<string> allUsernames = new List<string>();
            try
            {
                using (OleDbConnection cnn = new OleDbConnection(AppSetting.GetConnectionString("cn")))
                {
                    Querry = "SELECT Username FROM Users;";

                    using (OleDbCommand cmd = new OleDbCommand(Querry, cnn))
                    {
                        cnn.Open();

                        using (OleDbDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                        {
                            while (dr.Read())
                            {
                                allUsernames.Add(dr.GetString(dr.GetOrdinal("Username")));
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                return allUsernames;
            }

            return allUsernames;
        }
    }
}
