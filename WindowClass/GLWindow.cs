using OpenTK;
using OpenTK.Graphics;

namespace WindowClass
{
    public class GLWindow : GameWindow
    {
        public GLWindow(int width, int height, string title) : base(width, height, GraphicsMode.Default, title) 
        { 
            //OpenGL Window Constructor
        }
    }
}