using System;
using System.Collections.Generic;

namespace FactoryDesignPattern
{
    public class Factory<T>
    {
        private Factory() { }

        static readonly Dictionary<int, Func<T>> Dict = new Dictionary<int, Func<T>>();

        public static T Create(int id)
        {
            if (Dict.TryGetValue(id, out var constructor))
            {
                return constructor();
            }

            throw new ArgumentException($"No type registered for this {id}");
        }

        public static void Register(int id, Func<T> ctor)
        {
            Dict.Add(id, ctor);
        }
    }
}
