using FrontApp.Helpers;
using FrontApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;

namespace FrontApp.Services
{
    public class ProductRepository
    {
        AppSetting AppSetting;
        private string Querry;

        public ProductRepository()
        {
            AppSetting = new AppSetting();
        }

        public Product AddProductToDatabase(Product product, Stock stock = null) 
        {
            int response = 0;
            int productId = 0;

            Querry = "INSERT INTO Products(Name, Description, Manufacturer, Avatar)";
            Querry += " VALUES(@Name, @Description, @Manufacturer, @Avatar)";

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

                                cmd.Parameters.Add(new OleDbParameter("@Name", product.Name.Trim()));
                                cmd.Parameters.Add(new OleDbParameter("@Description", product.Description.Trim()));
                                cmd.Parameters.Add(new OleDbParameter("@Manufacturer", product.Manufacturer.Trim()));
                                cmd.Parameters.Add(new OleDbParameter("@Avatar", product.Avatar));

                                response = (int)cmd.ExecuteNonQuery();

                                // second statement to select the just added product
                                Querry = "SELECT * FROM Products WHERE Id=(SELECT max(Id) FROM Products);";
                                cmd.CommandText = Querry;
                                cmd.Parameters.Clear();

                                using (OleDbDataReader dr = cmd.ExecuteReader())
                                {
                                    if (dr.HasRows) 
                                    {
                                        while (dr.Read())
                                            productId = dr.GetInt32(dr.GetOrdinal("Id"));
                                    }
                                }

                                // third statement to add the first product stock of the inserted product
                                Querry = "INSERT INTO Stocks(ProductId, UnitCostPrice, UnitSellingPrice, AverageExpiration, StockedBy, TotalQuantity)";
                                Querry += " VALUES(@ProductId, @UnitCostPrice, @UnitSellingPrice, @AverageExpiration, @StockedBy, @TotalQuantity);";

                                cmd.CommandText = Querry;
                                cmd.Parameters.Clear();
                                cmd.Parameters.Add(new OleDbParameter("@ProductId", productId));
                                cmd.Parameters.Add(new OleDbParameter("@UnitCostPrice", stock.UnitCostPrice));
                                cmd.Parameters.Add(new OleDbParameter("@UnitSellingPrice", stock.UnitSellingPrice));
                                cmd.Parameters.Add(new OleDbParameter("@AverageExpiration", stock.AverageExpiration));
                                cmd.Parameters.Add(new OleDbParameter("@StockedBy", stock.StockedBy));
                                cmd.Parameters.Add(new OleDbParameter("@TotalQuantity", stock.TotalQuantity));

                                response = (int)cmd.ExecuteNonQuery();
                                trn.Commit();
                            }
                        }
                        catch (Exception)
                        {
                            trn.Rollback();
                            return null;
                        }
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }

            if (response == 1)
                return new Product 
                {
                    Id = productId,
                    Name = product.Name,
                    Description = product.Description,
                    TimeStamp = product.TimeStamp,
                    Avatar = product.Avatar,
                    Manufacturer = product.Manufacturer
                };
            return null;
        }

        public Stock StockProduct(Stock stock) 
        {
            int response = 0;

            try
            {
                using (OleDbConnection cnn = new OleDbConnection(AppSetting.GetConnectionString("cn")))
                {
                    Querry = "INSERT INTO Stocks(ProductId, UnitCostPrice, UnitSellingPrice, AverageExpiration, StockedBy, TotalQuantity)";
                    Querry += " VALUES(@ProductId, @UnitCostPrice, @UnitSellingPrice, @AverageExpiration, @StockedBy, @TotalQuantity);";

                    using (OleDbCommand cmd = new OleDbCommand(Querry, cnn))
                    {
                        cmd.Parameters.Add(new OleDbParameter("@ProductId", stock.ProductId));
                        cmd.Parameters.Add(new OleDbParameter("@UnitCostPrice", stock.UnitCostPrice));
                        cmd.Parameters.Add(new OleDbParameter("@UnitSellingPrice", stock.UnitSellingPrice));
                        cmd.Parameters.Add(new OleDbParameter("@AverageExpiration", stock.AverageExpiration));
                        cmd.Parameters.Add(new OleDbParameter("@StockedBy", stock.StockedBy));
                        cmd.Parameters.Add(new OleDbParameter("@TotalQuantity", stock.TotalQuantity));

                        cnn.Open();

                        response = (int)cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }

            if (response == 1)
                return stock;
            return null;
        }

        public List<Stock> StocksOfAProduct(int productId) 
        {
            List<Stock> stocks = new List<Stock>();

            try
            {
                using (OleDbConnection cnn = new OleDbConnection(AppSetting.GetConnectionString("cn"))) 
                {
                    Querry = "SELECT * FROM Stocks WHERE ProductId=@ProductId;";

                    using (OleDbCommand cmd = new OleDbCommand(Querry, cnn))
                    {
                        cmd.Parameters.Add(new OleDbParameter("@ProductId", productId));
                        cnn.Open();

                        using (OleDbDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                        {
                            while (dr.Read())
                            {
                                stocks.Add(new Stock
                                {
                                    Id = dr.GetInt32(dr.GetOrdinal("Id")),
                                    AddedAt = dr.GetDateTime(dr.GetOrdinal("AddedAt")),
                                    UnitCostPrice = dr.GetDecimal(dr.GetOrdinal("UnitCostPrice")),
                                    UnitSellingPrice = dr.GetDecimal(dr.GetOrdinal("UnitSellingPrice")),
                                    StockedBy = dr.GetString(dr.GetOrdinal("StockedBy")),
                                    AverageExpiration = dr.GetDateTime(dr.GetOrdinal("AverageExpiration")),
                                    TotalQuantity = dr.GetInt16(dr.GetOrdinal("TotalQuantity"))
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                return stocks;
            }

            return stocks;
        }

        public Stock LastStockOfProduct(int productId) 
        {
            Stock stock = new Stock();

            try
            {
                using (OleDbConnection cnn = new OleDbConnection(AppSetting.GetConnectionString("cn")))
                {
                    Querry = "SELECT TOP 1 * FROM Stocks WHERE ProductId=@ProductId ORDER BY Id DESC;";

                    using (OleDbCommand cmd = new OleDbCommand(Querry, cnn))
                    {
                        cmd.Parameters.Add(new OleDbParameter("@ProductId", productId));
                        cnn.Open();

                        using (OleDbDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                        {
                            if (dr.HasRows) 
                            {
                                while (dr.Read()) 
                                {
                                    stock.Id = dr.GetInt32(dr.GetOrdinal("Id"));
                                    stock.ProductId = dr.GetInt32(dr.GetOrdinal("ProductId"));
                                    stock.UnitCostPrice = dr.GetDecimal(dr.GetOrdinal("UnitCostPrice"));
                                    stock.UnitSellingPrice = dr.GetDecimal(dr.GetOrdinal("UnitSellingPrice"));
                                    stock.StockedBy = dr.GetString(dr.GetOrdinal("StockedBy"));
                                    stock.AddedAt = dr.GetDateTime(dr.GetOrdinal("AddedAt"));
                                    stock.TotalQuantity = dr.GetInt16(dr.GetOrdinal("TotalQuantity"));
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

            return stock;
        }

        public bool DeleteAProductCompletely(int ProductId) 
        {
            int response = 0;

            try
            {
                using (OleDbConnection cnn = new OleDbConnection(AppSetting.GetConnectionString("cn")))
                {
                    Querry = "DELETE FROM Products WHERE Id=@ProductId;";

                    using (OleDbCommand cmd = new OleDbCommand(Querry, cnn))
                    {
                        cnn.Open();

                        response = (int)cmd.ExecuteScalar();
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

        public List<Product> GetProducts() 
        {
            List<Product> products = new List<Product>();

            try
            {
                using (OleDbConnection cnn = new OleDbConnection(AppSetting.GetConnectionString("cn")))
                {
                    Querry = "SELECT * FROM Products";

                    using (OleDbCommand cmd = new OleDbCommand(Querry, cnn))
                    {
                        cnn.Open();

                        using (OleDbDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                        {
                            while (dr.Read())
                            {
                                products.Add(new Product
                                {
                                    Id = dr.GetInt32(dr.GetOrdinal("Id")),
                                    Description = dr.GetString(dr.GetOrdinal("Description")),
                                    Name = dr.GetString(dr.GetOrdinal("Name")),
                                    Manufacturer = dr.GetString(dr.GetOrdinal("Manufacturer")),
                                    TimeStamp = dr.GetDateTime(dr.GetOrdinal("TimeStamp")),
                                    Avatar = (byte[])dr["Avatar"]
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                return products;
            }

            return products;
        }
        public Product GetProduct(int ProductId) 
        {
            Product product = new Product();

            try
            {
                using (OleDbConnection cnn = new OleDbConnection(AppSetting.GetConnectionString("cn")))
                {
                    Querry = "SELECT * FROM Products WHERE Id=@ProductId";

                    using (OleDbCommand cmd = new OleDbCommand(Querry, cnn))
                    {
                        cmd.Parameters.Add(new OleDbParameter("@ProductId", ProductId));
                        cnn.Open();

                        using (OleDbDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                        {
                            while (dr.Read())
                            {
                                product.Id = dr.GetInt32(dr.GetOrdinal("Id"));
                                product.Description = dr.GetString(dr.GetOrdinal("Description"));
                                product.Name = dr.GetString(dr.GetOrdinal("Name"));
                                product.Manufacturer = dr.GetString(dr.GetOrdinal("Manufacturer"));
                                product.TimeStamp = dr.GetDateTime(dr.GetOrdinal("TimeStamp"));
                                product.Avatar = (byte[])dr["Avatar"];
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }

            return product;
        }
    }
}
