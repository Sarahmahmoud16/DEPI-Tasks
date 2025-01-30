using LINQ_Task_Solution;

namespace AggreagateOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CountOddNumbers();
            //GetCustomersWithTotalOrders();
            //GetCategoriesWithTotalProducts();
            //GetTotalNumbers();
            CalculateTotalCharacters();
        }

        #region Aggregate operators 
        private static void CountOddNumbers()
        {
            int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            int oddCount = Arr.Count(x => x % 2 != 0);
            Console.WriteLine(oddCount);
        }

        private static void GetCustomersWithTotalOrders()
        {
            var customers = ListGenerators.CustomerList;

            var customersWithTotalOrders = customers
                .Select(c => new
                {
                    CustomerName = c.Name,
                    TotalOrders = c.Orders.Count()
                });

            // To print the results
            foreach (var customer in customersWithTotalOrders)
            {
                Console.WriteLine($"{customer.CustomerName}: {customer.TotalOrders} orders");
            }
        }
        private static void GetCategoriesWithTotalProducts()
        {
            var products = ListGenerators.ProductList;
            var categoriesWithTotalProducts = products.GroupBy(p => p.Category)
        .Select(g => new
        {
            Category = g.Key,
            TotalProducts = g.Count()
        });
            foreach (var category in categoriesWithTotalProducts)
            {
                Console.WriteLine($"{category.Category}: {category.TotalProducts} products");
            }
        }

        private static void GetTotalNumbers()
        {
            int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            Console.WriteLine($"Total sum = {Arr.Sum(x => x)}");
        }

        private static void CalculateTotalCharacters()
        {
            
            string[] words = File.ReadAllLines("dictionary_english");

            int totalCharacters = words.Sum(word => word.Length);

            Console.WriteLine($"Total characters: {totalCharacters}");
        }
        #endregion
    }
}
