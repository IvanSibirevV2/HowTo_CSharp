using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;


namespace WpfApp1.Model
{
    /// <summary>
    /// ЭТО ВОПРОС. Привет мир!!!)))=) XD
    /// </summary>
    public class Question
    {
        /// <summary>
        /// 
        /// </summary>
        public int Id = -1;
        /// <summary>
        /// 
        /// </summary>
        public System.String Text = "";
        public AnswerS AnswerS = null;
        //////////////////////////////////////////////
        public Expander _View = null;
        public Question() { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_Id"></param>
        /// <param name="_Text"></param>
        public Question(int _Id, System.String _Text) 
        {
            Id = _Id;
            Text = _Text;
            _View = new Expander() { Header = _Text };
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Question Init() 
        {
            ;
            AnswerS = new AnswerS().Init(Id);
            _View.Content = AnswerS._View;
            return this;
        }
    }
}
