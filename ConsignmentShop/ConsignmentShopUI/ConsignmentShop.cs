using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsignmentShopLibrary;

namespace ConsignmentShopUI
{
    public partial class ConsignmentShop : Form
    {
        private List<Item> ShoppingCartData = new List<Item>();
        BindingSource itemsBinding = new BindingSource();
        BindingSource cartBinding = new BindingSource();
        BindingSource vendorsBinding = new BindingSource();
        private decimal storeProfit = 0;

        private Store store = new Store();

        public ConsignmentShop()
        {
            InitializeComponent();
            SetUpData();
            itemsBinding.DataSource = store.Items.Where(x => x.Sold == false).ToList();
            itemlistBox.DataSource = itemsBinding;

            itemlistBox.DisplayMember = "Display";
            itemlistBox.ValueMember = "Display";


            cartBinding.DataSource = ShoppingCartData;
            ShoppingCartListBox.DataSource = cartBinding;

            ShoppingCartListBox.DisplayMember = "Display";
            ShoppingCartListBox.ValueMember = "Display";

            vendorsBinding.DataSource = store.Vendors;
            vendorListBox.DataSource = vendorsBinding;

            vendorListBox.DisplayMember = "Display";
            vendorListBox.ValueMember = "Display";
        }

        private void SetUpData()    
        {
            store.Vendors.Add(new Vendor { FirstName = "Mudit", LastName = "Jain"});
            store.Vendors.Add(new Vendor { FirstName = "Rishika", LastName = "Jain", Commission = 0.6 });

            store.Items.Add(new Item
            {
                Title = "Moby Hail",
                Description = "Description on Whale",
                Price = 5, Owner = store.Vendors[0]
            });

            store.Items.Add(new Item {
                Title = "Moby first",
                Description = "Description on Whale",
                Price = 6.5M,
                Owner = store.Vendors[1]
            });

            store.Items.Add(new Item
            {
                Title = "Wizards of Beverly Hills",
                Description = "Sci-Fi",
                Price = 2,
                Owner = store.Vendors[0]
            });

            store.Items.Add(new Item
            {
                Title = "Harry Potter 1",
                Description = "Fantacy Novel",
                Price = 6.9M,
                Owner = store.Vendors[1]
            });

            store.Name = "Seconds are better";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void PurchaseItem_Click(object sender, EventArgs e)
        {

        }

        private void AddToCart(object sender, EventArgs e)
        {
            Item selectedItem = (Item)itemlistBox.SelectedItem;
            

            ShoppingCartData.Add(selectedItem);
            cartBinding.ResetBindings(false);
        }

        private void Purchase_Click(object sender, EventArgs e)
        {
            foreach (Item item in ShoppingCartData)
            {
                item.Sold = true;
                item.Owner.PaymentDue += (decimal)item.Owner.Commission * item.Price;
                storeProfit += (1 - (decimal)item.Owner.Commission) * item.Price;
            }

            ShoppingCartData.Clear();

            itemsBinding.DataSource = store.Items.Where(x => x.Sold == false).ToList();

            storeProfitValue.Text = string.Format("${0}", storeProfit);

            cartBinding.ResetBindings(false);
            itemsBinding.ResetBindings(false);
            vendorsBinding.ResetBindings(false);
        }
    }
}
