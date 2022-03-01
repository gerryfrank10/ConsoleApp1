using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(String[] args)
        {
            int i = 10;
            double j = 3.2;

            bool b = true;

            Console.WriteLine(i.ToString());
            Console.WriteLine(j.ToString());
            Console.WriteLine(b.ToString());

            Console.WriteLine("Now performing typecasting");
            int z;
            z = (int)j;
            Console.WriteLine("Z is {0}", z.GetType());
        }
    }
}