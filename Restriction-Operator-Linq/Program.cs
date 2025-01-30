using LINQ_Task_Solution;

namespace Restriction_Operator_Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FindAllProductsOutOfStock();
            // productsInStocWIthCostMoreThan300();
            // DigitsWithNamesShorterThanValue();
        }

        #region restriction operators
       
        private static void FindAllProductsOutOfStock()
        {
            var products = ListGenerators.ProductList;
            var productsOutOfStock = products.Where(p => p.UnitsInStock == 0);
          
            foreach (var product in productsOutOfStock)
            {
                Console.WriteLine(product);
            }
        }

        private static void productsInStocWIthCostMoreThan300()
        {
            var products = ListGenerators.ProductList;
            var productsInStockMoreThan300 = products.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3.00M);
            foreach (var product in productsInStockMoreThan300)
            {
                Console.WriteLine(product);
            }

        }
        private static void DigitsWithNamesShorterThanValue()
        {
            string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight",
                            "nine" };

            var values = Arr.Where((word, index) => word.Length < index);

            foreach (var value in values)
            {
                Console.WriteLine(value);
            }

        }

        #endregion
    }
}
