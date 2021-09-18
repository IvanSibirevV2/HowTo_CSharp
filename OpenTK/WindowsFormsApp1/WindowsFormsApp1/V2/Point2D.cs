using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.V2
{
    public class Point2D
    {
        public System.Double X = 0;
        public System.Double Y = 0;
        public Color Color = null;
        public Point2D() { }
        public Point2D Set(
            Point2D _this
            , System.Nullable<System.Double> _X = null
            , System.Nullable<System.Double> _Y = null
            , Color _Color = null
        )
        {
            if (_this != null)
                this.Set(_this: null, _X: _this.X, _Y: _this.Y, _Color: _this.Color);
            if (_X != null) this.X = _X.Value;
            if (_Y != null) this.Y = _Y.Value;
            if (_Color != null) this.Color = _Color;
            return _this;
        }
    }
}
