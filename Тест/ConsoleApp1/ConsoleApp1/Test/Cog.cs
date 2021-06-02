using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// Шестеренка теста, выполняет одновременно роль самого теста, отдельных его вопросов и отдельных его ответов
    /// Можно относительно легко подвязать на базе данных
    /// Пока что на статическом примере теста из 2 вопросов...
    /// </summary>
    public class Cog
    {
        public int id = -1;
        public string Name = "";
        public string Notes = "";
        public System.Boolean IsTrue = false;
        public System.Boolean UserSet = false;
        public List<Cog> ListCog = new List<Cog>();
    }
}
