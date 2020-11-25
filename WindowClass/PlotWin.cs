using Gtk;

namespace WindowClass
{
    public class PlotWin
    {
        public PlotWin()
        {
            Application.Init();

            //Create the Window
            Window myWin = new Window("My first GTK# Application! ");
            myWin.Resize(200,200);

            myWin.DeleteEvent += delegate { Application.Quit(); };
            //Show Everything
            myWin.ShowAll();

            Application.Run();
        }

        
    }
}