using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Practice_.Net8.src.Generic
{
    // Generic Class - A class with a placeholder type as parameter ( eg: T age) 
    // A generic method can belong to a Generic Class  or Non-generic Class
    // Compute is Non generic class ( because no placeholder type), but it has a generic function 
    // In generic function add a placeholder <T> just after the funation name
    // The <T> syntax indicates that T is a placeholder for a type parameter that can be specified when the method is called

    // Any explict conversions
    // option 1 - return value 
    //return (T) Convert.ChangeType(retval, typeof(T));
    // option 2 - return value
    //return (T) (object) retval;

    public class Compute
    {
        public T Add_1<T>(T item1, T item2) where T : INumber<T> 
            => item1 + item2;
        
        public T Add_2<T>(T item1, T item2) 
            => (dynamic)item1 + (dynamic)item2;
        
        public T Subtract<T>(T item1, T item2) where T : INumber<T> 
            => item1 - item2;
    }

    public class Powers
    {
        T GenericSquareFunction<T>(T param) where T : INumber<T>
        {
            T temp = param;
            return param * param;
        }
    }

}