using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(String[] args)
        {
            //For loop
            for(int i=0; i<20; i++)
            {
                Console.WriteLine("The value of i is : {0} ", i);
            }

            //Arays
            int[] p = new int[] { 1, 2, 3, 4 };
            Console.WriteLine("p for : {0}", p[1]); // we expect 2

            //ForEach loop
            char[] myArray = { 'H', 'e', 'l', 'l', 'o' };
            foreach(char ch in myArray)
            {
                Console.WriteLine(ch);
            }

        }
    }
}