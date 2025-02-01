using LINQ_Task_Solution;

namespace Partitioning_Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //GetFirstThreeOrders();
            //SkipFirstTwoOrders();
            //getNumbersUntilLessThanIndex();
            // getFirstNumbersDivisibleBy3();
            getNumbersLessThanIndex();
        }

        #region partioning data
        private static void GetFirstThreeOrders()
        {
            var orders = ListGenerators.CustomerList;

            var firstThreeOrders = orders.Where(customer => customer.City.Equals("Berlin"))
                                  .SelectMany(customer => customer.Orders)
                                  .Take(3)
                                  .ToList();
            foreach (var order in firstThreeOrders)
            {
                Console.WriteLine($"Order ID: {order.Id}, Date: {order.OrderDate}");
            }
        }

        private static void SkipFirstTwoOrders()
        {
            var orders = ListGenerators.CustomerList;

            var firstThreeOrders = orders.Where(customer => customer.City.Equals("Berlin"))
                                  .SelectMany(customer => customer.Orders)
                                  .Skip(2).ToList();
            foreach (var order in firstThreeOrders)
            {
                Console.WriteLine($"Order ID: {order.Id}, Date: {order.OrderDate}");
            }
        }

        private static void getNumbersUntilLessThanIndex()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var numberAfterSkipped = numbers.TakeWhile((x, index) => x >index );
            foreach (var number in numberAfterSkipped)
            {
                Console.WriteLine(number);
            }
        }

        private static void getFirstNumbersDivisibleBy3()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var numbersDivisibleBy3 = numbers.SkipWhile(number=>number%3!=0);
            foreach (var number in  numbersDivisibleBy3)
            {
                Console.WriteLine(number);
            }
        }

        private static void getNumbersLessThanIndex()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var numberAfterSkipped = numbers.SkipWhile((n, index) => n >= index);
            foreach (var number in numberAfterSkipped)
            {
                Console.WriteLine(number);
            }
        }

        #endregion
    }
}
