using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.V3
{
    public class Color
    {
        public System.Double R = 0;
        public System.Double G = 0;
        public System.Double B = 0;
        public Color() { }
        /// <summary>
        /// Обобщенный иньектор зависимостей для параметров этого класса.
        /// Через принцип возвращения с продолжением.
        /// Через указание значения параметров по умолчанию.
        /// Через контейнер Nullable, который может использоваться для игнорирования присвоения.
        /// </summary>
        public Color Set(
            Color _this = null
            , System.Nullable<System.Double> _R = null
            , System.Nullable<System.Double> _G = 0
            , System.Nullable<System.Double> _B = 0
        )
        {
            if (_this != null)
                this.Set(_R: _this.R, _G: _this.G, _B: _this.B);
            if (_R != null) this.R = _R.Value;
            if (_G != null) this.G = _G.Value;
            if (_B != null) this.B = _B.Value;
            return this;
        }
        public static void Test_Set()
        {
            Color _Color1 = new Color() { R = 0.5f, G = 0.2f, B = 0.1f };
            Color _Color2 = new Color().Set(_R: 0.5f).Set(_B: 0.1f).Set(_G: 0.2f).Set(_R: 0.6f);
            Color _Color3 = new Color().Set(_this: _Color2);
        }
    }
}
