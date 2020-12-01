using System;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;


namespace ConsoleMath.WindowClass
{
    public sealed class Window : GameWindow
    {
        int Xadjust {get;set;}
        int Yadjust {get;set;}

        public Window(int width, int height)
            :base(width, height)
        {
            
        }

        protected sealed override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            Title = "Math Function Plotter";
            GL.ClearColor(Color.White);
        }

        protected sealed override void OnRenderFrame(FrameEventArgs e)
        {
            base.OnRenderFrame(e);

            Xadjust = 10;
            Yadjust = 10;

            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.ClearColor(Color.White);

            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            //Set screen to put 0,0 in lower left corner
            GL.Ortho(0, Width, 0,Height, -1, 1);

            //Draw the X-axis of my plot area
            GL.Begin(PrimitiveType.Lines);
                GL.Color3(Color.Black); 
                GL.Vertex2(0, Yadjust); 
                GL.Vertex2(Width - Xadjust,Yadjust);   // x, y
               GL.Flush();
            GL.End();

            //Draw the Y-axis of my plot area
            GL.Begin(PrimitiveType.Lines);
                GL.Color3(Color.Black);
                GL.Vertex2(Xadjust,0);
                GL.Vertex2(Xadjust,Height - Yadjust);
                GL.Flush();
            GL.End();

            //Draw a line of points beginning at our arbitrary 0,0, 
            //which is 10,10 on the screen.
            //Up to the maximum of our screen width - Xadjust
            GL.Begin(PrimitiveType.Points);
                GL.Color3(Color.Blue);
                for(int count = 0; count < Width - Xadjust;count++)
                {
                    double y = (double) count * (double) count;
                    GL.Vertex2((double) count + (double) Xadjust, y + (double) Yadjust);
                }
                GL.Flush();
            GL.End();

            SwapBuffers();
        }

        protected sealed override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            GL.Viewport(ClientRectangle.X, ClientRectangle.Y, ClientRectangle.Width, ClientRectangle.Height);
            Matrix4 projection = Matrix4.CreatePerspectiveFieldOfView((float)Math.PI / 4,
             Width / (float)Height, 1.0f, 64.0f);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix(ref projection);
        }

        protected sealed override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);
        }

        protected sealed override void OnKeyDown(KeyboardKeyEventArgs e)
        {
            base.OnKeyDown(e);
        }

        protected sealed override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
        }
    }
}