using System;

//2.2
namespace Program02
{
    class Program
    {
        static void test1()
        {
            //2-2
            byte a;
            int b = 100;
            a = (byte)b;
            Console.WriteLine("byte=" + a);

            Console.WriteLine("\n回车 2-3\n");
            Console.ReadKey();
        }

        static void test2()
        {
            //2-3
            int b1 = 3;
            byte b2 = 4;
            byte b3 = (byte)(b1 + b2);
            Console.WriteLine("b3=" + b3);

            Console.WriteLine("\n回车 2-4\n");
            Console.ReadKey(true);
        }

        static void test3()
        {
            //2-4
            int x = 12;
            {
                int y = 96;
                Console.WriteLine("x is " + x);
                Console.WriteLine("y is " + y);
            }
            Console.WriteLine("x is " + x);
            Console.ReadKey();
        }

        static void Main(string[] args)
        {

            test1();
            test2();
            test3();
        }
    }
}