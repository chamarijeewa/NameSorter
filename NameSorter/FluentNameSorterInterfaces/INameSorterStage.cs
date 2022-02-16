using System;
using NameSorterApp.FluentNameSorterInterfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorterApp.FluentNameSorterInterfaces
{
    public interface INameSorterStage
    {
        public IValidateInputParamStage ValidateInputParam();
    }
}
