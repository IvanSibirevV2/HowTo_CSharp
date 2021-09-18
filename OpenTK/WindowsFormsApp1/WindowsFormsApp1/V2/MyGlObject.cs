using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenTK.Graphics.OpenGL;

namespace WindowsFormsApp1.V2
{
    
    public interface IMyGlObject 
    {
        List<Point2D> p_LPoint2D { get; set; }
        OpenTK.Graphics.OpenGL.BeginMode p_BeginMode { get; set; }
        List<IMyGlObject> p_LIMyGlObject { get; set; }
        System.Double p_Native_X { get; set; }
        System.Double p_Native_Y { get; set; }
        ////////////////////////////////////////////////////////
        IMyGlObject Set(
            IMyGlObject _this =null
            , List<Point2D> _LPoint2D = null
            , System.Nullable<OpenTK.Graphics.OpenGL.BeginMode> _BeginMode = null
            , List<IMyGlObject> _LIMyGlObject = null
            , System.Nullable<System.Double> _Native_X = null
            , System.Nullable<System.Double> _Native_Y = null
        );
        ////////////////////////////////////////////////////////
        IMyGlObject Add(Point2D _Point2D);
        IMyGlObject Add(System.Double _X, System.Double _Y);
        IMyGlObject Add(System.Double _X, System.Double _Y, Color _Color);
        IMyGlObject Add(System.Double _X, System.Double _Y, System.Double _R, System.Double _G, System.Double _B);
        ////////////////////////////////////////////////////////
        IMyGlObject Rendering();
        IMyGlObject Update_Private();
        IMyGlObject Update();
    }
    public class MyGlObject : IMyGlObject
    {
        private List<Point2D> LPoint2D = new List<Point2D>();
        public List<Point2D> p_LPoint2D { get=>this.LPoint2D; set => this.LPoint2D=value; }

        private OpenTK.Graphics.OpenGL.BeginMode BeginMode = OpenTK.Graphics.OpenGL.BeginMode.Points;
        public OpenTK.Graphics.OpenGL.BeginMode p_BeginMode { get => this.BeginMode; set => this.BeginMode = value; }

        private List<IMyGlObject> LIMyGlObject = new List<IMyGlObject>();
        public List<IMyGlObject> p_LIMyGlObject { get => this.LIMyGlObject; set => this.LIMyGlObject = value; }

        private System.Double Native_X = 0;
        public System.Double p_Native_X { get => this.Native_X; set => this.Native_X = value; }
        private System.Double Native_Y = 0;
        public System.Double p_Native_Y { get => this.Native_Y; set => this.Native_Y = value; }
        ////////////////////////////////////////////////////////
        public MyGlObject() { }
        public IMyGlObject Set(
            IMyGlObject _this =null
            , List<Point2D> _LPoint2D = null
            , System.Nullable<OpenTK.Graphics.OpenGL.BeginMode> _BeginMode=null
            , List<IMyGlObject> _LIMyGlObject =null
            , System.Nullable< System.Double> _Native_X = null
            , System.Nullable<System.Double> _Native_Y = null
        ) 
        {
            if (_this != null)
            {
                this.Set(
                    _this: null
                    , _LPoint2D: _this.p_LPoint2D
                    , _BeginMode: _this.p_BeginMode
                    , _Native_X:_this.p_Native_X
                    , _Native_Y: _this.p_Native_Y
                );
            }
            if (_LPoint2D != null) this.p_LPoint2D = _LPoint2D;
            if (_BeginMode != null)this.p_BeginMode = _BeginMode.Value;
            if (_LIMyGlObject != null) this.p_LIMyGlObject = _LIMyGlObject;
            if (_Native_X != null) this.p_Native_X = _Native_X.Value;
            if (_Native_Y != null) this.p_Native_Y = _Native_Y.Value;
            return this;
        }
        ////////////////////////////////////////////////////////
        public IMyGlObject Add(Point2D _Point2D) {this.LPoint2D.Add(_Point2D);return this;}
        public IMyGlObject Add(System.Double _X, System.Double _Y)
        {
            this.LPoint2D.Add(new Point2D() { X = _X, Y = _Y});
            return this; 
        }
        public IMyGlObject Add(System.Double _X,System.Double _Y,Color _Color)
        {
            this.LPoint2D.Add(new Point2D() { X = _X,Y=_Y,Color=_Color });
            return this;
        }
        public IMyGlObject Add(System.Double _X, System.Double _Y,System.Double _R,System.Double _G,System.Double _B)
        {
            this.LPoint2D.Add(new Point2D() { X = _X, Y = _Y, Color = new Color() { R=_R, G=_G, B= _B } });
            return this;
        }
        ////////////////////////////////////////////////////////////
        public IMyGlObject Rendering() 
        {
            Update_Private();
            GL.Begin(this.BeginMode);
            foreach(Point2D _Point2D in this.LPoint2D) 
            {
                ;
                if(_Point2D.Color!=null) GL.Color3(_Point2D.Color.R, _Point2D.Color.G, _Point2D.Color.B);
                GL.Vertex2(_Point2D.X, _Point2D.Y);
            }
            GL.End();
            this.p_LIMyGlObject.ForEach(a =>a.Rendering());
            return this;
        }
        public IMyGlObject Update_Private()
        {
            //////////////////////////////////
            Update();//Обновили объект по списку точек (в зависимости от this.Native_X this.Native_Y)
            //////////////////////////////////
            /////Обновили список подобъектов (в зависимости от this.Native_X this.Native_Y)
            this.p_LIMyGlObject.ForEach(a => a.Update_Private());
            //////////////////////////////////
            return this;
        }
        public virtual IMyGlObject Update()
        {
            //////////////////////////////////
            ///Программный код обновление координат самого объекта по точкам
            //////////////////////////////////
            return this;
        }
    }
}
