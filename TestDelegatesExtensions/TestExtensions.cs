using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TestDelegatesExtensions.Extensions
{
    public static class TestExtensions
    {
        static Random rand = new Random();

        public static T RandomElement<T>(this IEnumerable<T> collection)
        {
            if (collection.Count() > 0)
                return collection.ElementAt(rand.Next(0, collection.Count()));
            return default;
        }

        public static IEnumerable<T> RandomElementsWhere<T>(this IEnumerable<T> collection, Func<T, bool> predicate, int count = 1)
        {
            return collection.Where(predicate).OrderBy(itm => rand.NextDouble()).Take(count);
        }

        public static IEnumerable<T> AppearanceGreaterThen<T>(this IEnumerable<T> collection, int minCount)
        {
            var col = collection
                .GroupBy((itm) => itm, (p, k) => new { item = p, count = k.Count() })
                .Where((itm) => itm.count >= minCount)
                .Select(itm => itm.item);
            return col;
        }
    }
}