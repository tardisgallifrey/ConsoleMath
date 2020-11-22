using System;

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
            MyMenu.MenuOptionAdd("1) Calculate the area of a circle.", 1);
            MyMenu.MenuOptionAdd("2) Calculate the area of a square or rectangle.", 2);

            int showMenu = 1;
            while (showMenu > 0)
            {
                //When showMenu returns a 0, then Program stops
                showMenu = MyMenu.ShowMenu();
            }
            
           
        }
    }
}
