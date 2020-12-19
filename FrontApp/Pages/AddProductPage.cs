using FrontApp.Models;
using FrontApp.Services;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace FrontApp.Pages
{
    public partial class AddProductPage : Form
    {
        private Product Product = new Product();
        private Stock FirstStock = new Stock();
        private readonly ProductRepository PR;
        private bool FileChanged = false;
        private User CurrentUser = new User();

        public AddProductPage(Product product = null, User user = null)
        {
            InitializeComponent();
            Product = product;
            PR = new ProductRepository();
            CurrentUser = user;
        }

        private void AddProductPage_Load(object sender, System.EventArgs e)
        {
            if (CurrentUser.Role.Contains("Attendant")) 
            {
                CommitBtn.Enabled = false;
                NewStockBtn.Enabled = false;
                SaveEditBtn.Enabled = false;
                StockBtn.Enabled = false;
            }

            if (Product != null)
            {
                ProductNameTxt.Enabled = false;
                ProductDescriptionTxt.Enabled = false;
                ProductAddedDate.Enabled = false;
                ProductManufacturerTxt.Enabled = false;
                ProductAvatarBox.Enabled = false;
                LoadImageBtn.Enabled = false;
                SaveEditBtn.Text = "Edit Product";
                NewStockBtn.Visible = true;

                ProductIdTxt.Text = Product.Id.ToString();
                ProductNameTxt.Text = Product.Name;
                ProductDescriptionTxt.Text = Product.Description;
                ProductAddedDate.Value = Product.TimeStamp;
                ProductManufacturerTxt.Text = Product.Manufacturer;

                if (Product.Avatar != null) 
                {
                    var bytes = Product.Avatar;
                    using (MemoryStream stream = new MemoryStream(bytes))
                    {
                        Image image = Image.FromStream(stream);
                        ProductAvatarBox.Image = image;
                    }
                }

                // load the stocks if any
                var stockList = PR.StocksOfAProduct(Product.Id);

                if (stockList.Count > 0) 
                {
                    stockList.ForEach(stock => 
                    {
                        ListViewItem listViewItem = new ListViewItem();
                        listViewItem.SubItems.Add(stock.AddedAt.ToShortDateString());
                        listViewItem.SubItems.Add(stock.UnitCostPrice.ToString());
                        listViewItem.SubItems.Add(stock.UnitSellingPrice.ToString());
                        listViewItem.SubItems.Add(stock.AverageExpiration.ToShortDateString());
                        listViewItem.SubItems.Add(stock.StockedBy);
                        listViewItem.SubItems.Add(stock.TotalQuantity.ToString());
                        StockLiveView.Items.Add(listViewItem);
                    });
                }
            }
            else 
            {
                StockBtn.Visible = false;
            }
        }

        private void SaveEditBtn_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ProductNameTxt.Text) || string.IsNullOrWhiteSpace(ProductManufacturerTxt.Text))
            {
                MessageBox.Show("The fields Product Name and Product Manufacturer cannot be empty", "Add Product - SIS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else 
            {
                Product = new Product
                {
                    Name = ProductNameTxt.Text,
                    Description = ProductDescriptionTxt.Text,
                    Manufacturer = ProductManufacturerTxt.Text,
                    TimeStamp = ProductAddedDate.Value
                };

                if (FileChanged)
                {
                    using (MemoryStream stream = new MemoryStream())
                    {
                        var image = ProductAvatarBox.Image;
                        image.Save(stream, ImageFormat.Jpeg);
                        Product.Avatar = stream.ToArray();
                    }
                }

                ProductNameTxt.Enabled = false;
                ProductDescriptionTxt.Enabled = false;
                ProductAddedDate.Enabled = false;
                ProductManufacturerTxt.Enabled = false;
                ProductAvatarBox.Enabled = false;
                LoadImageBtn.Enabled = false;
                StockBtn.Visible = true;
            }
        }

        private void CommitBtn_Click(object sender, System.EventArgs e)
        {
            if (SaveEditBtn.Text == "Save Product")
            {
                if (FirstStock == null)
                {
                    MessageBox.Show("Please make your first stock for the product to Commit to database, start by adding the first stock to continue", "Add Product - SIS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else 
                {
                    try
                    {
                        var response = PR.AddProductToDatabase(Product, FirstStock);
                        if (response != null) 
                        {
                            MessageBox.Show("Product committed successfully", "Add Product - SIS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"There was an error #{ex.Message}", "Add Product - SIS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (SaveEditBtn.Text == "Edit Product") 
            {
                try
                {
                    // edit a product ...
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private void LoadImageBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ProductAvatarBox.ImageLocation = dialog.FileName;
                    FileChanged = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Problem loading image", "Add Product - SIS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StockBtn_Click(object sender, EventArgs e)
        {
            StockProductPage stockProductPage = new StockProductPage();
            var response = stockProductPage.ShowDialog();

            if (response == DialogResult.Cancel) 
            {
                var StockedItem = stockProductPage.GetStockedItem();

                if (StockedItem.UnitCostPrice > 0 && StockedItem.UnitSellingPrice > 0 && StockedItem.TotalQuantity > 0) 
                {
                    FirstStock.ProductId = Convert.ToInt32(ProductIdTxt.Text);
                    FirstStock.StockedBy = CurrentUser.Username;
                    FirstStock.UnitCostPrice = StockedItem.UnitCostPrice;
                    FirstStock.UnitSellingPrice = StockedItem.UnitSellingPrice;
                    FirstStock.TotalQuantity = StockedItem.TotalQuantity;
                    FirstStock.AddedAt = DateTime.Now;

                    var stockResponse = PR.StockProduct(FirstStock);

                    if (stockResponse != null)
                    {
                        MessageBox.Show("Stock was successful", "Stock - SIS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ListViewItem listViewItem = new ListViewItem();
                        listViewItem.SubItems.Add(stockResponse.AddedAt.ToShortDateString());
                        listViewItem.SubItems.Add(stockResponse.UnitCostPrice.ToString());
                        listViewItem.SubItems.Add(stockResponse.UnitSellingPrice.ToString());
                        listViewItem.SubItems.Add(stockResponse.AverageExpiration.ToShortDateString());
                        listViewItem.SubItems.Add(stockResponse.StockedBy);
                        listViewItem.SubItems.Add(stockResponse.TotalQuantity.ToString());
                        StockLiveView.Items.Add(listViewItem);
                    }
                    else 
                    {
                        MessageBox.Show("Stocking failed, try again. If problem persist contact developer", "Stock - SIS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                stockProductPage.Close();
            }
        }

        private void NewStockBtn_Click(object sender, EventArgs e)
        {
            StockProductPage stockProductPage = new StockProductPage(Product.Id);
            var response = stockProductPage.ShowDialog();
            var stock = stockProductPage.GetStockedItem();

            if (response == DialogResult.Cancel) 
            {
                var newStock = PR.StockProduct(stock);
                stockProductPage.Close();

                if (newStock != null) 
                {
                    MessageBox.Show("Stock added successfully", "Add Stock - SIS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.SubItems.Add(newStock.AddedAt.ToShortDateString());
                    listViewItem.SubItems.Add(newStock.UnitCostPrice.ToString());
                    listViewItem.SubItems.Add(newStock.UnitSellingPrice.ToString());
                    listViewItem.SubItems.Add(newStock.AverageExpiration.ToShortDateString());
                    listViewItem.SubItems.Add(newStock.StockedBy);
                    listViewItem.SubItems.Add(newStock.TotalQuantity.ToString());

                    tabControl1.SelectedTab = tabControl1.TabPages[1];
                }
            }
        }
    }
}
