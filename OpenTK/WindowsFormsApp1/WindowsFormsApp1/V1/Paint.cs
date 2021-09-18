using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Graphics.OpenGL;

namespace WindowsFormsApp1.V1
{
    public static class Paint
    {
        /// <summary>
        /// Если создавать свою структуру классов 
        /// Использовать анонимные склассы
        /// И писать минимум инфраструктурного кода
        /// То есть функций, упращающих использование
        /// </summary>
        /// <param name="__X"></param>
        /// <param name="__Y"></param>
        public static void Do(System.Double __X,System.Double __Y) 
        {
            //вЕРСИЯ ВТОРАЯ
            GlObj _GlObj=new GlObj()
            {
                BeginMode = BeginMode.LineStrip,
                LPoint2D = new List<Point2D>() {
                    new Point2D(){X=__X - 0.1,Y= __Y - 0.5,Color=new Color(){R= 0.8,G= 0.2,B= 0.2 } }
                    , new Point2D(){X=__X - 0.4, Y=__Y - 0.5 }
                    , new Point2D(){X=__X - 0.4, Y=__Y - 0.9 }
                    , new Point2D(){X=__X - 0.1, Y=__Y - 0.9 }
                    , new Point2D(){X=__X - 0.1, Y=__Y - 0.5 }
                    , new Point2D(){X=__X - 0.25, Y=__Y - 0.1 }
                    , new Point2D(){X=__X - 0.4, Y=__Y - 0.5 }
                }
            }
            ;
            _GlObj.Rendering();
        }
    }
}
