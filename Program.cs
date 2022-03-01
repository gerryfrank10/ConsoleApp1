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

            //ForEach loop
            char[] myArray = { 'H', 'e', 'l', 'l', 'o' };
            foreach(char ch in myArray)
            {
                Console.WriteLine(ch);
            }

        }
    }
}