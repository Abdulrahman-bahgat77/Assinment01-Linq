using System;
using System.Collections.Generic;
using System.Linq;
using static Assinment01_Linq.ListGenerator;

namespace Assinment01_Linq
{
    class comparerSence : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return string.Compare(x, y, StringComparison.OrdinalIgnoreCase);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Restriction Operators
            #region Q1
            //var Result =ProductsList.Where(P=>P.UnitsInStock>0);
            //foreach(var Product in Result)
            //{
            //    Console.WriteLine(Product);
            //}
            #endregion

            #region Q2
            //var Result = ProductsList.Where(P => P.UnitsInStock > 0 && P.UnitPrice > 3m);


            //foreach (var Product in Result)
            //{
            //    Console.WriteLine(Product);
            //}
            #endregion


            #region Q3
            // string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            // var Result = Arr.Where((n, i) => n.Length < i);
            //foreach (var Product in Result)
            // {
            //     Console.WriteLine(Product);
            // }
            #endregion
            #endregion

            #region LINQ - Ordering Operators
            #region Q1
            //  var Result = ProductsList.OrderBy(p => p.ProductName);
            #endregion

            #region Q2
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //#endregion
            //var Result = Arr.OrderBy(X => X, new comparerSence());
            #endregion

            #region Q3
            //  var Result = ProductsList.OrderByDescending(p => p.UnitsInStock);
            #endregion


            #region Q4
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var Result = Arr.OrderByDescending(X => X.Length).ThenBy(P=>P);
            #endregion

            #region Q5
            //string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var Result = words.OrderByDescending(X => X.Length).ThenBy(P => P,new  comparerSence());
            #endregion


            #region Q6
            // var Result = ProductsList.OrderByDescending(P => P.Category).ThenBy(X => X.UnitPrice); 
            #endregion

            #region Q7
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var Result = Arr.OrderBy(X => X.Length).ThenBy(P => P, new comparerSence());
            #endregion

            #region Q8
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var Result = Arr.Where(P => P[1] == 'i').Reverse();  ;
            #endregion

            //foreach (var Item in Result)
            //{
            //    Console.WriteLine(Item);
            //}
            #endregion

            #region LINQ – Transformation Operators
            #region Q1
            //  var Result = ProductsList.Select(X => X.ProductName);
            #endregion

            #region Q2
            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //var Result = words.Select(W => new
            //{
            //    UpperCase = W.ToUpper(),
            //    LowerCase = W.ToLower(),
            //});

            #endregion

            #region Q3
            //var Result = ProductsList.Select(X => new
            //{
            //    X.ProductID,
            //    X.ProductName,
            //    price = X.UnitPrice,
            //});
            #endregion

            #region Q4
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = Arr.Select((p, i) => new
            //{
            //   Number=p,
            //    X = i == p ? "true" : "false"
            //});
            #endregion

            #region Q5
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };
            //var Result = from a in numbersA
            //             from b in numbersB
            //             where a < b
            //             select new { a, b };

            #endregion

            #region Q6
            // var Result = CustomersList.SelectMany(X => X.Orders).Where(X => X.Total < 500);
            #endregion

            #region Q7
          //  var Result = CustomersList.SelectMany(X => X.Orders).Where(X => X.OrderDate.Year >= 1998);
            #endregion
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
        }
    }
}
