using System;
using System.Linq;

namespace task04
{
    public static class ExtensionClass
    {
        public static void ExtensionMethod(this int[] value)
        {
            var orderedEnumerable = value.Reverse();
            foreach (var num in orderedEnumerable)
            {
                Console.WriteLine(num);
            }
        }
    }
}