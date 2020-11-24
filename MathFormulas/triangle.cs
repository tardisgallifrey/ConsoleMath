using System;

namespace MathFormulas
{
    public class triangle
    {
        public triangle()
        {
            //calculates certain formulas about triangles
        }

        public double Area()
        {
            double area = 0;
            double baselength;
            double heightlength;


            Console.WriteLine("Enter the length of the base of the triangle.");
            baselength = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the length of the height of the triangle.");
            heightlength = Convert.ToDouble(Console.ReadLine());

            if(baselength > 0.00 && heightlength > 0.00)
            {
                area = (baselength / 2.0) * heightlength;
            }
            else
            {
                Console.WriteLine("You did not enter a valid base or height.\nSorry, quitting.");
            }
    

            return area;

        }
    }
}