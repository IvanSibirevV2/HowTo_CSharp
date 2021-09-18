using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Graphics.OpenGL;

namespace WindowsFormsApp1.V0
{
    public static class Paint
    {
        /// <summary>
        /// Если писать на чистом OpenTK
        /// </summary>
        public static void Do(System.Double __X,System.Double __Y) 
        {
            GL.Begin(BeginMode.LineStrip);
            GL.Color3(0.5, 0.2, 0.2);
            GL.Vertex2(__X - 0.1, __Y - 0.5);
            GL.Vertex2(__X - 0.4, __Y - 0.5);
            GL.Vertex2(__X - 0.4, __Y - 0.9);
            GL.Vertex2(__X - 0.1, __Y - 0.9);
            GL.Vertex2(__X - 0.1, __Y - 0.5);
            GL.Vertex2(__X - 0.25, __Y - 0.1);
            GL.Vertex2(__X - 0.4, __Y - 0.5);
            GL.End();
        }
    }
}
