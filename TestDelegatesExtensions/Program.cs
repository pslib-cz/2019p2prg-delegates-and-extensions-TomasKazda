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
        }
    }
}
