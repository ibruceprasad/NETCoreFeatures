using FluentAssertions;
using Practice_.Net8.src.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_.Net8_Tests._2.GenericTests
{
    public class Apple : BaseFruit
    {
        public bool HasSeed { get; set; }
    }
    public class Banana : BaseFruit
    {
        public int PottassiumPercentage { get; set; }
    }

    public class GenericClassTests
    {
        [Fact]
        public void GenerateGenericFruitObjectForApple()
        {
            // 1. Generate an object of type Apple from generic Fruit class  
            var apple = new Apple() { Name="naval Apple", Color="Red", HasSeed = true};
            var fruit = new Fruit<Apple>(apple);
            var item = fruit.GetFruit();
            
            item.Should().BeEquivalentTo(apple);
  
        }
    }
}
