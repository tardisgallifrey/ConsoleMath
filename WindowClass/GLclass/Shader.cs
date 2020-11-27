using OpenTK.Graphics.OpenGL4;

namespace ConsoleMath.WindowClass.GLclass
{
    sealed class Shader
    {
        private readonly int handle;

        public int Handle { get { return this.handle; } }

        //This is both the constructor and the useable portion of the 
        //class.

        //string code needs to be changed into loading a file and extracting
        //the string.
        
        public Shader(ShaderType type, string code)
        {
            // create shader object
            this.handle = GL.CreateShader(type);

            // set source and compile shader
            GL.ShaderSource(this.handle, code);
            GL.CompileShader(this.handle);
        }
    }

    sealed class ShaderProgram
    {
        private readonly int handle;

        public ShaderProgram(params Shader[] shaders)
        {
            // create program object
            this.handle = GL.CreateProgram();

            // assign all shaders
            foreach (var shader in shaders)
                GL.AttachShader(this.handle, shader.Handle);

            // link program (effectively compiles it)
            GL.LinkProgram(this.handle);

            // detach shaders
            foreach (var shader in shaders)
                GL.DetachShader(this.handle, shader.Handle);

            
        }
    
        public int GetAttributeLocation(string name)
        {
            // get the location of a vertex attribute
            return GL.GetAttribLocation(this.handle, name);
        }

        public int GetUniformLocation(string name)
        {
            // get the location of a uniform variable
            return GL.GetUniformLocation(this.handle, name);
        }
        
        public void Use()
        {
            // activate this program to be used
            GL.UseProgram(this.handle);
        }
    }
}