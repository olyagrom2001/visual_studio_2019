using System;

namespace Lab6_1
{
    class Program
    {
        delegate int Function(int a, int b);
        static int Sum(int a, int b)
        {
            return a + b;
        }
        static void Manager(int a, int b, Function f) 
            => Console.WriteLine(f(a, b));

        static void ManagerF(int lhs, int rhs, Func<int, int, int> f)
            => Console.WriteLine(f(lhs, rhs));
        static void Main(string[] args)
        {
            Manager(1, 2, Sum);
            Manager(1, 2, (lhs, rhs) => lhs + rhs);
            ManagerF(1, 2, Sum);
            Manager(1, 2, (lhs, rhs) => lhs + rhs);
        }
    }
}
