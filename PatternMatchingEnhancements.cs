using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deep_Dive_CSharp_11_12;
internal static class PatternMatchingEnhancements
{
    public static void Run()
    {
        Console.WriteLine("Pattern Matching Enhancements (C# 12)");
        Console.WriteLine("");

        //Before
        object obj = "Hello";
        if (obj is string s && s.Length > 5)
        {
            Console.WriteLine($"Long string: {s}");
        }

        //After
        if (obj is string { Length: > 5 } s1)
        {
            Console.WriteLine($"Long string: {s1}");
        }

        //Complex example
        var list = new List<object> { 1, 2, 3, 4, "five", "six", 7.0, 8.0, 9.0, 10.0 };
        if (list is [1, 2, 3, 4, "five", "six", double d1, double d2, double d3, double d4])
        {
            Console.WriteLine($"The list starts with 1, 2, 3, 4, \"five\", \"six\", {d1}, {d2}, {d3}, {d4}");
        }
        else
        {
            Console.WriteLine("The list does not start with 1, 2, 3, 4, \"five\", \"six\"");
        }

        Console.WriteLine("");
    }
}
