using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CustomLinq
{
    static class LinqExtentions
    {
        public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> collection, Func<T, bool> predicate) 
        {
            return collection.Where(x => predicate(x) == false);
        } 

        public static IEnumerable<T> Repeat<T>(this IEnumerable<T> collection, int count) 
        {
            for (int i = 0; i < count; i++)
            {
                foreach (var item in collection)
                {
                    yield return item;
                }
            }
        } 

        public static IEnumerable<string> WhereEndsWith(this IEnumerable<string> collection, IEnumerable<string> suffixes)
        {
            foreach (var item in collection)
            {
                foreach (var suff in suffixes)
                {
                    if (item.EndsWith(suff))
                    {
                        yield return item;
                    }
                }
            }
        } 
    }
}
