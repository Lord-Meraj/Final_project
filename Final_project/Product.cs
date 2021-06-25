using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_project
{
    public class Product
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string ProductName { get; set; }
        public int Price { get; set; }
        [StringLength(50)]
        public string ProductCategory { get; set; }

    }
}
