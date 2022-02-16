using System;
using System.Linq;
using System.IO;
using NameSorterApp;

namespace NameSorter
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                _ = FluentNameSorter
                      .GetNameSorter(args)
                      .ValidateInputParam()
                      .ValidateInputFile()
                      .ReadInputFile()
                      .SortByLastNames()
                      .DisplayNames()
                      .WriteNames();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            Console.ReadLine();
        }
    }
}