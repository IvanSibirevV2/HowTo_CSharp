using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model.DevData
{
    /// <summary>
    /// ConsoleApp1.DevData.TestMatch
    /// </summary>
    public static class TestMatch
    {
        public static Cog Init() =>new Cog() 
        {
            Name = "Тест",Notes = "Тест по математике, базовый",
            ListCog = new List<Cog>() 
            {
                new Cog()
                {
                    Name = "Вопрос",Notes = "Сколько будет два плюс два?",
                    ListCog = new List<Cog>()
                    {
                        new Cog(){Name = "Ответ",Notes = "4",IsTrue = true},
                        new Cog(){Name = "Ответ",Notes = "3",IsTrue = false},
                        new Cog(){Name = "Ответ",Notes = "7",IsTrue = false},
                        new Cog(){Name = "Ответ",Notes = "Мы такое не проходили",IsTrue = false}
                    }
                }
                ,
                new Cog()
                {
                    Name = "Вопрос",Notes = "Теперь по сложнее? Отметте истиные выражения...",
                    ListCog = new List<Cog>()
                    {
                        new Cog(){Name = "Ответ",Notes = "4>3",IsTrue = true},
                        new Cog(){Name = "Ответ",Notes = "5<3",IsTrue = false},
                        new Cog(){Name = "Ответ",Notes = "9>5",IsTrue = true},
                        new Cog(){Name = "Ответ",Notes = "Мы такое не проходили",IsTrue = false}
                    }
                }
            }
        }
        ;
    }
}
