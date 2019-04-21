using BuilderAndPrototype.Builder;
using System;
using BuilderAndPrototype.Prototype;

namespace BuilderAndPrototype
{
    class Program
    {
        static void Main(string[] args)
        {
            var txtReport = new TxtReportBuider()
                .WithHeader("header")
                .WithBody("Body")
                .WithFooter("Footer")
                .GetReport();

            var director = new ReportDirector(new TxtReportBuider());
            var txtEmptyReport = director.GetEmptyReport();
            director.ChangeBuilder(new HtmlReportBuilder());
            var htmlReport = director.GetReport("Header", "Body", "Footer");

            //Console.WriteLine(txtReport);
            //Console.WriteLine(txtEmptyReport);
            //Console.WriteLine(htmlReport);
             
        var bookInfo = new AdditionalInfo(50, "Alan Wake");
            var book = new Book("Max Payne", 100, bookInfo);
            var shallowClonedBook = (Book)book.ShallowClone();
            var deepClonedBook = (Book)book.DeepClone();

            PrintBooksInfo(book, shallowClonedBook, deepClonedBook);

            book.Info.Author = "Daria dontsova";
            book.Info.PageNum = 10;

            Console.WriteLine("\nAfter change of initial book:\n");

            PrintBooksInfo(book, shallowClonedBook, deepClonedBook);

            Console.ReadKey();
        }

        private static void PrintBooksInfo(Book book, Book shallowClonedBook, Book deepClonedBook)
        {
            Console.WriteLine("Initial book:" + book);
            Console.WriteLine("Shallow cloned book:" + shallowClonedBook);
            Console.WriteLine("Deep cloned book:" + deepClonedBook);
        }
    }
}
