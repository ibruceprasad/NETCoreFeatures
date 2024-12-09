using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;


namespace Practice_.Net8_Tests
{
    public class RecordExample
    {

        [Fact]
        public void Test()
        {

            var namesObject1 = new string[] { "dotted", "lined" };
            var namesObject2 = new string[] { "dotted", "lined" };


            var rec1 = new Circle1(20, namesObject1);
            var rec2 = new Circle1(20, namesObject2);

            //false : namesObject1 is not a value based property. Equality comparisons (== and Equals) for record types are based on the values of all members (both fields and properties) of the record, rather than reference equality. 
            var result = rec1 == rec2;
            Assert.False(result);

            // Soln: 
            var namesRecord1 = new RecordNames("dotted", "lined");
            var namesRecord2 = new RecordNames("dotted", "lined");

            var a = new Circle2(20, namesRecord1);
            var b = new Circle2(20, namesRecord2);
            result = a == b;
            Assert.True(result);


            var rec = new Circle4(10);
            //rec.Radius is not accessible; use below method
            rec.GetRadius();


        }
    }
}
