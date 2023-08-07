using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Objects
{
    internal interface IPeople
    {
        string Name { get; set; }
        byte Age { get; set; }
        DateOnly DateOfBirthd { get; set; }
        Guid PassportID { get; set; }
    }
}
