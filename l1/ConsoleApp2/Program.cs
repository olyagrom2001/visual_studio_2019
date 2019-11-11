using System;

namespace ConsoleApp
{
    class Program
    {
        static void WriteInColor(string n, string s)
        {
            if (n == "red")
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            if (n == "green")
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }

            Console.WriteLine(s);
            Console.ResetColor();
        }
        static void Main(string[] args)
        {
            Console.Title = "Громова Ольга ИУ5-31Б";
            Console.WriteLine("Ax^4+Bx^2+C=0");
            Console.WriteLine("Введите коэффициенты A, B, C");

            double a, b, c;
            string A, B, C;
            
                if ((args != null) && (args.Length >= 1))
                {
                    A = args[0];
                }
                else
                {
                    Console.Write("A = ");
                    A = Console.ReadLine();
                }
                while (!double.TryParse(A, out a))
                {
                    WriteInColor("red", "Некорректный ввод!");
                    WriteInColor("red", "А: ");
                    A = Console.ReadLine();
                }
                if ((args != null) && (args.Length >= 2))
                {
                    B = args[1];
                }
                else
                {
                    Console.Write("B = ");
                    B = Console.ReadLine();
                }
                while (!double.TryParse(B, out b))
                {
                    WriteInColor("red", "Некорректный ввод!");
                    WriteInColor("red", "B: ");
                    B = Console.ReadLine();
                }
                if ((args != null) && (args.Length >= 3))
                {
                    C = args[2];
                }
                else
                {
                    Console.Write("C = ");
                    C = Console.ReadLine();
                }
                while (!double.TryParse(C, out c))
                {
                    WriteInColor("red", "Некорректный ввод!");
                    WriteInColor("red", "C: ");
                    C = Console.ReadLine();
                }  

                if ((a == 0) && (b == 0) && (c != 0))
                {
                    WriteInColor("red", "Корней нет ");
                    Console.ReadKey();
                    Environment.Exit(1);
                }

                if ((a == 0) && (b == 0) && (c == 0))
                {
                    WriteInColor("green", "Корни любые ");
                    Console.ReadKey();
                    Environment.Exit(1);

                }

                if ((a == 0) && (c / b <= 0))
                {
                    if (c / b < 0)
                    {
                        double x1, x2;
                        x1 = Math.Sqrt(-c / b);
                        x2 = -Math.Sqrt(-c / b);
                        WriteInColor("green", "x = " + x1);
                        WriteInColor("green", "x = " + x2);
                    } 
                    else
                    {
                        double x3 = 0;
                        WriteInColor("green", "x = " + x3);
                    }
                    Console.ReadKey();
                    Environment.Exit(1);
                }

                else
                {
                    if ((a == 0) && (c / b > 0))
                    {
                        WriteInColor("red", "Действительных корней нет");
                        Console.ReadKey();
                        Environment.Exit(1);
                    }
                }


                double D = b * b - 4 * a * c;
                if ((D < 0) || (D == 0 && (-b / (2 * a)) < 0))
                {
                    WriteInColor("red", "Действительных корней нет");
                }
                else
                {
                    if (D == 0 && (-b / (2 * a)) >= 0)
                    {
                        if ((-b / (2 * a)) > 0)
                        {
                            double x1, x2;
                            x1 = Math.Sqrt(-b / (2 * a));
                            x2 = -Math.Sqrt(-b / (2 * a));
                            WriteInColor("green", "x = " + x1);
                            WriteInColor("green", "x = " + x2);
                        }
                        else
                        {
                            double x3 = 0;
                            WriteInColor("green", "x = " + x3);
                        }
                    }
                    else
                    {
                    if (((-b - Math.Sqrt(D)) / (2 * a) > 0) || ((-b + Math.Sqrt(D)) / (2 * a) > 0))
                    {
                        if ((-b - Math.Sqrt(D)) / (2 * a) > 0)
                        {
                            double x1, x2;
                            x1 = Math.Sqrt((-b - Math.Sqrt(D)) / (2 * a));
                            x2 = -Math.Sqrt((-b - Math.Sqrt(D)) / (2 * a));
                            WriteInColor("green", "x = " + x1);
                            WriteInColor("green", "x = " + x2);
                            if (c == 0)
                            {
                                Console.WriteLine("x = 0");
                            }
                        }
                        if ((-b + Math.Sqrt(D)) / (2 * a) > 0)
                        {
                            double x3, x4;
                            x3 = Math.Sqrt((-b + Math.Sqrt(D)) / (2 * a));
                            x4 = -Math.Sqrt((-b + Math.Sqrt(D)) / (2 * a));
                            WriteInColor("green", "x = " + x3);
                            WriteInColor("green", "x = " + x4);
                            if (c == 0)
                            {
                                double x5 = 0;
                                WriteInColor("green", "x = " + x5);
                            }
                        }
                    }
                    else
                    {
                        WriteInColor("red", "Действительных корней нет");
                    }

                    }
                }

            Console.ReadKey();
        }
    }
}
