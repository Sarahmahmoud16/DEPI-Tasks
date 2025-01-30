using LINQ_Task_Solution;

namespace ElementOperator_Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //getFirstProductOutOfStock();
            //getFirstProductWithPriceGreaterThan1000();
            getSecNumberGreaterThan5();
        }

        #region Element Operator
        private static void getFirstProductOutOfStock()
        {
            var products = ListGenerators.ProductList;
            var firstProduct = products.FirstOrDefault(product => product.UnitsInStock == 0);
            if(firstProduct is null)
            {
                Console.WriteLine("There is no Products out of stock");
            }
            else
            {
                Console.WriteLine(firstProduct);
            }
        }

        private static void getFirstProductWithPriceGreaterThan1000()
        {
            var products = ListGenerators.ProductList;
            var firstProduct = products.FirstOrDefault(product => product.UnitPrice > 1000);
                Console.WriteLine(firstProduct);
            
        }
        private static void getSecNumberGreaterThan5()
        {
            int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var element = Arr.Where(x => x > 5).ElementAt(2);
            Console.WriteLine(element);
        }
        #endregion
    }
}
