using OpenTK.Mathematics;
using System.Drawing;

        

namespace ConsoleMath.WindowClass.GLclass
{
    public struct ColorVertex
        {
            public const int Size = (3 + 4) * 4; // size of struct in bytes

            private readonly Vector3 position;
            private readonly  Color color;

            public ColorVertex(Vector3 position, Color color)
            {
                this.position = position;
                this.color = color;
            }
        };
}