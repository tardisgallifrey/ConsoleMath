using OpenTK.Graphics.OpenGL4;

namespace ConsoleMath.WindowClass.GLclass
{
    public class vertexattributedef
    {
        //To declare new Vertex Attributes
        //Not sure what some of these values should be yet.
        VertexAttribute va1 = new VertexAttribute("vPosition", 3, VertexAttribPointerType.Float, ColorVertex.Size, 0);
        VertexAttribute va2 = new VertexAttribute("vColor", 4, VertexAttribPointerType.Float, ColorVertex.Size, 0);
    }
}