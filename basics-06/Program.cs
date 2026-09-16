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
            int pages = 400;
            Console.WriteLine(pages);
            TaskMethods.AddBonusPages(pages);
            //it won't be changed because the process of method occurs in stack frame of method and the variable pages is in stack so there isn't in the same place in memory
            Console.WriteLine(pages);
            #endregion
        }
    }
}
