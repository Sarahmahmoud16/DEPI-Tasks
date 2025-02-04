
using LINQ_Task_Solution;

namespace Quantifier_Operator_Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // CheckIfAnyWordContainsEI();
            //GetGategoriesAnyOfProductsOutOfStock();
            GetGategoriesAllOfProductsOutOfStock();


        }

        private static void CheckIfAnyWordContainsEI()
        {
            var lines = File.ReadAllLines("D:\\DEPI\\LINQ-DEPI\\DEPI-Tasks\\LINQ-Solution\\Quantifier-Operator-Linq\\dictionary-english.txt.txt");
            var iscontainei = lines.Any(l => l.Contains("ei"));
            Console.WriteLine($"is contain 'ei' {iscontainei}");
        }

        private static void GetGategoriesAnyOfProductsOutOfStock()
        {
            var products = ListGenerators.ProductList;
            var result = products.GroupBy(p => p.Category)
                                 .Where(g => g.Any(p => p.UnitsInStock == 0))
                                 .Select(g => new
                                 {
                                     Category = g.Key,
                                     Products = g.ToList()
                                 })
                                 .ToList();
            foreach (var group in result)
            {
                Console.WriteLine($"Category: {group.Category}");
                foreach (var product in group.Products)
                {
                    Console.WriteLine($"\tProduct: {product.ProductName}, UnitsInStock: {product.UnitsInStock}");
                }
            }
        }
            private static void GetGategoriesAllOfProductsOutOfStock()
            {
                var products = ListGenerators.ProductList;
            var result = products.GroupBy(p => p.Category)
            .Where(g => g.All(p => p.UnitsInStock > 0)).
            Select(g => new
            {
                Category=g.Key,
                Product=g.ToList()

            })
            .ToList();

            foreach (var group in result)
            {
                Console.WriteLine($"Category: {group.Category}");
                foreach (var product in group.Product)
                {
                    Console.WriteLine($"\tProduct: {product.ProductName}, UnitsInStock: {product.UnitsInStock}");
                }
            }
        }
        
        }
    }

