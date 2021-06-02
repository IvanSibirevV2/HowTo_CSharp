using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Form1_SizeChanged(null, null);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            this.listView1.Width = this.Width-40;
            this.listView1.Height = this.Height - 90;
        }
    }
}