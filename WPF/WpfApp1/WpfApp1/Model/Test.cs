using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace WpfApp1.Model
{
    public class Test
    {
        public int Id = -1;
        public System.String Text = "";
        public QuestionS QuestionS = null;
        ////////////////////////////////////////////////
        public Expander _View = null;
        public Test() { }
        public Test(int _Id, System.String _Text)
        {
            Id = _Id;
            Text = _Text;
            _View = new Expander(){Header = _Text};
            {
                Test _Test = this;
                _Test._View.Expanded += (object sender, RoutedEventArgs e) => {
                    List<Boolean> CheckS=_Test.QuestionS.ListQuestion.Select(Question =>
                            Question.AnswerS.ListAnswer.Select(_Answer => ((bool)_Answer.CheckBox.IsChecked && _Answer.IsTrue))
                        )
                        .SelectMany(s => s).Cast<System.Boolean>().ToList()
                    ;
                    _Test._View.Header =  "("+CheckS.Where(a => a).Count().ToString() +
                        "/" + CheckS.Count().ToString()+")   "+ _Text ;
                };
            }
        }
        public Test Init() 
        {
            QuestionS = new QuestionS().Init(Id);
            _View.Content = QuestionS._View;
            return this;
        }
    }
}
