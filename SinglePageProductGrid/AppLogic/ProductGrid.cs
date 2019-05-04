using SinglePageProductGrid.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            //SetupDataGridView();
            InitializeComponent();
        }

        private void addProduct_Click(object sender, EventArgs e)
        {
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

            productsGrid.Name = "songsDataGridView";
            productsGrid.Location = new Point(8, 8);
            productsGrid.Size = new Size(500, 250);
            productsGrid.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            productsGrid.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.Single;
            productsGrid.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            productsGrid.GridColor = Color.Black;
            productsGrid.RowHeadersVisible = false;

            productsGrid.Columns[0].Name = "Release Date";
            productsGrid.Columns[1].Name = "Track";
            productsGrid.Columns[2].Name = "Title";
            productsGrid.Columns[3].Name = "Artist";
            productsGrid.Columns[4].Name = "Album";
            productsGrid.Columns[4].DefaultCellStyle.Font =
                new Font(productsGrid.DefaultCellStyle.Font, FontStyle.Italic);

            productsGrid.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            productsGrid.MultiSelect = false;
            productsGrid.Dock = DockStyle.Fill;
        }

        private void productComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
