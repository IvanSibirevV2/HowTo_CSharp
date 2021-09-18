using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenTK.Graphics.OpenGL;

namespace WindowsFormsApp1.V1
{
    public class GlObj
    {
        public List<Point2D> LPoint2D = new List<Point2D>();
        public OpenTK.Graphics.OpenGL.BeginMode BeginMode = OpenTK.Graphics.OpenGL.BeginMode.Points;
        ////////////////////////////////////////////////////////////
        public GlObj Rendering() 
        {
            GL.Begin(this.BeginMode);
            foreach(Point2D _Point2D in this.LPoint2D) 
            {
                ;
                if(_Point2D.Color!=null) GL.Color3(_Point2D.Color.R, _Point2D.Color.G, _Point2D.Color.B);
                GL.Vertex2(_Point2D.X, _Point2D.Y);
            }
            GL.End();
            return this;
        }
    }
}
