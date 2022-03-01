using System;

//2.2
namespace Program02
{
    class Program
    {
        static void Main(string[] args)
        {
            //2-2
            byte a;
            int b = 100;
            a = (byte)b;
            Console.WriteLine("byte="+a);

            Console.WriteLine("\n回车 2-3\n");
            Console.ReadKey();

            //2-3
            int b1 = 3;
            byte b2 = 4;
            byte b3 = (byte)(b1 + b2);
            Console.WriteLine("b3=" + b3);
            
            Console.WriteLine("\n回车 2-4\n");
            Console.ReadKey(true);

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
    }
}