namespace basics_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1st answer

            //double[] array = { 25.5, 40.0, 33.75 };
            //Console.WriteLine(array[1]);
            #endregion

            #region second answer
            //int[,] shelfCopies =
            //{
            //    {3,5},
            //    {1,4}
            //};
            //Console.WriteLine(shelfCopies[1,0]);
            #endregion

            #region third answer
            //TaskMethods.PrintWelcomeMessage();
            #endregion

            #region fourth answer
            //TaskMethods.PrintBookTitle("Clean Code");
            #endregion

            #region fifth answer
            //int pages = 400;
            //Console.WriteLine(pages);
            //TaskMethods.AddBonusPages(pages);
            ////it won't be changed because the process of method occurs in stack frame of method and the variable pages is in stack so there isn't in the same place in memory
            //Console.WriteLine(pages);
            #endregion

            #region sixth answer
            //double[] prices = { 25.5, 40.0 };
            //Console.WriteLine(prices[0]);
            //TaskMethods.ApplyDiscount(prices);
            ////it will change because the prices in stack has the addresse of the array not the value of the array and prices in stack frame has the same addresse so any change will occur to both of them
            //Console.WriteLine(prices[0]);
            #endregion

            #region seventh answer
            //int pages = 400;
            //Console.WriteLine(pages);
            //TaskMethods.AddBonusPages(ref pages);
            ////it will change because passing value type by reference it send all the variable to method and the process occur on it not like passing by value
            //Console.WriteLine(pages);
            #endregion

            #region answer eight 
            //double[] arr = { 19.5, 5.25};
            //Console.WriteLine(arr.Length);
            //TaskMethods.ReplaceArray(ref arr);
            ////it will be 3 because the arr in stack has the addresse of the array in heap and while passing by ref we pass the variable with the value so the changes will happen to it 
            //Console.WriteLine(arr.Length);
            #endregion

            #region answer nine
            //string title = "Clean Code";
            //TaskMethods.TryGetPrice(title, out double price);
            //Console.WriteLine(price);
            #endregion

            #region answer ten
            //string bookInfo = TaskMethods.PrintBookInfo("Clean Code");
            //Console.WriteLine(bookInfo);
            //Console.WriteLine("=======");
            //string info = TaskMethods.PrintBookInfo("My Book", 450);
            //Console.WriteLine(info);
            #endregion

            #region answer eleven
            //string info = TaskMethods.PrintBookInfo(pages: 150,title: "Book Title");
            //Console.WriteLine(info);
            #endregion

            #region answer twleve
            TaskMethods.PrintAllTitles("Clean Code", "Data Structure", "Operating Systems");
            #endregion
        } 
    }
}
