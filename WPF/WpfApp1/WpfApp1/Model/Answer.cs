using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfApp1.Model
{
    public class Answer
    {
        public int Id = -1;
        public System.String Text = "";
        public System.Boolean IsTrue = false;
        //////////////////////////////////////////
        //public View_ View = null;
        public WrapPanel _View = null;
            
        public CheckBox CheckBox = null;
        public TextBlock TextBlock = null;

        //////////////////////////////////////////
        public Answer() { }
        public Answer(int _Id, System.String _Text, System.Boolean _IsTrue)
        {
            Id = _Id;
            Text = _Text;
            IsTrue = _IsTrue;
            _View = new WrapPanel();
            CheckBox = new CheckBox();
            TextBlock = new TextBlock() { Text= ((_IsTrue)?('.'):(' '))+_Text };
        }
        public Answer Init()
        {
            ;
            _View.Children.Add(CheckBox);
            _View.Children.Add(TextBlock);
            return this;
        }
    }
}
