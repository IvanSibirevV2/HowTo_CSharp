using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfApp1.Model
{
    public class Question
    {
        public int Id = -1;
        public System.String Text = "";
        public AnswerS AnswerS = null;
        //////////////////////////////////////////////
        public Expander _View = null;
        public Question() { }
        public Question(int _Id, System.String _Text) 
        {
            Id = _Id;
            Text = _Text;
            _View = new Expander() { Header = _Text };
        }
        public Question Init() 
        {
            ;
            AnswerS = new AnswerS().Init(Id);
            _View.Content = AnswerS._View;
            return this;
        }
    }
}
