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
    }
}
