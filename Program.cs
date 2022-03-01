using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(String[] args)
        {
            const double pi = 3.14;

            double r;
            Console.Write("Enter the radius of the circle : ");
            r = Convert.ToDouble(Console.ReadLine());

            double area = pi * r;
            Console.WriteLine("The area of the circle is {0} ", area);
        }
    }
}