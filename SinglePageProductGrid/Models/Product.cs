using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglePageProductGrid.Models
{
    class Product
    {
       protected string Title { get; set; }
       protected string Description { get; set; }
       protected int Price { get; set; }
       protected int Quantity { get; set; }
       protected string ImageLocation { get; set; }
    }
}
