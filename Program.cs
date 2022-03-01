using System;

namespace ConsoleApp1
{
    class Reactangle
    {
        //member variables
        double length;
        double width;

        public void AcceptDetails()
        {
            length = 4.2;
            width = 2.3;
        }
        public double GetArea()
        {
            double area = length * width;
            return area;
        }
        public void DisplayDetails()
        {
            Console.WriteLine("The Application for area of objects");
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width {0}", width);
            Console.WriteLine("Area {0}", GetArea());
        }
    }

    class ExecuteRectangle
    {
        static void Main(String[] args)
        {
            Reactangle r = new Reactangle();
            r.AcceptDetails();
            r.DisplayDetails();
        }
    }
}