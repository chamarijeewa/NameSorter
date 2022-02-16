using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorterApp.FluentNameSorterInterfaces
{
    public interface ISortNamesStage
    {
        public List<string> GetSortedNameList();
        public ISortNamesStage DisplayNames();

        public ISortNamesStage WriteNames();

    }
}