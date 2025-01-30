using LINQ_Task_Solution;

namespace SortingOperators_Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SortProductByName();
            //SortInCaseInsensitive();
            //sortProductsByUnitsDESC();
            //sortDigitsByLengthThenAlph();
            //sortByWordLengthThenCaseInsensitive();
            //sortProductsByCategoryThenByPriceDESC();
            //sortByLengthThenInCaseSensitiveDESC();
            reverseDigitWithSecLetteri();
        }

        #region Ordering operator
        private static void SortProductByName()
        {
            var products = ListGenerators.ProductList;
            var orderedProduct = products.OrderBy(product => product.ProductName);
            foreach (var product in orderedProduct)
            {
                Console.WriteLine(product);
            }
        }

        private static void SortInCaseInsensitive()
        {
            string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            var sortedArr = Arr.OrderBy(a => a, StringComparer.OrdinalIgnoreCase);
            foreach (var item in sortedArr)
            {
                Console.WriteLine(item);
            }
        }
        private static void sortProductsByUnitsDESC()
        {
            var products = ListGenerators.ProductList;
            var orderedProduct = products.OrderByDescending(product => product.UnitsInStock);
            foreach (var product in orderedProduct)
            {
                Console.WriteLine(product);
            }
        }
        private static void sortDigitsByLengthThenAlph()
        {
            string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight",
                           "nine" };
            var sortedArr = Arr.OrderBy(a => a.Length).ThenBy(a => a);
            foreach (var item in sortedArr)
            {
                Console.WriteLine(item);
            }
        }

        private static void sortByWordLengthThenCaseInsensitive()
        {
            string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            var sortedWords = words.OrderBy(word => word.Length).
                                    ThenBy(word => word, StringComparer.OrdinalIgnoreCase);
            foreach (var item in sortedWords)
            {
                Console.WriteLine(item);
            }
        }
        private static void sortProductsByCategoryThenByPriceDESC()
        {
            var products = ListGenerators.ProductList;
            var orderedProduct = products.OrderByDescending(product => product.Category).ThenByDescending(product => product.UnitPrice);
            foreach (var product in orderedProduct)
            {
                Console.WriteLine(product);
            }

        }
        private static void sortByLengthThenInCaseSensitiveDESC()
        {
            string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            var sortedArr = Arr.OrderBy(word => word.Length).ThenByDescending(word => word, StringComparer.OrdinalIgnoreCase);
            foreach (var item in sortedArr)
            {
                Console.WriteLine(item);
            }
        }
        private static void reverseDigitWithSecLetteri()
        {
            string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight",
                             "nine" };
            var reversedDigitWithSecLetteri = Arr.Where(a => a.Length > 1 && a[1] == 'i').Reverse();
            foreach (var item in reversedDigitWithSecLetteri)
            {
                Console.WriteLine(item);
            }
        }
        #endregion
    }
}
