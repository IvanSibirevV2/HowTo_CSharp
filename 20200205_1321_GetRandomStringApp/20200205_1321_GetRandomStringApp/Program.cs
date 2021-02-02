using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Component
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            (new Form1()).ShowDialog();
        }
    }
}
