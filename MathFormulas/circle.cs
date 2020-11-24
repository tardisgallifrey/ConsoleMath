using System;
using MenuClass;


namespace MathFormulas
{
    public class circle
    {
        public circle()
        {
            //Calculates certain formulas about circles.
        }       

        public void CircleMenu()
        {

            var CircleMenu = new Menu();

            //Reads string into Menu._MenuOptionList[firstemptyindex]
            //
            //in simpler terms, build your menu
            CircleMenu.MenuOptionAdd("Choose a circle formula.", 0);
            CircleMenu.MenuOptionAdd("1) Area of a circle.", 1);

            int showMenu = 1;
            while (showMenu > 0)
            {
                //When showMenu returns a 0, then Program stops
                showMenu = CircleMenu.ShowMenu();

                switch(showMenu)
                {

                    case 1:
                        var area = this.Area();
                        if(area > 0.00)
                        {
                            Console.WriteLine($"The area of your circle is {area}");
                            Console.WriteLine("Press any key to return to circle menu.");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Something went wrong, Sorry, quitting.");
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        private double Area()
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