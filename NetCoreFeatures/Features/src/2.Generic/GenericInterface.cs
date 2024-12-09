using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_.Net8.src.Generic
{
    public class EntityBaseClass
    {
        public int Id { get; set; }
    }

    interface IDBRepository<T> where T : EntityBaseClass
    {
        List<T> Items { get; set; }
        T AddItem(T item);
        T GetItem(int id);
    }


    public class Entity<T> : EntityBaseClass, IDBRepository<T> where T : EntityBaseClass
    {
        public List<T> Items { get; set; }

        public Entity()
        {
            Items = new List<T>();
        }
        public T AddItem(T item)
        {
            Items.Add(item);
            return item;
        }
        public T GetItem(int id) => Items.Where(item => item.Id == id).FirstOrDefault()!;
    }
}




