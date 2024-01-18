using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace House_Management_Software
{
    public partial class GroceryList : Form
    {
        ProductsManager productsManager;
        User user;
        MenuPage menuPage;
        private bool close_application;
        public GroceryList(User user, MenuPage menuPage, ProductsManager productsManager)
        {
            InitializeComponent();
            this.user = user;
            this.productsManager = productsManager;
            this.menuPage = menuPage;
            AddNewProductButton.Enabled = false;
            Timer.Start();
            GroceryListPrinter();

            close_application = true;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void AddNewProductButton_Click(object sender, EventArgs e)
        {
            productsManager.AddProduct(tbNewProductName.Text, Convert.ToInt32(nmAmountNewProduct.Value), tbDescription.Text, false, user.ApartmentNumber);
            GroceryListPrinter();
            AddNewProductButton.Enabled = false;
        }

        private void tbNewProductName_TextChanged(object sender, EventArgs e)
        {
            AddNewProductButton.Enabled = true;
        }

        private void GroceryListPrinter()
        {
            tbNewProductName.ResetText();
            nmAmountNewProduct.Value = 1;
            tbDescription.ResetText();
            lbGroceryList.Items.Clear();
            foreach (Product product in productsManager.GetAllProducts(user))
            {
                lbGroceryList.Items.Add(product.GetInfo);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            CurrentTimeLabel.Text = currentTime.ToString();
        }

        private void BoughtButton_Click(object sender, EventArgs e)
        {
            if (lbGroceryList.SelectedIndex != -1)
            {
                Product selectedProduct = productsManager.GetAllProducts(user).ElementAt(lbGroceryList.SelectedIndex);
                productsManager.ChangeStatus(selectedProduct);
                GroceryListPrinter();
            }
            else
            {
                MessageBox.Show("Please select an item in the Grocery list first.");
            }
        }

        private void BackToMenuButton_Click(object sender, EventArgs e)
        {
            close_application = false;
            this.Close();
            menuPage.Show();
        }

        private void AnyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (close_application)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (lbGroceryList.SelectedItem != null)
            {
                string selectedItemInfo = lbGroceryList.SelectedItem.ToString();
                Product product = (productsManager.GetAllProducts(user)).FirstOrDefault(product => product.GetInfo == selectedItemInfo);
                productsManager.DeleteProduct(product);
                GroceryListPrinter();
            }
        }
    }
}
