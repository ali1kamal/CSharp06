using System;
using System.Collections.Generic;
using System.Text;

namespace basics_06
{
    internal class TaskMethods
    {
        #region third answer
        public static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Library!");
        }
        #endregion

        #region fourth answer
        public static void PrintBookTitle(string title)
        {
            Console.WriteLine($"Book title: {title}");
        }
        #endregion

        #region fifth answer
        public static int AddBonusPages(int pages)
        {
           return pages = pages + 50;  
        }
        #endregion

        #region sixth answer
        public static double ApplyDiscount(double[] prices) 
        {
            return prices[0] = prices[0] - 5;
        }
        #endregion

        #region seventh answer
        public static int AddBonusPages(ref int pages)
        {
            return pages = pages + 50;
        }
        #endregion

        #region answer eight
        public static double[] ReplaceArray(ref double[] prices)
        {
          return  prices = new double[] { 10.0, 12.5, 15.0 };
        }
        #endregion

        #region answer nine
        public static bool TryGetPrice(string title, out double price)
        {
            if (title == "Clean Code")
            {
                price = 25.5;
                return true;
            }
            else
            {
                price = 0;
                return false;
            }
        }
        #endregion

        #region answer ten and eleven
        public static string PrintBookInfo(string title, int pages = 300)
        {
            return $"Book Title: {title}\nBook Pages: {pages}";
        }
        #endregion

        #region answer twelve
        public static void PrintAllTitles(params string[] titles)
        {
            foreach(string title in titles)
                Console.WriteLine(title);
        }
        #endregion
    }
}
