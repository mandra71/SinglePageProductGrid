using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using SinglePageProductGrid.Models;

//Steamer Bar Cabinet
//https://www.crateandbarrel.com/steamer-bar-cabinet/s233296?localedetail=US&a=1552&campaignid=853779501&adgroupid=46164021347&targetid=pla-301450237335&pla_sku=233296&pcat=FURN&ag=adult&scid=scplp233296&sc_intid=233296&gclid=CjwKCAjwza_mBRBTEiwASDWVvsFdWM1qWCXpAy2NTB8_vmXY9IEHscRKRbrcGEKpFSxsjXEyd3RtQBoCkvoQAvD_BwE&gclsrc=aw.ds
//Lena Loveseat
//https://www.wayfair.com/Beverly-Fine-Furniture--Lena-Loveseat-QRMG1037-L305-K~QRMG1037.html?refid=GX103455941083-QRMG1037&device=c&ptid=152261648940&network=g&targetid=pla-152261648940&channel=GooglePLA&ireid=14067960&campaignid=398251723&gclid=CjwKCAjwza_mBRBTEiwASDWVvpBalch-k_5TOaOKnwhGuTUHAT_UetLhqEZc6oPNtRvRCVzUxUWgUxoCW0UQAvD_BwE&piid=12892508
//Seatcraft Home Theater Loveseat
//https://4seating.com/seatcraft-anthem-home-theater-sofa-loveseat?autoselect=1&color_id=select_16043&color_value=176576&configuration_id=select_16045&configuration_value=176585&gclid=CjwKCAjwza_mBRBTEiwASDWVvoEkfUqzephhX9lLuhHRjwezeKHeobsww5q4P7E2s1enQsWwvquN7BoCyToQAvD_BwE
//Henjes Coffee Table
//https://www.wayfair.com/furniture/pdp/latitude-run-henjes-coffee-table-lder3981.html
//Parker Recliner
//https://www.biglots.com/product/parker-beige-recliner/p810398792?zcp=pd_pla_go_G_Shopping:_Brand_est3431&gclid=CjwKCAjwza_mBRBTEiwASDWVvnLvl4qEh-3ICYvC8J4JkBDm4Nkod4Z__GWn0HXKJjYv1qqAMy63AhoC0FwQAvD_BwE&gclsrc=aw.ds

namespace SinglePageProductGrid
{
    public partial class ProductGrid : Form
    {
        private DataGridView productsGrid2 = new DataGridView();
        private Dictionary<int, Product> products = new Dictionary<int, Product>();

        public ProductGrid()
        {
            InitializeComponent();
            SetupDataGridView();
            createProducts();

            image.Image = Properties.Resources.Seatcraft;
        }

        private void addProduct_Click(object sender, EventArgs e)
        {
            Product insert = products[productComboBox1.SelectedIndex];
            insert.Quantity = quantity.SelectedIndex;

            if(insert.Quantity > 0)
                productsGrid.Rows.Add(insert.Title, insert.Description, string.Format("{0:C2}", insert.Price * insert.Quantity), insert.Quantity);

            quantity.SelectedIndex = 0;
        }
        /// <summary>
        /// Refrenced at
        /// https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.datagridview?view=netframework-4.8
        /// </summary>
        private void SetupDataGridView()
        {
            Controls.Add(productsGrid);

            productsGrid.ColumnCount = 5;

            productsGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            productsGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            productsGrid.ColumnHeadersDefaultCellStyle.Font =
                new Font(productsGrid.Font, FontStyle.Bold);

            productsGrid.Name = "productGridView";
            productsGrid.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            productsGrid.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.Single;
            productsGrid.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            productsGrid.GridColor = Color.Black;
            productsGrid.RowHeadersVisible = false;


            productsGrid.Columns[2].DefaultCellStyle.Font =
                new Font(productsGrid.DefaultCellStyle.Font, FontStyle.Bold);

            productsGrid.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            productsGrid.MultiSelect = false;
        }

        private void productComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product selected = products[productComboBox1.SelectedIndex];
            title.Text = selected.Title;
            price.Text = string.Format("{0:C2}", selected.Price);
            description.Text = selected.Description;
            switch (productComboBox1.SelectedIndex)
            {
                case 0:
                    image.Image = Properties.Resources.Seatcraft;
                    break;
                case 1:
                    image.Image = Properties.Resources.LenaLoveseat;
                    break;
                case 2:
                    image.Image = Properties.Resources.Parker;
                    break;
                case 3:
                    image.Image = Properties.Resources.SteamerBarCabinet;
                    break;
                case 4:
                    image.Image = Properties.Resources.HenjesCoffeeTable;
                    break;
            }
        }

        private void createProducts()
        {
            Product next = new Product();
            next.Title = "Seatcraft Home Theater loveseat";
            next.Description = "A chair worthy of its own audience, we welcome you to enjoy one of our most luxurious sectionals ever, built with one of our most exceptional leathers.";
            next.Price = 1799.00;
            next.Quantity = 0;

            products.Add(0, next);

            next = new Product();
            next.Title = "Lena Loveseat";
            next.Description = "Add a touch of modern flair to your home decor with this two-tone leather loveseat. This loveseat offers a gorgeous bonded leather upholstery, with a hardwood frame and chrome-finished metal legs.";
            next.Price = 479.99;
            next.Quantity = 0;

            products.Add(1, next);

            next = new Product();
            next.Title = "Parker Recliner";
            next.Description = "Get cozy on this recliner that is the ultimate in lounging! A tan hue and super comfy construction make it perfect for catching up on your favorite TV series or watching a movie with some popcorn! Featuring a padded chaise and a cupholder, this relaxing chair is ideal for the living room, family room or den.";
            next.Price = 399.99;
            next.Quantity = 0;

            products.Add(2, next);

            next = new Product();
            next.Title = "Steamer Bar Cabinet";
            next.Description = "Inspired by a vintage steamer trunk, our updated bar cabinet opens to reveal a full-service home bar. Finished back and concealed casters allow this handsome unit to float or swivel in a room; separate serving tray is removable for passing drinks.";
            next.Price = 1399.00;
            next.Quantity = 0;

            products.Add(3, next);

            next = new Product();
            next.Title = "Henjes Coffee Table";
            next.Description = "The coffee's table's simple and sophisticated crate design is undeniable and completely unique. From clean slatted lines along the tabletop to the airy open shelves along the base, this piece ensures an easy fit into any home style.";
            next.Price = 206.99;
            next.Quantity = 0;

            products.Add(4, next);
        }
    }
}
