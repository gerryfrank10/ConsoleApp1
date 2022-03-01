using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(String[] args)
        {
            int num;
            Console.Write("Enter the number : ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The number is {0}", num);
        }
    }
}