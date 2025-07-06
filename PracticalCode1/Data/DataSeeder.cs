using PracticalCode1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalCode1.Data
{
    public static class DataSeeder
    {
        public static List<Product> GetProducts() => new()
        {
            new Product { Id = 1, Name = "Laptop", Price = 1500, BrandId = 1 },
            new Product { Id = 2, Name = "Phone", Price = 800, BrandId = 2 },
            new Product { Id = 3, Name = "Tablet", Price = 600, BrandId = 1 },
            new Product { Id = 4, Name = "Monitor", Price = 300, BrandId = 3 },
            new Product { Id = 5, Name = "Keyboard", Price = 100, BrandId = 2 },
            new Product { Id = 6, Name = "Mouse", Price = 50, BrandId = 2 }
        };

        public static List<Brand> GetBrands() => new()
        {
            new Brand { Id = 1, Name = "TechCorp" },
            new Brand { Id = 2, Name = "SmartCo" },
            new Brand { Id = 3, Name = "ViewMax" }
        };

        public static List<Order> GetOrders() => new()
        {
            new Order { Id = 1, ProductIds = new List<int> { 1, 2, 4, 6 } },   // Laptop + Phone + Monitor + Mouse
            new Order { Id = 2, ProductIds = new List<int> { 3 } },            // Tablet
            new Order { Id = 3, ProductIds = new List<int> { 2, 4, 5 } },      // Phone + Monitor + Keyboard
            new Order { Id = 4, ProductIds = new List<int> { 6 } }             // Mouse
        };
    }
}
