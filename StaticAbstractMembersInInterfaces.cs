using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deep_Dive_CSharp_11_12;
internal static class StaticAbstractMembersInInterfaces
{
    //Before
    public interface IMath<T>
    {
        T Add(T a, T b);
        // Static method not allowed here
    }

    public class IntMath : IMath<int>
    {
        public int Add(int a, int b) => a + b;
        public static int StaticAdd(int a, int b) => a + b;
    }


    //After
    public interface IMath12<T>
    {
        static abstract T Add(T a, T b);
    }

    public class IntMath12 : IMath12<int>
    {
        public static int Add(int a, int b) => a + b;
    }
        
    public static void Run()
    {
        Console.WriteLine("Static Abstract Members In Interfaces (C# 12)");
        Console.WriteLine("");

        var intMath = new IntMath();
        Console.WriteLine(intMath.Add(1, 2)); //3
        Console.WriteLine(IntMath.StaticAdd(1, 2)); //3

        var intMath12 = new IntMath12();
        Console.WriteLine(IntMath12.Add(1, 2)); //3

        Console.WriteLine("");
    }
}
