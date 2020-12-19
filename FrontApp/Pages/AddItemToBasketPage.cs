using FrontApp.Models;
using System;
using System.Windows.Forms;

namespace FrontApp.Pages
{
    public partial class AddItemToBasketPage : Form
    {
        public BasketItem Item;
        public AddItemToBasketPage()
        {
            InitializeComponent();
            Item = new BasketItem();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Item = new BasketItem();
            Item.ProductId = Convert.ToInt32(ProductIdTxt.Text);
            Item.ProductQuantity = Convert.ToInt32(QuantityTxt.Text);
            this.Hide();
        }

        public BasketItem GetSetItem() => Item;
    }
}
