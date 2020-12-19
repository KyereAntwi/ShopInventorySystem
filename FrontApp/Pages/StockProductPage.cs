using FrontApp.Models;
using System;
using System.Windows.Forms;

namespace FrontApp.Pages
{
    public partial class StockProductPage : Form
    {
        public Stock Stock { get; set; }
        private int ProductId;
        public StockProductPage(int productId = 0)
        {
            InitializeComponent();
            Stock = new Stock();
            ProductId = productId;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Stock.UnitCostPrice = Convert.ToDecimal(UCPriceTxt.Text.Trim());
            Stock.UnitSellingPrice = Convert.ToDecimal(USPriceTxt.Text.Trim());
            Stock.AverageExpiration = ExpiryDate.Value;
            Stock.TotalQuantity = Convert.ToInt32(TotalQuantityTxt.Text.Trim());

            if (ProductId > 0) 
            {
                Stock.ProductId = ProductId;
            }

            this.Hide();
        }

        public Stock GetStockedItem() => Stock;
    }
}
