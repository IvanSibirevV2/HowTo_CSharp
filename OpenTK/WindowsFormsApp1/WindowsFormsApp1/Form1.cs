using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenTK.Graphics.OpenGL;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void glControl1_Load(object sender, EventArgs e)
        {
            OpenTK.Graphics.OpenGL.GL.ClearColor(0.9f, 0.5f, 0.5f, 1.0f);

        }

        private void glControl1_Paint(object sender, PaintEventArgs e)
        {
            GL.PointSize(5);
            GL.LineWidth(5);
            if (false) V0.Paint.Do(__X,__Y);
            if (false) V1.Paint.Do(__X, __Y);
            if (false) V2.Paint.Do(__X, __Y);
            if (false) V2.Paint.Do_V2(__X, __Y);
            if (false) V2.Paint.Do_V3(__X, __Y);
            /*
            
            */
            GL.Finish();
            GL.Begin(BeginMode.Triangles);
            GL.Color3(1.0, 0.0, 0.0);  /* красный */
            GL.Vertex3(0.0, 0.0, 0.0);
            GL.Color3(0, 255, 0); /* зеленый */
            GL.Vertex3(1.0, 0.0, 0.0);
            GL.Color3(0, 0, 255); /* синий */
            GL.Vertex3(1.0, 1.0, 0.0);
            GL.End();
            
            //Поменять передний и задний буфер
            glControl1.SwapBuffers();

        }
       public float __X = 0;
        public float __Y = 0;
        private void glControl1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'w' || e.KeyChar == 'W')
            {
                this.__Y += 0.01f;
                this.Text = "W";
            }
            if (e.KeyChar == 'A' || e.KeyChar == 'a')
            {
                this.__X -= 0.01f;
                this.Text = "A";
            }

            if (e.KeyChar == 's' || e.KeyChar == 'S')
            {
                this.__Y -= 0.01f;
                this.Text = "S";
            }
            if (e.KeyChar == 'D' || e.KeyChar == 'd')
            {
                this.__X += 0.01f;
                this.Text = "D";
            }

            
            //Очистка буфера цветов точек- правильная
            GL.Clear(ClearBufferMask.ColorBufferBit);
            glControl1_Paint(null, null);
            //glControl1_Paint(null,null);
        }
    }
}
