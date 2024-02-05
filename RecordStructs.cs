using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deep_Dive_CSharp_11_12;

internal static class RecordStructs
{
    //Before
    public class Point
    {
        public int X { get; }
        public int Y { get; }

        public Point(int x, int y) => (X, Y) = (x, y);

        public override bool Equals(object obj) => obj is Point other && X == other.X && Y == other.Y;
        public override int GetHashCode() => HashCode.Combine(X, Y);
    }

    //After
    public record struct Point11(int X, int Y);

    public static void Run()
    {
        Console.WriteLine("Record Structs (C# 11)");
        Console.WriteLine("");

        Point11 p1 = new(1, 2);
        Point11 p2 = new(1, 2);
        Console.WriteLine(p1 == p2); //True
        Console.WriteLine(p1.Equals(p2)); //True
        Console.WriteLine(p1.GetHashCode() == p2.GetHashCode()); //True

        Console.WriteLine("");
    }
}
