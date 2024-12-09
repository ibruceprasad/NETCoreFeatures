using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET8_Features.src._3.DesignPattern._3._2_Builder
{
    public class Student(int Id, string Name, int Age)
    {
        public int Id { get; init; }
        public string Name { get; init; }
        public int Age { get; init; }
    }

    public class SimpleBuilder
    {
        int Id;
        string Name;
        int Age;
        private SimpleBuilder() { }
        public SimpleBuilder SetId(int id) { this.Id = id; return this; }
        public SimpleBuilder SetName(string name) { this.Name = name; return this; }
        public SimpleBuilder SetAge(int age) { this.Age = age; return this; }
        public static SimpleBuilder Default() => new SimpleBuilder();


        public Student Build()
        {
            return new Student(Id, Name, Age);
        }

    }
}
