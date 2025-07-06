using PracticalCode1.Models;
using PracticalCode1.Services;
using PracticalCode1.Data;
using System;
using System.Collections.Generic;

namespace PracticalCode1
{
    class Program
    {
        public static void Main(string[] args)
        {
            var products = DataSeeder.GetProducts();
            var brands = DataSeeder.GetBrands();
            var orders = DataSeeder.GetOrders();

            //LinqSolutions.GetProductBrandNames(products, brands);
            //LinqSolutions.GetTotalValueByEachOrder(products, orders);
            //LinqSolutions.GetTopOrderedProducts(products, orders, 3);
            LinqSolutions.AverageProductPricePerBrand(products, brands);

            Console.ReadKey();
        }
    }
}
