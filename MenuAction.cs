using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleMath
{
    public class MenuAction
    {
        public MenuAction()
        {
           Console.WriteLine("Running Action.");
        }

        public int runAction(int option, IList<KeyValuePair<string, int>> MenuOptionList)
        {

             KeyValuePair<string, int> result = MenuOptionList.SingleOrDefault(x => x.Value == option);
                //Console.WriteLine($"You chose option {result.Value}");

                switch (result.Value)
                {
                    case 1:
                        var myCircleArea = new circle();
                        var circlearea = myCircleArea.Area();
                        if(circlearea > 0.00)
                        {
                            Console.WriteLine($"The area of your circle is: {circlearea}.");
                        }
                        else
                        {
                            Console.WriteLine("Something went wrong. Sorry, quitting.");
                        }
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
                    default:
                        break;
                }
                Console.WriteLine("Press any key to return to menu.");
                
                return result.Value;

        }
    }
}