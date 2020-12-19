using FrontApp.Models;
using FrontApp.Services;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FrontApp.Pages
{
    public partial class SearchProductsPage : Form
    {
        List<Product> Products = new List<Product>();
        private User CurrentUser = new User();
        private readonly ProductRepository PR;
        public SearchProductsPage(List<Product> products, User user)
        {
            InitializeComponent();
            Products = products;
            PR = new ProductRepository();
            CurrentUser = user;
        }

        private void SearchProductsPage_Load(object sender, System.EventArgs e)
        {
            if (Products.Count > 0) 
            {
                Products.ForEach(product =>
                {
                    Stock stock = PR.LastStockOfProduct(product.Id);
                    
                    if(stock != null)
                        ProductsListBox.Items.Add($"{product.Name}  -   Price(GHC{stock.UnitSellingPrice})");
                    else
                        ProductsListBox.Items.Add($"{product.Name}  -   Does not have stock");
                });
            }
        }

        private void ProductsListBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (ProductsListBox.SelectedItem != null) 
            {
                string productSelect = ProductsListBox.SelectedItem.ToString();
                var list = productSelect.Split(' ');
                string productName = list[0];

                Product product = Products.FirstOrDefault<Product>(p => p.Name.Contains(productName));

                AddProductPage addProductPage = new AddProductPage(product, CurrentUser);
                addProductPage.ShowDialog();
            }
        }
    }
}
