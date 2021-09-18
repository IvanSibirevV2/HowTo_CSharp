using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenTK.Graphics.OpenGL;

namespace WindowsFormsApp1.V3
{
    
    public class GLObj
    {
        public List<Point2D> LPoint2D = new List<Point2D>();

        public OpenTK.Graphics.OpenGL.BeginMode BeginMode = OpenTK.Graphics.OpenGL.BeginMode.Points;

        public List<GLObj> LIMyGlObject = new List<GLObj>();

        private System.Double Native_X = 0;
        private System.Double Native_Y = 0;
        ////////////////////////////////////////////////////////
        public GLObj() { }
        public GLObj Set(
            GLObj _this =null
            , List<Point2D> _LPoint2D = null
            , System.Nullable<OpenTK.Graphics.OpenGL.BeginMode> _BeginMode=null
            , List<GLObj> _LIMyGlObject =null
            , System.Nullable< System.Double> _Native_X = null
            , System.Nullable<System.Double> _Native_Y = null
        ) 
        {
            if (_this != null)
            {
                this.Set(
                    _this: null
                    , _LPoint2D: _this.LPoint2D
                    , _BeginMode: _this.BeginMode
                    , _Native_X:_this.Native_X
                    , _Native_Y: _this.Native_Y
                );
            }
            if (_LPoint2D != null) this.LPoint2D = _LPoint2D;
            if (_BeginMode != null)this.BeginMode = _BeginMode.Value;
            if (_LIMyGlObject != null) this.LIMyGlObject = _LIMyGlObject;
            if (_Native_X != null) this.Native_X = _Native_X.Value;
            if (_Native_Y != null) this.Native_Y = _Native_Y.Value;
            return this;
        }
        ////////////////////////////////////////////////////////
        public GLObj Add(System.Double _X, System.Double _Y)
        {
            this.LPoint2D.Add(new Point2D() { X = _X, Y = _Y});
            return this; 
        }
        public GLObj Add(System.Double _X, System.Double _Y,System.Double _R,System.Double _G,System.Double _B)
        {
            this.LPoint2D.Add(new Point2D() { X = _X, Y = _Y, Color = new Color() { R=_R, G=_G, B= _B } });
            return this;
        }
        ////////////////////////////////////////////////////////////
        /// <summary>
        /// Рендеринг и есть ели честно наше обновление объекта
        /// По этому отдельно их реализовывать не обязательно
        /// </summary>
        public GLObj Rendering() 
        {
            GL.Begin(this.BeginMode);
            foreach(Point2D _Point2D in this.LPoint2D) 
            {
                ;
                if(_Point2D.Color!=null) GL.Color3(_Point2D.Color.R, _Point2D.Color.G, _Point2D.Color.B);
                GL.Vertex2(_Point2D.X, _Point2D.Y);
            }
            GL.End();
            this.LIMyGlObject.ForEach(a =>a.Rendering());
            return this;
        }
    }
}
