using OpenTK.Windowing.Desktop;
using OpenTK.Windowing.Common;
using OpenTK.Graphics.OpenGL4;
using OpenTK.Mathematics;
using System;
using System.Drawing;

struct SetColor 
       {
            public double red;
            public double green;
            public double blue;
            public double alpha;
        };

namespace ConsoleMath.WindowClass.GLclass
{
    

   sealed class GameWindow : OpenTK.Windowing.Desktop.GameWindow
   {

       SetColor BGColor;
      
       public GameWindow()
        // set window resolution, title, and default behaviour
        :base(GameWindowSettings.Default, NativeWindowSettings.Default)
        {

            Console.WriteLine("gl version: " + GL.GetString(StringName.Version));
        }
 
        public void OnResize(EventArgs e, int width, int height)
        {
            GL.Viewport(0, 0, width, height);
        }
 
        public void OnLoad(EventArgs e)
        {
            // this is called when the window starts running
           


        }
 
        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            // this is called every frame, put game logic here
        }
 
        protected override void OnRenderFrame(FrameEventArgs e)
        {
                       
            GL.ClearColor((float)BGColor.red, (float)BGColor.green, (float)BGColor.blue, (float)BGColor.alpha);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            SwapBuffers();
        }

        
        public void SetBGColor(double red, double green, double blue, double alpha)
        {
            BGColor.red = red;
            BGColor.green = green;
            BGColor.blue = blue;
            BGColor.alpha = alpha;
        }
   }
}