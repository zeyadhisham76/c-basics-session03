using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace RouteAssignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            string title = "clean code";
            string upperTitle = title.ToUpper();
            Console.WriteLine(title);
            Console.WriteLine(upperTitle);
            #endregion

            #region Q2
            string string1 = "Clean Code";
            string string2 = "Clean Code";
            Console.WriteLine(ReferenceEquals(string1, string2));
            #endregion

            #region Q3
            StringBuilder books = new StringBuilder();
            books = books.Append("Book List");
            books = books.Append(" - Updated");
            Console.WriteLine(books);
            #endregion

            #region Q4
            books = books.Replace("Book List", "Library");
            Console.WriteLine(books);
            #endregion

            #region Q5
            title = "Clean Code";
            int pages = 464;
            Console.WriteLine("Book: " + title + ", Pages:" + pages);
            #endregion

            #region Q6
            Console.WriteLine($"Book: {title}, Pages:{pages}");
            #endregion

            #region Q7
            Console.WriteLine("Book: {0}, Pages:{1}", title, pages);
            #endregion

            #region Q8
            if (pages > 300)
            {
                Console.WriteLine("Long Book");
            }
            else
            {
                Console.WriteLine("Short Book");
            }
            #endregion

            #region Q9
            bool isAvailable = true;
            if (pages > 300 && isAvailable)
            {
                Console.WriteLine("You can borrow this book");
            }
            else
            {
                Console.WriteLine("You cannot borrow this book");
            }
            #endregion

            #region Q10
            title = "Refactoring";

            switch (title)
            {
                case "Refactoring":
                    Console.WriteLine("Nice Pick!");
                    break;
                case "Clean Code":
                    Console.WriteLine("Great Choice");
                    break;
                default:
                    Console.WriteLine("Never heard of it");
                    break;
            }
            #endregion

            #region Q11
            string sizeLabel = pages > 300 ? "Long Book" : "Short Book";
            #endregion

            #region Q12
            string[] booksList = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{i + 1}. {booksList[i]}");
            }
            #endregion
            #region Q13
            int x = 0;
            while (x < 3)
            {
                Console.WriteLine(booksList[x]);
                x++;
            }
            #endregion
            #region Q14
            int counter = 0;
            do
            {
                Console.WriteLine("Checking Book.....");
                counter++;
            }
            while (counter < 3);
            #endregion
            #region Q14
            foreach (string book in booksList)
            {
                Console.WriteLine(book);
            }
            #endregion
            #region Q15
            for (int l = 0; l < 3; l++)
            {
                if (booksList[l] == "Refactoring")
                {
                    break;
                }
                else { Console.WriteLine(booksList[l]); }
            }
            #endregion
            #region Q16
            for (int l = 0; l < 3; l++)
            {
                if (booksList[l] == "The Pragmatic Programmer")
                {
                    continue;
                }
                else { Console.WriteLine(booksList[l]); }
            }
            #endregion
            #region Q17
            void PrintFirstBook()
            {
                if (booksList.Length == 0)
                {
                    return;
                }
                else
                {
                    Console.WriteLine(booksList[0]);
                }
            }
            PrintFirstBook();
            #endregion
        }
    }
}