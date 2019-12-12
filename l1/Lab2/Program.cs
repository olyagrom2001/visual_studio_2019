using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle a = new Circle(10);
            Rectangle b = new Rectangle(1, 3);
            Square c = new Square(2);
            a.Print();
            b.Print();
            c.Print();

            Console.ReadKey();
        }
    }
}
