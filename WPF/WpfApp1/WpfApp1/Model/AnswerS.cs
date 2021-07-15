using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfApp1.Model
{
    public class AnswerS
    {
        //QuestionS = new QuestionS().Init(Id);
        public List<Answer> ListAnswer = new List<Answer>();
        public StackPanel _View = null;
        public AnswerS Init(int Id)
        {
            ;
            _View = new StackPanel();
            List<List<string>> _ListListString = new SQL(
                "SELECT Answer.ID, Answer.Text, Answer.IsTrue  From QuestionAnswer " +
                "LEFT JOIN Answer WHERE QuestionAnswer.QuestionId = " + Id +
                " AND Answer.Id = QuestionAnswer.AnswerId"
                ).ExecuteReader()
            ;
            ;
            _ListListString.ForEach(_AnswerRow =>
                ListAnswer.Add(new Answer(Convert.ToInt32(_AnswerRow[0]), _AnswerRow[1], Convert.ToBoolean(_AnswerRow[2])).Init())
            );
            ListAnswer.ForEach(_Answer =>_View.Children.Add(_Answer._View));
            return this;
        }
    }
}
