using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp1.Test
{
    /// <summary>
    /// Пример отображения кнопок для запуска теста и ответов  осталось доделать примерно 2/3
    /// </summary>
    public partial class Form1 : Form
    {
        public Cog _Cog = null;
        public Form1()
        {
            InitializeComponent();
            listView1.Columns.Add("Col2", 200);
            listView1.GridLines = true;
            
            Form1_SizeChanged(this, null);
            this._Cog = Model.DevData.TestMatch.Init();
            
            CheckCog("001");
            CheckCog("002");
            CheckCog("003");
            CheckCog("004");

            CheckCog("005");
            CheckCog("006");
            CheckCog("007");
            CheckCog("008");
        }
        private void CheckCog(string _str)
        {
            this.listView1.Items.Add("",1);
            var item = this.listView1.Items[this.listView1.Items.Count - 1];
            System.Windows.Forms.Button _Button = new System.Windows.Forms.Button();
            _Button.Text = _str;
            System.Action<object, EventArgs> qwe = (object sender, EventArgs e) =>
            {_Button.Location = item.Position;_Button.Size = item.Bounds.Size;};
            qwe(null,null); ;
            this.listView1.SizeChanged += (object sender, EventArgs e) => { qwe(sender, e); };
            this.listView1.Controls.Add(_Button);
        }
        /// <summary>
        /// Вешает заданную кнопку на лист
        /// </summary>
        /// <param name="_Button"></param>
        private void addButton(System.Windows.Forms.Button _Button)
        {
            this.listView1.Items.Add("", 1);
            var item = this.listView1.Items[this.listView1.Items.Count - 1];
            System.Action<object, EventArgs> qwe = (object sender, EventArgs e) =>
            { _Button.Location = item.Position; _Button.Size = item.Bounds.Size; };
            qwe(null, null); ;
            this.listView1.SizeChanged += (object sender, EventArgs e) => { qwe(sender, e); };
            this.listView1.Controls.Add(_Button);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            this.listView1.Width = this.Width-30;
            this.listView1.Height = this.Height-50;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
