using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace charts
{
    interface IFunction
    {
        string FunctionName
        {
            get;
        }
        string FunctionName2
        {
            get;
        }
        double Value(double x);
        double Value2(double x);
        event emptyFunction FunctionChanged;
    }
    public delegate void emptyFunction();
}
