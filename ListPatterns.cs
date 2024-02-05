using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deep_Dive_CSharp_11_12;
internal static class ListPatterns
{
    public static void Run()
    {
        Console.WriteLine("List Patterns (C# 11)");
        Console.WriteLine("");

        //List Patterns (C# 11)
        //Before
        var numbers = new List<int> { 1, 2, 3, 4 };

        bool startsWithOneTwoThree = numbers.Count >= 3 &&
                                     numbers[0] == 1 &&
                                     numbers[1] == 2 &&
                                     numbers[2] == 3;
        Console.WriteLine(startsWithOneTwoThree);

        //After
        startsWithOneTwoThree = numbers is [1, 2, 3, ..];
        Console.WriteLine(startsWithOneTwoThree);

        //Complex example for list patterns
        var list = new List<object> { 1, 2, 3, 4, "five", "six", 7.0, 8.0, 9.0, 10.0 };
        if (list is [1, 2, 3, ..var rest])
        {
            Console.WriteLine($"The list starts with 1, 2, 3 and the rest of the list is {string.Join(", ", rest)}");
        }
        else
        {
            Console.WriteLine("The list does not start with 1, 2, 3");
        }

        Console.WriteLine("");
    }
}
