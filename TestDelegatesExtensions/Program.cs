using System;
using System.Collections.Generic;
using TestDelegatesExtensions.Extensions;

namespace TestDelegatesExtensions
{
    class Program
    {
        static void Main(string[] args)
        {
            ICollection<int> empty = new List<int>();
            ICollection<string> colors = new List<string> 
            { 
                "red", "blue", "green", "magenta", "yellow", "cyan", "purple", "orange", "azure", "black", "white","gray","brown","gold", "silver", "red", "yellow", "purple", "green", "green", "red", "red"
            };

            Console.WriteLine(colors.RandomElement());
            Console.WriteLine(colors.RandomElement());

            Console.WriteLine("dej dva náhodné, krátké:");
            foreach (var item in colors.RandomElementsWhere(el => el.Length < 4, 2))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("více než 3×:");
            foreach (var item in colors.AppearanceGreaterThen(3))
            {
                Console.WriteLine(item);
            }
        }
    }
}
