using System;
using MenuClass;
using MathFormulas;
using ConsoleMath.WindowClass;


namespace ConsoleMath
{
    class Program
    {
        static void Main(string[] args)
        {
            var MyMenu = new Menu();

            //Reads string into Menu._MenuOptionList[firstemptyindex]
            //
            //in simpler terms, build your menu
            MyMenu.MenuOptionAdd("3) Calculate the area of a triangle.", 3);
            MyMenu.MenuOptionAdd("Choose from the following options", 0);
            MyMenu.MenuOptionAdd("1) Circles and circular shapes.", 1);
            MyMenu.MenuOptionAdd("2) Calculate the area of a square or rectangle.", 2);
            MyMenu.MenuOptionAdd("4) Open an OpenGL Window.", 4);

            int showMenu = 1;
            while (showMenu > 0)
            {
                
                //When showMenu returns a 0, then Program stops
                showMenu = MyMenu.ShowMenu();

                switch(showMenu)
                {

                    case 1:
                        var docircles = new circle();
                        docircles.CircleMenu();
                        break;
                    case 2:
                        var myRectangleArea = new rectangle();
                        var rectarea = myRectangleArea.Area();
                        if(rectarea > 0.00)
                        {
                            Console.WriteLine($"The area of your rectangle or square is: {rectarea}");
                        }
                        else
                        {
                            Console.WriteLine("Something went wrong. Sorry, quitting.");
                        }
                        break;
                    case 3:
                        var myTriangleArea = new triangle();
                        var triarea = myTriangleArea.Area();
                        if(triarea > 0.00)
                        {
                            Console.WriteLine($"The area of your triangle is: {triarea}");
                        }
                        else
                        {
                            Console.WriteLine("Something went wrong. Sorry, quitting.");
                        }
                        break;
                    case 4:
                        //Open an OpenGL window (OpenTK)
                        var win = new TriWindow();
                        break;
                     default:
                        Console.Clear();
                        System.Environment.Exit(0);
                        break;
                }
                Console.WriteLine("Press any key to return to main menu");
                Console.ReadKey();
            }
            /* TODO:
                
                Add more math classes/methods


            */
           
        }
    }
}
