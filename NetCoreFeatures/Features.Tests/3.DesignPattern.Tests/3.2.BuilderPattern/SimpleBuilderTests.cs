using NET8_Features.src._3.DesignPattern._3._2_Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_.Net8_Tests._3.DesignPattern.Tests._3._2.BuilderPattern
{
    public class SimpleBuilderTests
    {

        [Fact]
        public void Test_StudentBuilderPattern()
        {
            var actualstudent = new Student(1, "Lal", default(int));
            var student = SimpleBuilder.Default()
                .SetId(actualstudent.Id)
                .Build();
            Assert.NotNull(student);
            Assert.Equal(actualstudent.Id, student.Id);  
        }
    }
}
