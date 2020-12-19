using FrontApp.CustomTemplates;
using FrontApp.Models;
using FrontApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FrontApp.Pages
{
    public partial class WelomePage : Form
    {
        private readonly User CurrentUser;
        private readonly ProductRepository PR;
        private readonly BasketRepository BR;
        private readonly AccountRepository AR;

        private List<BasketItem> CurrentBasketItems;

        public WelomePage(User loggedInUser = null)
        {
            InitializeComponent();
            this.CurrentUser = loggedInUser;

            PR = new ProductRepository();
            BR = new BasketRepository();
            AR = new AccountRepository();
            CurrentBasketItems = new List<BasketItem>();
        }

        private void WelomePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to completely close the application", "Master User - SIS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                Application.ExitThread();
            else
            {
                e.Cancel = true;
            }
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to completely close the application", "Master User - SIS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                Application.ExitThread();
        }

        private void WelomePage_Load(object sender, EventArgs e)
        {
            // ui stuff
            if (!CurrentUser.Role.Contains("Administrator")) 
            {
                rEPORTSToolStripMenuItem.Enabled = false;
                pRODUCTSToolStripMenuItem.Enabled = false;
                fILEToolStripMenuItem.Enabled = false;
            }

            LoggedInUser.Text = $"You are welcome: {CurrentUser.Username}";

            SearchProductTxt.Focus();

            var usersList = AR.AllUsernames();
            usersList.ForEach(u => 
            {
                UserSalesCombo.Items.Add(u);
            });
        }

        private void addItemToBasketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddItemToBasketPage addItemToBasketPage = new AddItemToBasketPage();
            var windowResponse = addItemToBasketPage.ShowDialog();

            if (windowResponse == DialogResult.Cancel) 
            {
                ProgressBar.Visible = true;
                var SetItem = addItemToBasketPage.GetSetItem();

                if (SetItem.ProductId > 0 && SetItem.ProductQuantity > 0 && SetItem != null)
                {
                    try
                    {
                        var product = PR.GetProduct(SetItem.ProductId);
                        var response = PR.StocksOfAProduct(SetItem.ProductId);

                        if (response.Count > 0)
                        {
                            SetItem.AmountPayed = SetItem.ProductQuantity * response.LastOrDefault().UnitSellingPrice;
                            CurrentBasketItems.Add(SetItem);

                            ListViewItem viewItem = new ListViewItem();
                            viewItem.SubItems.Add(SetItem.ProductId.ToString());
                            viewItem.SubItems.Add(product.Name);
                            viewItem.SubItems.Add(SetItem.ProductQuantity.ToString());
                            viewItem.SubItems.Add(response.LastOrDefault().UnitSellingPrice.ToString());
                            viewItem.SubItems.Add(SetItem.AmountPayed.ToString());

                            decimal total = 0;
                            CurrentBasketItems.ForEach(b =>
                            {
                                total += b.AmountPayed;
                            });

                            BasketItemsList.Items.Add(viewItem);
                            BasketTotal.Text = $"{total}";
                        }
                        else
                        {
                            MessageBox.Show("The product specified does not exist", "Add Basket Item - SIS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"A problem occurred #{ex.Message}", "Add Basket Item - SIS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        ProgressBar.Visible = false;
                        addItemToBasketPage.Close();
                    }
                }
            }
        }

        private void BasketItemsList_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void clearCurrentBasketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("You want to clear the basket, are you sure you want to proceed?", "Basket Items - SIS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes) 
            {
                CurrentBasketItems.Clear();
                BasketItemsList.Items.Clear();
                BasketTotal.Text = "0";
            }
        }

        private void createABasketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CurrentBasketItems.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Proceed to submit basket for processing?", "Basket Items - SIS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        ProgressBar.Visible = true;

                        var response = BR.AddToBasket(new Basket
                        {
                            Supervisor = CurrentUser.Username,
                            TimeStamp = DateTime.Now
                        }, CurrentBasketItems);

                        if (response)
                        {
                            MessageBox.Show("Basket submit and processed successfully", "Basket - SIS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            BasketItemsList.Items.Clear();
                            CurrentBasketItems.Clear();
                            BasketTotal.Text = "0";
                        }
                        else 
                        {
                            MessageBox.Show("Operation failed, try again. If problem persist contact developer", "Basket - SIS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"There was a problem with operation #{ex.Message}", "Basket - SIS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else 
            {
                MessageBox.Show("There are no items in the basket", "Basket - SIS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void viewAllUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsersListPage usersListPage = new UsersListPage();
            ProgressBar.Visible = true;
            usersListPage.ShowDialog();
        }

        private void createANewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUserPage addUserPage = new AddUserPage();
            addUserPage.ShowDialog();
        }

        private void addAProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProductPage addProductPage = new AddProductPage(null, CurrentUser);
            addProductPage.ShowDialog();
        }

        private void viewListOfProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllProductsPage allProductsPage = new AllProductsPage(CurrentUser);
            allProductsPage.ShowDialog();
        }

        private void SearchProductTxt_Enter(object sender, EventArgs e)
        {
            
        }

        private void SearchProductTxt_DoubleClick(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SearchProductTxt.Text) || SearchProductTxt.Text.Contains("Search a product here ..."))
            {
                MessageBox.Show("You have not entered a valid search query parameter", "Search Product", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var response = PR.GetProducts();

                if (response.Count > 0)
                {
                    List<Product> products = new List<Product>();
                    products = response.Where<Product>(p => p.Name.ToLower().Contains(SearchProductTxt.Text.Trim().ToLower())).ToList();

                    if (products.Count == 0)
                    {
                        MessageBox.Show("There are no products found with such name", "Search Product", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        SearchProductsPage searchProductsPage = new SearchProductsPage(products, CurrentUser);
                        searchProductsPage.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("There are no products found", "Search Product", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void removeItemFromBasketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var items = BasketItemsList.SelectedItems;

            if (items.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove selected Item", "Basket Item - SIS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    int accNumb = Convert.ToInt32(items[0].SubItems[1].Text);
                    CurrentBasketItems = CurrentBasketItems.Where(b => b.ProductId != accNumb).ToList();

                    decimal total = 0;
                    CurrentBasketItems.ForEach(b => 
                    {
                        total += b.AmountPayed;
                    });

                    BasketItemsList.Items.Remove(items[0]);

                    BasketTotal.Text = $"{total}";
                }
            }
            else
            {
                MessageBox.Show("Make sure you have selected a customer at the far left column to continue", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void summaryReportForTodayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var basketList = BR.GetBasketsOfADate(DateTime.Now);

            if (basketList.Count > 0) 
            {
                DailySummaryTemplate dailySummaryTemplate = new DailySummaryTemplate(basketList);
                if (WelcomeTab.TabPages.Count == 1)
                {
                    DisplayDateReport(dailySummaryTemplate);
                }
                else
                {
                    var lastTab = WelcomeTab.TabPages[1];
                    WelcomeTab.TabPages.Remove(lastTab);
                    DisplayDateReport(dailySummaryTemplate);
                }
            }
            else
            {
                MessageBox.Show("There are sales made today yet!", "Report - SIS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DisplayDateReport(UserControl userControl) 
        {
            TabPage tabPage = new TabPage();
            tabPage.Text = "Reports Page";
            userControl.Dock = DockStyle.Fill;
            tabPage.Controls.Add(userControl);
            WelcomeTab.TabPages.Add(tabPage);
            WelcomeTab.SelectedTab = tabPage;
        }

        private void DatedReportTxt_DoubleClick(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(DatedReportTxt.Text) || DatedReportTxt.Text.Contains("Enter date eg: 02/02/2020 ..."))
                MessageBox.Show("You have not entered appropriate date", "Report - SIS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else 
            {

                var basketList = BR.GetBasketsOfADate(Convert.ToDateTime(DatedReportTxt.Text.Trim()));

                if (basketList.Count > 0)
                {
                    DailySummaryTemplate dailySummaryTemplate = new DailySummaryTemplate(basketList);
                    if (WelcomeTab.TabPages.Count == 1)
                    {
                        DisplayDateReport(dailySummaryTemplate);
                    }
                    else
                    {
                        var lastTab = WelcomeTab.TabPages[1];
                        WelcomeTab.TabPages.Remove(lastTab);
                        DisplayDateReport(dailySummaryTemplate);
                    }
                }
                else
                {
                    MessageBox.Show("There are sales made today yet!", "Report - SIS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void ProductReportTxt_DoubleClick(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ProductReportTxt.Text) || ProductReportTxt.Text.Contains("Enter the product Id and double click .."))
                MessageBox.Show("You did not enter a product Id, try again", "Product Report - SIS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else 
            {
                ProudctReportTemplate proudctReportTemplate = new ProudctReportTemplate(Convert.ToInt32(ProductReportTxt.Text));
                if (WelcomeTab.TabPages.Count == 1)
                {
                    DisplayDateReport(proudctReportTemplate);
                }
                else
                {
                    var lastTab = WelcomeTab.TabPages[1];
                    WelcomeTab.TabPages.Remove(lastTab);
                    DisplayDateReport(proudctReportTemplate);
                }
            }
        }

        private void ProductReportTxt_Click(object sender, EventArgs e)
        {

        }

        private void UserSalesCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UserSalesCombo.Text))
                MessageBox.Show("You did not select any user, try again", "Sales Report - SIS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                UserSalesReportTemplate proudctReportTemplate = new UserSalesReportTemplate(UserSalesCombo.Text);
                if (WelcomeTab.TabPages.Count == 1)
                {
                    DisplayDateReport(proudctReportTemplate);
                }
                else
                {
                    var lastTab = WelcomeTab.TabPages[1];
                    WelcomeTab.TabPages.Remove(lastTab);
                    DisplayDateReport(proudctReportTemplate);
                }
            }
        }
    }
}
