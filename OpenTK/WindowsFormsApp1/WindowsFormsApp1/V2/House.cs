using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenTK.Graphics.OpenGL;

namespace WindowsFormsApp1.V2
{
    public class House: MyGlObject , IMyGlObject
    {
        public House(){}
        public override IMyGlObject Update()
        {
            //Спросить преподавателя когда доберемся до лямбда выражений
            this.p_LIMyGlObject.Clear();
            this
                .Set(_LIMyGlObject: new List<IMyGlObject> {
                    new MyGlObject()
                        .Set(_BeginMode: BeginMode.Quads)
                        .Add(this.p_Native_X - 0.1, this.p_Native_Y - 0.5, 0.8, 0.2, 0.2)
                        .Add(this.p_Native_X - 0.4, this.p_Native_Y - 0.5)
                        .Add(this.p_Native_X - 0.4, this.p_Native_Y - 0.9)
                        .Add(this.p_Native_X - 0.1, this.p_Native_Y - 0.9)
                    ,new MyGlObject()
                        .Set(_BeginMode: BeginMode.Triangles)
                        .Add(this.p_Native_X - 0.1, this.p_Native_Y - 0.5,0.2, 0.8, 0.2)
                        .Add(this.p_Native_X - 0.25, this.p_Native_Y - 0.1)
                        .Add(this.p_Native_X - 0.4, this.p_Native_Y - 0.5)
                })
            ;
            //////////////////////////////////
            ///Программный код обновление самого объекта по точкам
            //////////////////////////////////
            return this;
        }
        
    }
}
