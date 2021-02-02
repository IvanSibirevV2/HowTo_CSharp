using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Component
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //////////////////////////////////////////////
            this.p_Last_Width = this.Width;
            this.p_Last_Height = this.Height;
            //////////////////////////////////////////////
            this.label1.Text= "Множество символов для генерации";
            
            this.textBox1.Text = "0123456789qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM.,?;:[]{}()";
            this.label2.Text = "Какой длинны текст генерировать";
            this.textBox2.Text = "6";
            this.textBox2_TextChanged(null,null);
            this.label3.Text = "Генерировать";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private int p_Last_Width = 0;
        private int p_Last_Height = 0;
        private int p_Delto_Width = 0;
        private int p_Delto_Height = 0;

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            this.p_Delto_Width = this.Width-this.p_Last_Width;
            this.p_Delto_Height = this.Height - this.p_Last_Height;
            this.p_Last_Width = this.Width;
            this.p_Last_Height = this.Height;
            ////////////////////////////////////////////////////////
            this.textBox1.Width += this.p_Delto_Width;
            this.textBox2.Width += this.p_Delto_Width;
            this.textBox3.Width += this.p_Delto_Width;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(this.textBox2.Text);
                this.textBox2.BackColor = Color.Green;
                this.Do();
            }
            catch
            {
                this.textBox2.BackColor = Color.Red;
            }
        }
        private void Do()
        {
            Random rnd = new Random();
            this.textBox3.Text = "";
            for (int i = 0; i < Convert.ToInt32(this.textBox2.Text); i++)
                this.textBox3.Text += (char)this.textBox1.Text[rnd.Next(0, this.textBox1.Text.Length)];
            System.Windows.Forms.Clipboard.SetText(this.textBox3.Text);
        }
        private void label3_Click(object sender, EventArgs e)
        {
            this.textBox2_TextChanged(null, null);
        }
    }
}