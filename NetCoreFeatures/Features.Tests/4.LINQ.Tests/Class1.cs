using NET8_Features.src;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_.Net8_Tests._4.Linq
{
    public class Class1
    {
        [Fact]
        public void Test()
        {
            var employee = new EmployeeLinq();
            employee.Display();


        }
    }
}
