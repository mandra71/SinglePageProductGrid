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
        private DataGridView productsGrid = new DataGridView();
        private Dictionary<int, Product> products = new Dictionary<int, Product>();

        public ProductGrid()
        {
            InitializeComponent();
        }

        private void productSelected(object sender, EventArgs e)
        {

        }

        private void addProduct_Click(object sender, EventArgs e)
        {

        }
    }
}
