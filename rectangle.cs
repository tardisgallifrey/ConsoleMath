using System;

namespace ConsoleMath
{
    public class rectangle
    {
        public rectangle()
        {
            //Calculates certain formulas about rectangles and squares.
        }

        public double Area()
        {
            double area = 0;
            int choice = 0;
            double length;
            double width;
            double side;

            Console.WriteLine("Is this a 1) rectangle or a 2) square?");
            choice = Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    Console.WriteLine("Enter the length of the rectangle.");
                    length = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter the width of the rectangle.");
                    width = Convert.ToDouble(Console.ReadLine());
                    area = length * width;
                    break;
                case 2:
                    Console.WriteLine("Enter the length of a side of the square.");
                    side = Convert.ToDouble(Console.ReadLine());
                    area = side * side;
                    break;
                default:
                    Console.WriteLine("You didn't choose a rectangle or square.\nSorry, quitting.");
                    break;

            }


            return area;
        }
    }
}