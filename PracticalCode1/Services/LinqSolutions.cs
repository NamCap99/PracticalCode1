using PracticalCode1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalCode1.Services
{
    public static class LinqSolutions
    {
        // 1. Get Product by Names
        public static void GetProductBrandNames(List<Product> products, List<Brand> brands)
        {
            Console.WriteLine("Get Product Brand by Name");
            var result = products.Join(brands,
                product => product.BrandId,
                brand => brand.Id,
                (product, brand) => new
                {
                    ProductName = product.Name,
                    BrandName = brand.Name
                });

            foreach (var item in result)
            {
                Console.WriteLine($"Product: {item.ProductName}, Brand: {item.BrandName}");
            }
        }

        // Get Total value of each order
        public static void GetTotalValueByEachOrder(List<Product> products, List<Order> orders)
        {
            Console.WriteLine("Get Total value by each order");
            //var result = products.Join(order,
            //    product => product.Id,
            //    order => order.Id,
            //    (product, order) => new
            //    {

            //    });

            foreach (var order in orders)
            {
                var total = order.ProductIds
                    .Select(id => products.First(p => p.Id == id).Price)
                    .Sum();
                Console.WriteLine($"Order {order.Id} Total {total}");
            }
        }
        // Top N most ordered Products (let say 3 --> Take(3))
        public static void GetTopOrderedProducts(List<Product> product, List<Order> orders, int topN)
        {
            Console.WriteLine($"Get the top ordered products {topN}");
            var topOrderProduct = orders
                .SelectMany(order => order.ProductIds)
                .GroupBy(id => id)
                .Select(group => new
                {
                    ProductId = group.Key,
                    Count = group.Count()
                })
                .OrderByDescending(x => x.Count)
                .Take(topN)
                .Join(product,
                o => o.ProductId,
                p => p.Id,
                (o, p) => new
                {
                    ProductName = p.Name,
                    Ordered = o.Count
                });

            foreach (var item in topOrderProduct)
            {
                Console.WriteLine($"Product {item.ProductName} Ordered {item.Ordered}");
            }
        }

        // Average Product Price per Brand
        public static void AverageProductPricePerBrand(List<Product> products, List<Brand> brands)
        {

            var result = products
                .GroupBy(p => p.BrandId)
                .Select(g =>
                {
                    var brandName = brands.First(b => b.Id == g.Key).Name;
                    var averagePrice = g.Average(p => p.Price);

                    return new { BrandName = brandName, AveragePrice = averagePrice };
                });
            foreach (var item in result)
            {
                Console.WriteLine($"Brand {item.BrandName} - Average Product is {item.AveragePrice:F2}");
            }
        }

    }
}