using FrontApp.Helpers;
using FrontApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;

namespace FrontApp.Services
{
    public class BasketRepository
    {
        private readonly AppSetting AppSetting;
        private string Querry;
        public BasketRepository()
        {
            AppSetting = new AppSetting();
        }

        public bool AddToBasket(Basket basket, List<BasketItem> basketItems) 
        {
            int response = 0;

            Querry = "INSERT INTO Baskets(Supervisor)";
            Querry += " VALUES(@Supervisor);";

            try
            {
                using (OleDbConnection cnn = new OleDbConnection(AppSetting.GetConnectionString("cn")))
                {
                    cnn.Open();

                    using (OleDbTransaction trn = cnn.BeginTransaction())
                    {
                        try
                        {
                            using (OleDbCommand cmd = new OleDbCommand(Querry, cnn))
                            {
                                cmd.Transaction = trn;

                                cmd.Parameters.Add(new OleDbParameter("@Supervisor", basket.Supervisor));

                                response = (int)cmd.ExecuteNonQuery();

                                // second statement to get the bsket id
                                Querry = "SELECT ID FROM Baskets WHERE Id=(SELECT max(Id) FROM Baskets);";
                                cmd.CommandText = Querry;
                                cmd.Parameters.Clear();

                                int basketId = 0;

                                using (OleDbDataReader dr = cmd.ExecuteReader())
                                {
                                    if (dr.HasRows)
                                    {
                                        while (dr.Read())
                                            basketId = dr.GetInt32(dr.GetOrdinal("ID"));
                                    }
                                }

                                // third statement to add the items to the basket
                                if (basketItems.Count > 0) 
                                {
                                    foreach (var item in basketItems) 
                                    {
                                        Querry = "INSERT INTO BasketItems(BasketId, ProductId, ProductQuantity, AmountPayed) ";
                                        Querry += "VALUES(@BasketId, @ProductId, @ProductQuantity, @AmountPayed);";

                                        cmd.CommandText = Querry;
                                        cmd.Parameters.Clear();

                                        cmd.Parameters.Add(new OleDbParameter("@BasketId", basketId));
                                        cmd.Parameters.Add(new OleDbParameter("@ProductId", item.ProductId));
                                        cmd.Parameters.Add(new OleDbParameter("@ProductQuantity", item.ProductQuantity));
                                        cmd.Parameters.Add(new OleDbParameter("@AmountPayed", item.AmountPayed));

                                        response = (int)cmd.ExecuteNonQuery();
                                    }
                                }

                                trn.Commit();
                            }
                        }
                        catch (Exception)
                        {
                            trn.Rollback();
                            return false;
                        }
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public List<BasketItem> GetBasketsItemsOfAProduct(int ProductId) 
        {
            List<BasketItem> items = new List<BasketItem>();

            try
            {
                using (OleDbConnection cnn = new OleDbConnection(AppSetting.GetConnectionString("cn")))
                {
                    Querry = "SELECT * FROM BasketItems ";
                    Querry += "WHERE ProductId=@ProductId;";

                    using (OleDbCommand cmd = new OleDbCommand(Querry, cnn))
                    {
                        cmd.Parameters.Add(new OleDbParameter("@ProductId", ProductId));

                        cnn.Open();

                        using (OleDbDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                        {
                            if (dr.HasRows) 
                            {
                                while (dr.Read()) 
                                {
                                    items.Add(new BasketItem 
                                    {
                                        BasketId = dr.GetInt32(dr.GetOrdinal("BasketId")),
                                        ProductId = dr.GetInt32(dr.GetOrdinal("ProductID")),
                                        AmountPayed = dr.GetDecimal(dr.GetOrdinal("AmountPayed")),
                                        ProductQuantity = dr.GetInt16(dr.GetOrdinal("ProductQuantity"))
                                    });
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                return items;
            }

            return items;
        }
        public List<BasketItem> GetBasketItemsOfABasket(int BasketId) 
        {
            List<BasketItem> items = new List<BasketItem>();

            try
            {
                using (OleDbConnection cnn = new OleDbConnection(AppSetting.GetConnectionString("cn")))
                {
                    Querry = "SELECT * FROM BasketItems ";
                    Querry += "WHERE BasketId=@BasketId;";

                    using (OleDbCommand cmd = new OleDbCommand(Querry, cnn))
                    {
                        cmd.Parameters.Add(new OleDbParameter("@BasketId", BasketId));

                        cnn.Open();

                        using (OleDbDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    items.Add(new BasketItem
                                    {
                                        BasketId = dr.GetInt32(dr.GetOrdinal("BasketId")),
                                        ProductId = dr.GetInt32(dr.GetOrdinal("ProductID")),
                                        AmountPayed = dr.GetDecimal(dr.GetOrdinal("AmountPayed")),
                                        ProductQuantity = dr.GetInt16(dr.GetOrdinal("ProductQuantity"))
                                    });
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                return items;
            }

            return items;
        }

        public List<Basket> GetBasketsOfADate(DateTime date) 
        {
            List<Basket> items = new List<Basket>();

            try
            {
                using (OleDbConnection cnn = new OleDbConnection(AppSetting.GetConnectionString("cn")))
                {
                    Querry = "SELECT * FROM Baskets";
                    Querry += " WHERE TimeStamp=@Date;";

                    using (OleDbCommand cmd = new OleDbCommand(Querry, cnn))
                    {
                        cmd.Parameters.Add(new OleDbParameter("@Date", date.Date));

                        cnn.Open();

                        using (OleDbDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    items.Add(new Basket
                                    {
                                        Id = dr.GetInt32(dr.GetOrdinal("Id")),
                                        TimeStamp = dr.GetDateTime(dr.GetOrdinal("TimeStamp")),
                                        Supervisor = dr.GetString(dr.GetOrdinal("Supervisor"))
                                    });
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                return items;
            }

            return items;
        }
        public Basket GetBasket(int BasketId) 
        {
            Basket basket = new Basket();

            try
            {
                using (OleDbConnection cnn = new OleDbConnection(AppSetting.GetConnectionString("cn")))
                {
                    Querry = "SELECT * FROM Baskets ";
                    Querry += "WHERE Id=@Id;";

                    using (OleDbCommand cmd = new OleDbCommand(Querry, cnn))
                    {
                        cmd.Parameters.Add(new OleDbParameter("@Id", BasketId));

                        cnn.Open();

                        using (OleDbDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    basket.Id = dr.GetInt32(dr.GetOrdinal("Id"));
                                    basket.TimeStamp = dr.GetDateTime(dr.GetOrdinal("TimeStamp"));
                                    basket.Supervisor = dr.GetString(dr.GetOrdinal("Supervisor"));
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }

            return basket;
        }

        public List<Basket> GetBasketOfASupervisor(string username)
        {
            List<Basket> baskets = new List<Basket>();

            try
            {
                using (OleDbConnection cnn = new OleDbConnection(AppSetting.GetConnectionString("cn")))
                {
                    Querry = "SELECT * FROM Baskets ";
                    Querry += "WHERE Supervisor=@Username;";

                    using (OleDbCommand cmd = new OleDbCommand(Querry, cnn))
                    {
                        cmd.Parameters.Add(new OleDbParameter("@Username", username));

                        cnn.Open();

                        using (OleDbDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    baskets.Add(new Basket
                                    {
                                        Id = dr.GetInt32(dr.GetOrdinal("Id")),
                                        TimeStamp = dr.GetDateTime(dr.GetOrdinal("TimeStamp")),
                                        Supervisor = dr.GetString(dr.GetOrdinal("Supervisor"))
                                });
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                return baskets;
            }

            return baskets;
        }
    }
}
