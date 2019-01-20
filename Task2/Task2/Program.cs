using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            double height1 = 0.0;
            double width1 = 0.0;

            double height2 = 0.0;
            double width2 = 0.0;

            double area1 = 0.0;
            double area2 = 0.0;

            Console.WriteLine("Please enter height of first rectangle.");
            height1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter width of first rectangle.");
            width1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter height of second rectangle.");
            height2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter width of second rectangle.");
            width2 = double.Parse(Console.ReadLine());

            area1 = height1 * width1;
            area2 = height2 * width2;

            if (area1 > area2)
            { 
                Console.WriteLine("First rectangle with area " + area1 +
                    " unit sq is larger than the area of the second rectangle with area "
                    + area2 + " square units");
            }

            else if (area1 == area2)
                    {
                Console.WriteLine("Both rectangles have " + area1 + "  and are same size");
                    }
            else
            	 Console.WriteLine("Second rectangle with area " + area2+

                    " unit sq is larger than the area of the first rectangle with area" +

                    "  area1" +" square units");
            
            Console.ReadLine();
        }
    }
}