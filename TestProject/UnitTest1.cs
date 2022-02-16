using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace TestProject
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            List<string> expectedResult =
                new List<string> {"Marin Alvarez",
                    "Adonis Julius Archer",
                    "Beau Tristan Bentley",
                    "Hunter Uriah Mathew Clarke",
                    "Leo Gardner",
                    "Vaughn Lewis",
                    "London Lindsey",
                    "Mikayla Lopez",
                    "Janet Parsons",
                    "Frankie Conner Ritter",
                    "Shelby Nathan Yoder"
                };

            List<string> result = NameSorterApp.FluentNameSorter
                .GetNameSorter(new string[] { @"./unsorted-names-list.txt" })
                .ValidateInputParam()
                .ValidateInputFile()
                .ReadInputFile()
                .SortByLastNames()
                .GetSortedNameList();

            Assert.True(result.SequenceEqual(expectedResult));
        }
    }
}
