using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Graphics.OpenGL;

namespace WindowsFormsApp1.V2
{
    public static class Paint
    {
        /// <summary>
        /// Если использовать интерфейсы и не в чем себе не отказывать 
        /// </summary>
        /// <param name="__X"></param>
        /// <param name="__Y"></param>
        public static void Do(System.Double __X,System.Double __Y) 
        {
            IMyGlObject _House = new MyGlObject();
            _House
                .Set(_BeginMode: BeginMode.LineStrip)
                .Add(__X - 0.1, __Y - 0.5, 0.8, 0.2, 0.2)
                .Add(__X - 0.4, __Y - 0.5)
                .Add(__X - 0.4, __Y - 0.9)
                .Add(__X - 0.1, __Y - 0.9)
                .Add(__X - 0.1, __Y - 0.5)
                .Add(__X - 0.25, __Y - 0.1)
                .Add(__X - 0.4, __Y - 0.5)
                .Rendering()
            ;
        }
        /// <summary>
        /// Если наш объект состаит из мелких отдельно отрисовываемых деталей
        /// Или под объектов
        /// </summary>
        public static void Do_V2(System.Double __X, System.Double __Y)
        {
            new MyGlObject()
                    .Set(_LIMyGlObject: new List<IMyGlObject> {
                        new MyGlObject()
                            .Set(_BeginMode: BeginMode.Quads)
                            .Add(__X - 0.1, __Y - 0.5, 0.8, 0.2, 0.2)
                            .Add(__X - 0.4, __Y - 0.5)
                            .Add(__X - 0.4, __Y - 0.9)
                            .Add(__X - 0.1, __Y - 0.9)
                        ,new MyGlObject()
                            .Set(_BeginMode: BeginMode.Triangles)
                            .Add(__X - 0.1, __Y - 0.5,0.2, 0.8, 0.2)
                            .Add(__X - 0.25, __Y - 0.1)
                            .Add(__X - 0.4, __Y - 0.5)
                    })
                    .Rendering()
                ;
        }
        /// <summary>
        /// Если наш объект упакован в класс только для него
        /// </summary>
        public static void Do_V3(System.Double __X, System.Double __Y)
        {
            new House().Set(_Native_X: __X, _Native_Y: __Y)
                .Rendering();
        }
    }
}
