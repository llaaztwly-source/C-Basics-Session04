namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q1
            //double[] prices = { 25.5, 40.0, 33.75 };
            //Console.WriteLine(prices[1]);
            #endregion

            #region Q2
            //int[,] shelfCopies = { {3,5 }
            //    , { 1,4} };
            //Console.WriteLine(shelfCopies[1,0]);
            #endregion

            #region Q3
            //void PrintWelcomeMessage()
            //{
            //    Console.WriteLine("Welcome to the Library!");
            //}
            //PrintWelcomeMessage();
            #endregion

            #region Q4
            //void PrintWelcomeMessage(string title)
            //{
            //    Console.WriteLine("Book title:" + title);
            //}
            //PrintWelcomeMessage("Clean Code");
            #endregion

            #region Q5
            // void AddBonusPages(int pages)
            //{
            //    pages += 50;
            //}
            //int pages = 400;
            //AddBonusPages(pages);
            //Console.WriteLine(pages); //400 value type


            #endregion

            #region Q6

            //void ApplyDiscount(double[] prices)
            //{
            //    prices[0] -= 5;
            //}
            //double[] prices = { 25.5, 40.0 };
            //ApplyDiscount(prices);
            //Console.WriteLine(prices[0]); // 20.5 Reference Type
            #endregion

            #region Q7
            //void AddBonusPagesByRef(ref int pages)
            //{
            //    pages += 50;
            //}
            //int pages = 400;
            //AddBonusPagesByRef(ref pages);
            //Console.WriteLine(pages); // 450 Reference Type

            #endregion

            #region Q8
            //void ReplaceArray(ref double[] prices)
            //{
            //    prices = new double[] { 10.0, 12.5, 15.0 };
            //}
            //double[] prices = { 25.5, 40.0 };
            //ReplaceArray(ref prices);
            //Console.WriteLine(prices.Length);//Reference Type


            #endregion

            #region Q9
            //bool TryGetPrice(string title, out double price)
            //{
            //    if (title == "Clean Code")
            //    {
            //        price = 25.5;
            //        return true;
            //    }
            //    price = 0;
            //    return false;
            //}
            //if (TryGetPrice("Clean Code", out double price2))
            //{
            //    Console.WriteLine("Price: " + price2);
            //}
            #endregion

            #region Q10
            //void PrintBookInfo(string title, int pages = 300)
            //{
            //    Console.WriteLine($"Title: {title}, Pages: {pages}");
            //}
            //PrintBookInfo("Clean Code");
            //PrintBookInfo("Design Patterns", 395);
            #endregion

            #region Q11
            //PrintBookInfo(pages: 450, title: "Programming");
            #endregion

            #region Q12
            //void PrintAllTitles(params string[] titles)
            //{
            //    foreach (string title in titles)
            //    {
            //        Console.WriteLine(title);
            //    }
            //}
            //PrintAllTitles("Clean Code", "The Pragmatic Programmer", "Refactoring");
            #endregion
        }
    }
}
