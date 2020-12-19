using FrontApp.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FrontApp.CustomTemplates
{
    public partial class ProudctReportTemplate : UserControl
    {
        private int ProductId;
        private readonly ProductRepository PR;
        private readonly BasketRepository BR;
        public ProudctReportTemplate(int productId)
        {
            InitializeComponent();
            ProductId = productId;
            PR = new ProductRepository();
            BR = new BasketRepository();
        }

        private void ProudctReportTemplate_Load(object sender, EventArgs e)
        {
            if (ProductId > 0) 
            {
                var product = PR.GetProduct(ProductId);

                if (product != null)
                {
                    var stockList = PR.StocksOfAProduct(ProductId);
                    var basketItemsList = BR.GetBasketsItemsOfAProduct(ProductId);

                    ProductReportLB.Items.Add($"SUMMARY REPORT FOR {product.Name}");

                    ProductReportLB.Items.Add("----------------------------------------------");
                    ProductReportLB.Items.Add("");
                    ProductReportLB.Items.Add("");

                    ProductReportLB.Items.Add("Product Information");
                    ProductReportLB.Items.Add($"Product ID: {product.Id}");
                    ProductReportLB.Items.Add($"Product Name: {product.Name}    | Product Manufacturer: {product.Manufacturer}");
                    ProductReportLB.Items.Add($"Product Description: {product.Description}");
                    ProductReportLB.Items.Add($"Date Added: {product.TimeStamp.ToLongDateString()}");

                    ProductReportLB.Items.Add("----------------------------------------------");
                    ProductReportLB.Items.Add("");
                    ProductReportLB.Items.Add("");

                    ProductReportLB.Items.Add("Product Stock Information");
                    ProductReportLB.Items.Add($"Total stocks made for product: {stockList.Count}");

                    int totalStockedCount = 0;
                    if (stockList.Count > 0)
                    {
                        stockList.ForEach(s =>
                        {
                            totalStockedCount += s.TotalQuantity;
                        });
                    }
                    ProductReportLB.Items.Add($"Total products placed on shelf so far: {totalStockedCount}");

                    if (basketItemsList.Count > 0)
                    {
                        int basketedCount = 0;
                        basketItemsList.ForEach(b =>
                        {
                            basketedCount += b.ProductQuantity;
                        });
                        ProductReportLB.Items.Add($"Total products left on shelf: {totalStockedCount - basketedCount}");
                    }
                    else
                        ProductReportLB.Items.Add($"Total products left on shelf: {totalStockedCount}");

                    ProductReportLB.Items.Add("----------------------------------------------");
                    ProductReportLB.Items.Add("");
                    ProductReportLB.Items.Add("");
                    ProductReportLB.Items.Add("Financial Statements on Product");
                    var lastStock = stockList.LastOrDefault();
                    ProductReportLB.Items.Add($"Current selling price of product: GHC ({lastStock.UnitSellingPrice})");

                    decimal totalExpectedToBeMade = 0;
                    stockList.ForEach(s =>
                    {
                        totalExpectedToBeMade += (s.UnitSellingPrice * s.TotalQuantity);
                    });

                    ProductReportLB.Items.Add($"Total amount expected to be made on product: GHC ({totalExpectedToBeMade})");

                    decimal totalMadeSoFar = 0;
                    basketItemsList.ForEach(b =>
                    {
                        totalMadeSoFar += b.AmountPayed;
                    });
                    ProductReportLB.Items.Add($"Total made on product so far: GHC ({totalMadeSoFar})");
                    ProductReportLB.Items.Add($"Profit or Loss generated on product: GHC ({totalExpectedToBeMade - totalMadeSoFar})");

                    ProductReportLB.Items.Add("----------------------------------------------");
                    ProductReportLB.Items.Add("");
                    ProductReportLB.Items.Add("");
                    ProductReportLB.Items.Add("Details of stocks and baskets of the product");
                    ProductReportLB.Items.Add("");
                    ProductReportLB.Items.Add("List of Stocks");
                    ProductReportLB.Items.Add("");

                    stockList.ForEach(s =>
                    {
                        ProductReportLB.Items.Add($"Date Stocked: {s.AddedAt.ToLongDateString()}    |   Total Stocked: {s.TotalQuantity}    |   Unit Cost Price: GHC {s.UnitCostPrice}  |   Unit Selling Price: GHC {s.UnitSellingPrice}");
                    });

                    ProductReportLB.Items.Add("");
                    ProductReportLB.Items.Add("");
                    ProductReportLB.Items.Add("List of Baskets");
                    ProductReportLB.Items.Add("");

                    basketItemsList.ForEach(b =>
                    {
                        var basket = BR.GetBasket(b.BasketId);
                        ProductReportLB.Items.Add($"Date Purchased: {basket.TimeStamp.ToLongDateString()}   |   Total Purchased: {b.ProductQuantity}    |   Total Payed on Purchase: GHC {b.AmountPayed}    |   Supervised By: {basket.Supervisor}");
                    });
                }
                else 
                {
                    ProductReportLB.Items.Add("There is no report on selected Product");
                }
            }
        }
    }
}
