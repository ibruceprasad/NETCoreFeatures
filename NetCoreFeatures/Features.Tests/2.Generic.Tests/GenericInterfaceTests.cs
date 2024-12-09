using FluentAssertions;
using Practice_.Net8.src.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_.Net8_Tests._2.Generic.Test
{

    class StudentEntity : EntityBaseClass
    {
        public string Address;
    }
    class VegEntity : EntityBaseClass
    {
        public string Color;
    }

    public class GenericInterfaceTests
    {

        [Fact]
        public void GenerateGenericEntityOfTypeStudentEntity()
        {
            var students = new Entity<StudentEntity>();
            students.AddItem(new StudentEntity() { Id = 1, Address = "Melbourne" });
            students.AddItem(new StudentEntity() { Id = 2, Address = "Sydney" });

            students.Should().BeOfType<Entity<StudentEntity>>();

            var first = students.GetItem(1);
            var x = first.Address;
        }

    }
}
