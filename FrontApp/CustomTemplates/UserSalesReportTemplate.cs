using FrontApp.Models;
using FrontApp.Services;
using System;
using System.Windows.Forms;

namespace FrontApp.CustomTemplates
{
    public partial class UserSalesReportTemplate : UserControl
    {
        private string User;
        private readonly BasketRepository BR;
        private readonly ProductRepository PR;

        public UserSalesReportTemplate(string user)
        {
            InitializeComponent();
            User = user;

            BR = new BasketRepository();
            PR = new ProductRepository();
        }

        private void UserSalesReportTemplate_Load(object sender, EventArgs e)
        {
            if (User != null) 
            {
                var basketsList = BR.GetBasketOfASupervisor(User);

                if (basketsList.Count > 0) 
                {
                    UserSalesListBox.Items.Add($"Report on the list of sales made by {User}");
                    UserSalesListBox.Items.Add("------------------------------------------------------");
                    UserSalesListBox.Items.Add("");

                    int count = 1;
                    basketsList.ForEach(b => 
                    {
                        UserSalesListBox.Items.Add("");
                        UserSalesListBox.Items.Add($"Sales number {count} Date: {b.TimeStamp.ToLongDateString()}");
                        var listofItems = BR.GetBasketItemsOfABasket(b.Id);

                        listofItems.ForEach(i =>
                        {
                            UserSalesListBox.Items.Add($"Product: {PR.GetProduct(i.ProductId).Name}     |  Quantity: {i.ProductQuantity}    |   Amount Payed: GHC{i.AmountPayed} ");
                        });
                        count += 1;
                    });
                }
                else
                {
                    UserSalesListBox.Items.Add($"There are no sales made by user {User}");
                }
            }
        }
    }
}
