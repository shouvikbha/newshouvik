using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace UsingCodeFirst
{
    class Product
    {
        [Key]
        public int productId { get; set; }
        public string productName { get; set; }
        public string pCategory { get; set; }
        public decimal pPrice { get; set; }

    }
}
