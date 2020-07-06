using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {

            var books = new BookRepository().GetBooks();

            /*Below code is using LINQ to get list of books which are cheaper from Repositary*/

            //var cheapBooks = new List<Book>();
            //foreach (var book in books)
            //{
            //    if (book.Price < 10)
            //    {

            //        cheapBooks.Add(book);
            //    }
            //}
            //foreach (var book in cheapBooks)
            //{
            //    Console.WriteLine(book.Title + "" + "Prize is $" + book.Price);
            //    Console.WriteLine(book);
            //}


            #region Linq Extension Method with Where, WHERE is used to filter and return a list that match given condition.

            /*Using Linq getting cheaper books from repository*/
            /*Linq The where clause is used in a query expression to specify which elements from the data source will be returned in the query expression.
             It applies a Boolean condition (predicate)
             to each source element (referenced by the range variable) and returns those for which the specified condition is true*/
            /* Linq Select is Used for Tranformations or projections.
             /*Console.WriteLine("Cheap Books are as follow");*/
            /*Below syntax is Called LINQ Extension Methods*/

            //var cheapBooks = books
            //                .Where(b => b.Price < 10)
            //                .OrderBy(b => b.Title)
            //                .Select(b => b.Title);
            //foreach (var book in cheapBooks)
            //{
            //    Console.WriteLine(book.Title + "" + "Prize is $" + book.Price);
            //    Console.WriteLine(book);
            //}
            //Console.ReadLine();
            #endregion


            #region Linq using Single Used to get Single Object  that matches given condition in the result

            /*Where above returns IEnumerable List of Books
              If you want to get single record use SINGLE*/

            //var book = books.Single(b => b.Title == "ASP.NET MVC");

            #endregion


            #region  Linq using SingleorDefualt

            /*In below Book Title "ASP.NET MVC++" not exits in list so its throw error when you "Single"
                /*To avoid above error  you can use "SingleorDefualt" which returns default null if not found*/

            //var book = books.SingleOrDefault(b => b.Title == "ASP.NET MVC++");
            //if(book!=null)
            //Console.WriteLine(book.Title);
            //Console.ReadLine();

            #endregion



            #region First its used to get First Object in a Collection

            //var book = books.First(b => b.Title=="C# Advanced Topics");
            //Console.WriteLine(book.Title+" Prize is $ "+book.Price);
            //Console.ReadLine();

            //It throws exception if not found

            #endregion

            #region FirstOrDefaulat  this returns null if not found 

            //var book1= books.FirstOrDefault(b => b.Title == "C# Advanced Topics123");
            //if(book1!=null)
            //Console.WriteLine(book1.Title + " Prize is $ " + book1.Price);
            //Console.ReadLine();

            #endregion

            #region LastOrDefault

            //var book1 = books.LastOrDefault(b => b.Title == "C# Advanced Topics");
            //    Console.WriteLine(book1.Title+" Pize $ "+book1.Price);
            //   Console.ReadLine();
            #endregion

            #region SKIP and TAKE are used for pagging Data

            //var pagedBooks= books.Skip(2).Take(3);
            //foreach (var book in pagedBooks)
            //{
            //    Console.WriteLine(book.Title);

            //}

            //Console.ReadLine();


            #endregion

            
            #region Aggreate Functions on Linq

            var count = books.Count();

                Console.WriteLine(count);

                var maxPrize=books.Max(b => b.Price);

                Console.WriteLine(maxPrize);

                var minPrize = books.Min(b => b.Price);

                Console.WriteLine(minPrize);

                var totalPrize = books.Sum(b => b.Price);

                Console.WriteLine(totalPrize);



            Console.ReadLine();

            #endregion

            #region Another of Writing LINQ is called LINQ Query Operators

            /*Another of Writing LINQ is called LINQ Query Operators
            /*This starts with "FROM" and Ends with "SELECT"*/

            ////var CheaperBooks = from b in books
            ////                   where b.Price < 10
            ////                   orderby b.Title
            ////                   select b;


            ////foreach (var book in cheapBooks)
            ////{
            ////    Console.WriteLine(book.Title + "" + "Prize is $" + book.Price);
            ////    Console.WriteLine(book);
            ////}
            //// Console.ReadLine();

            #endregion


            #region Important Notes Linq

            /* Difference between "Find" and "FirstOrDefault" in lambda expression in*/

            //Find is actually a native method of the List class.
            //It loops through each item in the last and sees if it matches the predicate.
            //FirstOrDefault is an extension method that will work on anything that is IEnumerable.
            //It does the same job, only it runs through the data via the enumerator rather than directly through the list like Find does.  
            //Find is supposedly a small fraction faster due to the overhead of using the enumerator that FirstOrDefault has.


            /* Difference between "Find" and "Select" in lambda expression in*/

            //One of the primary differences is that the Find() method is actually going to stop enumerating through the data once it
            //finds a match(since it only returns a single object).
            //But the Select() method is going to iterate over the entire collection regardless(since it can return multiple records that
            //meet the criteria specified).
            // Find() method is not available on all Enumerable collections and is native to Lists, unlike the Select() method which can be used on any Enumerable collection (including Lists).


            #endregion
        }

        private static float CalculateDiscount(float price)
        {
            return 0;
        }

    
    }
}
