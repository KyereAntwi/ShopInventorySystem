using FrontApp.Models;
using FrontApp.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FrontApp.CustomTemplates
{
    public partial class DailySummaryTemplate : UserControl
    {
        private readonly BasketRepository BR;
        private readonly ProductRepository PR;
        List<Basket> Baskets = new List<Basket>();
        public DailySummaryTemplate(List<Basket> baskets)
        {
            InitializeComponent();
            Baskets = baskets;
            BR = new BasketRepository();
            PR = new ProductRepository();
        }

        private void ReportsTemplate_Load(object sender, EventArgs e)
        {
            if (Baskets.Count > 0)
            {
                Dictionary<Basket, List<BasketItem>> Data = new Dictionary<Basket, List<BasketItem>>();
                decimal totalAmountMade = 0;

                Baskets.ForEach(bas => 
                {
                    var items = BR.GetBasketItemsOfABasket(bas.Id);

                    if (items.Count > 0) 
                    {
                        Data.Add(bas, items);
                    }
                });

                ReportListBox.Items.Add("---------------------------------------");
                ReportListBox.Items.Add($"Daily report for {Baskets[0].TimeStamp.ToLongDateString()}");
                ReportListBox.Items.Add("---------------------------------------");
                ReportListBox.Items.Add("");
                ReportListBox.Items.Add("");

                ReportListBox.Items.Add("---------------------------------------------");
                ReportListBox.Items.Add("Summary of activities on chosen date");
                ReportListBox.Items.Add($"Total count of individual sales(Baskets) made: {Baskets.Count}");

                foreach (var basket in Data) 
                {
                    basket.Value.ForEach(i =>
                    {
                        totalAmountMade += i.AmountPayed;
                    });
                }

                ReportListBox.Items.Add($"Total amount received for current date is GHC{totalAmountMade}");
                ReportListBox.Items.Add("");
                ReportListBox.Items.Add("");

                ReportListBox.Items.Add("--------------------------------------");
                ReportListBox.Items.Add("Detailed report on the set date (List of baskets)");
                foreach (var basket in Data) 
                {
                    ReportListBox.Items.Add("");
                    decimal amountOnBasket = 0;
                    basket.Value.ForEach(item =>
                    {
                        amountOnBasket += item.AmountPayed;
                        ReportListBox.Items.Add($"Product: {PR.GetProduct(item.ProductId).Name}  |   Quantity: {item.ProductQuantity}");
                    });
                    ReportListBox.Items.Add($"Total on Basket: GHC{amountOnBasket}");
                }
            }
            else 
            {
                ReportListBox.Items.Add("---------------------------------------");
                ReportListBox.Items.Add("There are no reports on this date to display");
                ReportListBox.Items.Add("---------------------------------------");
            }
        }
    }
}
