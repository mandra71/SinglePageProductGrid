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
    }
}
