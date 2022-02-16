using System;
using NameSorterApp.FluentNameSorterInterfaces;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace NameSorterApp
{
    public class FluentNameSorter :
        INameSorterStage,
        IValidateInputParamStage,
        IValidateInputFileStage,
        IReadInputFileStage,
        ISortNamesStage

    {
        private string[] _args;
        private string _path = string.Empty;
        List<string> _nameList;
        string _allNames = string.Empty;

        private FluentNameSorter(string[] args)
        {
            this._args = args;
        }

        public static INameSorterStage GetNameSorter(string[] args)
        {
            return new FluentNameSorter(args);
        }

        public IValidateInputParamStage ValidateInputParam()
        {
            if (_args.Length == 1 && !string.IsNullOrWhiteSpace(_args[0])) _path = _args[0];
            else throw new NameSorterException("Invalid args...");
            return this;
        }

        //Validate input file
        public IValidateInputFileStage ValidateInputFile()
        {
            if (!File.Exists(_path)) throw new NameSorterException("File not exsist..");
            return this;
        }

        
        public IReadInputFileStage ReadInputFile()
        {
            string text = File.ReadAllText(_args[0]);
            _nameList = text.Split(Environment.NewLine).ToList();
            return this;
        }

        //Sort name by last name
        public ISortNamesStage SortByLastNames()
        {
            _nameList = _nameList.OrderBy(x => x.Split(' ').LastOrDefault()).Select(x => x.Trim()).ToList();
            _allNames = string.Join(Environment.NewLine, _nameList).Trim();
            return this;
        }

        public ISortNamesStage DisplayNames()
        {
            Console.WriteLine(_allNames);
            return this;
        }

        //Sorted names generated to sorted-names-list.txt file
        public ISortNamesStage WriteNames()
        {
            File.WriteAllText(@"./sorted-names-list.txt", _allNames);
            Console.WriteLine("File genarated successfuly...");
            return this;
        }

        //Get name list
        public List<string> GetSortedNameList()
        {
            return _nameList;
        }
    }
}
