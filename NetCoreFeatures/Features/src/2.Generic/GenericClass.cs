using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Practice_.Net8.src.Generic
{
    // A generic Class defines a class name with a placeholder  Eg:  class Veg<T> { } 
    // A generic class has a generic type parameter  
    // This enforces you to specify the real type of the placeholder T at runtime

    // : BaseFruit ---> Fruit dervived from BaseFruit
    // where T : BaseFruit  ---> the base type of T is BaseFruit
    public class Fruit<T> : BaseFruit where T : BaseFruit 
    {
        T FruitItem;
        public Fruit(T item)
        {
            FruitItem = item;
        }
         
        public T GetFruit() => FruitItem;
    }

    public class BaseFruit
    {
        public string Name { get; set; }
        public string Color { get; set; }

    }

}

/*
Apple apple = new Apple() { Name = "Gala Apple", Color = "Red" };
Fruit<Apple> f = new Fruit<Apple>(apple);
f.DisplayInfo();

*/
