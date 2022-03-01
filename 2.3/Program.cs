namespace Program05
{
    class Program
    {
        static void Main(string[] args)
        {
            //2-5
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            bool res1, res2;

            res1 = num1 > 0 & num2++ > 1;
            Console.WriteLine(res1);
            Console.WriteLine("num2 = "+num2);
            res2 = num2 > 0 && num3++ > 1;
            Console.WriteLine(res2);
            Console.WriteLine("num3 = "+num3);

            Console.ReadKey();
        }
    }
}