using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Model
{
    using System.Windows.Controls;
    public class QuestionS
    {
        /// <summary>Контейнер визуализации вопросов</summary>
        public StackPanel _View= null;
        public Button Button = null;
        public List<Question> ListQuestion = new List<Question>();
        /// <summary></summary>
        /// <param name="Id">Id родительского теста</param>
        /// <param name="_Expander">Точка ввызявания Визуализации вопросов</param>
        /// <returns></returns>
        public QuestionS Init(int Id)
        {
            _View = new StackPanel();
            Button = new Button();
            Button.Content = "Проверить тест";
            List <List<string>> _ListListString = new SQL(
                "SELECT Question.Id, Question.Text from TestQuestion" +
                " LEFT JOIN  Question  WHERE(TestQuestion.TestId = " + Id + ")" +
                " and(TestQuestion.QuestionId = Question.Id)"
                )
                .ExecuteReader();
            ;
            _ListListString.ForEach(_QuestionRow=>
                ListQuestion.Add(new Question(Convert.ToInt32(_QuestionRow[0]), _QuestionRow[1]).Init())
            );
            ListQuestion.ForEach(_Question =>_View.Children.Add(_Question._View));
            return this;
        }

        

        /*
         
         
            
                .Select(ListString_Question => 
                    new Expander()
                    {
                        Header = ListString_Question[0]+" "+ ListString_Question[1],
                        Content= GetAnswer_StackPanel(ListString_Question[0])
                    }
                ).ToList().ForEach(a => _StackPanel.Children.Add(a))
            ;
         */
    }
}
