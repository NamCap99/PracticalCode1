using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalCode1.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }       // nullable to avoid warning
        public decimal Price { get; set; }
        public int BrandId { get; set; }
    }
}
