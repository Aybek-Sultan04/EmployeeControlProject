using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Objects
{
    internal interface IEmployee : IPeople
    {
        string JobTitle { get; set; }
        decimal Salary { set; get; }
        DateOnly Hire_Time { get; set; }
    }
}
