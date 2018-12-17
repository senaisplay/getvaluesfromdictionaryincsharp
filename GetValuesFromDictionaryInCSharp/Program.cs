using System;
using System.Collections.Generic;

namespace GetValuesFromDictionaryInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var namesAndAges = new Dictionary<string, int>();
            namesAndAges["Roberto"] = 17;
            namesAndAges["Helena"] = 19;
            //
            foreach (var item in namesAndAges)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }
        }
    }
}
