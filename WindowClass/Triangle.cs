using OpenTK;
using ConsoleMath.WindowClass.GLclass;
using System;

namespace ConsoleMath.WindowClass
{
    public class TriWindow
    {
        public TriWindow()
        {
            //Assign the background color
            //needs a conversion class for #FFFFFF
            double red = 0.0;
            double green = 0.0;
            double blue = 1.0;
            double  alpha = 1.0;

            //Create an OpenGL window with a triangle
            GameWindow win = new GameWindow();

            //declare an empty eventargs variable to use in OnResize
            var e = EventArgs.Empty;
            //Set window size
            win.OnResize(e, 300, 300);
            //Set Background color
            win.SetBGColor(red, green, blue, alpha);

            //Run the window
            win.Run();
        }
    }
}