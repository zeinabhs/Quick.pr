using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quick.Models
{
    public class ProductDashboardViewModel
    {
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }

        public List<Product> ProductsMoreThan6 { get; set; }
        public List<Product> ProductsLessThan6 { get; set; }


        public int? SelectedCategoryId { get; set; }
    }
}
