using FluentAssertions;
using Practice_.Net8.src.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_.Net8_Tests._2.Generic.Test
{

    public class GenericFunctionTests
    {
    
        [Fact]
        public void  GivenAnyNumericValues_ReturnResult()
        {
            Compute compute = new Compute();
            // Case 1:  Compiler find the type at run time
            var result1 = compute.Add_1(10, 20.5);      // 30.5

            // Case 2: Enforces you to pass the type
            var result2 = compute.Add_1<int>(10, 20);    // 30, you can't pass 20.5 here
            result1.Should().Be(30.5);
            result2.Should().Be(30);
            result1.Should().BeOfType(typeof(double));
            result2.Should().BeOfType(typeof(int));



        }
    }
}
