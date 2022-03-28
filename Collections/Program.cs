using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<Entity> entities = new List<Entity> 
            {
                new Entity{Id = 1, ParentId = 0, Name = "Root entity"},
                new Entity{Id = 2, ParentId = 1, Name = "Child of 1 entity"},
                new Entity{Id = 3, ParentId = 1, Name = "Child of 1 entity"},
                new Entity{Id = 4, ParentId = 2, Name = "Child of 2 entity"},
                new Entity{Id = 5, ParentId = 4, Name = "Child of 4 entity"}
            };

            Dictionary<int, List<Entity>> parents = GetParents(entities);
            Console.WriteLine(parents);
        }

        static Dictionary<int, List<Entity>> GetParents(List<Entity> entities)
        {
            Dictionary<int, List<Entity>> parents = new Dictionary<int, List<Entity>>();
            foreach (Entity e in entities)
            {
                parents.TryAdd(e.ParentId, new List<Entity>());
                parents[e.ParentId].Add(e);
            }

            return parents;
        }

    }
}
