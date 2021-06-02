using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Answer
    {
        public int id = -1;
        public System.Boolean IsTrueAnswer = false;
        public System.Boolean UserAnswer = false;
        public System.String Text = "";
    }
    public class Question
    {
        public int id = -1;
        public System.String Text = "";
        public List<Answer> ListAnswer = new List<Answer>();
    }
    public class Test
    {
        public int id = -1;
        public System.String Text = "";
        public List<Question> ListAnswer = new List<Question>();
    }
}
