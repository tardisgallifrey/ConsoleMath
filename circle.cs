using System;


namespace ConsoleMath
{
    public class circle
    {
        public circle()
        {
            //Calculates certain formulas about circles.
        }       

        public double Area()
        {
                double area = 0;
                double diameter = 0;
                double radius = 0;
                double pi = 3.14197;
                int choice = 0;
            
                Console.WriteLine("Do you wish to enter a 1) diameter or 2) a radius?");

                choice = Convert.ToInt32(Console.ReadLine());

                switch(choice)
                {

                    case 1:
                        Console.WriteLine("Enter the diameter of the circle.");
                        diameter = Convert.ToDouble(Console.ReadLine());
                        area = ( diameter / 2.00) * (diameter / 2.00) * pi;
                        break;
                    case 2:
                        Console.WriteLine("Enter the radius of the circle.");
                        radius = Convert.ToDouble(Console.ReadLine());
                        area = radius * radius * pi;
                        break;
                    default:
                        Console.WriteLine("Sorry, you did not enter a 1 or 2.\nQuitting calculation.");
                        break;
                }
                

                return area;
        }
    }

}