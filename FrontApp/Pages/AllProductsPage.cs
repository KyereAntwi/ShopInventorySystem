using FrontApp.Models;
using FrontApp.Services;
using System;
using System.Windows.Forms;

namespace FrontApp.Pages
{
    public partial class AllProductsPage : Form
    {
        private readonly ProductRepository PR;
        private User CurrentUser;
        public AllProductsPage(User user = null)
        {
            InitializeComponent();
            PR = new ProductRepository();
            CurrentUser = user;
        }

        private void AllProductsPage_Load(object sender, EventArgs e)
        {
            try
            {
                var list = PR.GetProducts();

                if (list.Count > 0) 
                {
                    list.ForEach(product =>
                    {
                        ListViewItem listViewItem = new ListViewItem();
                        listViewItem.SubItems.Add(product.Id.ToString());
                        listViewItem.SubItems.Add(product.Name);
                        listViewItem.SubItems.Add(product.Manufacturer);

                        AllProductsList.Items.Add(listViewItem);
                    });
                }
            }
            catch (Exception)
            {
                this.Close();
            }
        }

        private void viewSelectedProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var items = AllProductsList.SelectedItems;

            if (items.Count > 0)
            {
                int productId = Convert.ToInt32(items[0].SubItems[1].Text);
                var product = PR.GetProduct(productId);

                AddProductPage addProductPage = new AddProductPage(product, CurrentUser);
                addProductPage.ShowDialog();
                this.Close();
            }
            else 
            {
                MessageBox.Show("You have not selected any product", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
