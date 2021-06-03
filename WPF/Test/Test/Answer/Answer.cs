using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Test.Answer
{
    public class Answer
    {
        public System.Int32 Id = -1;
	    public System.String Text="";

        
        public static List<Answer>  GetOll() 
        {
            using (var connection = new SQLiteConnection(Test.DB.ConnectionString))
            {
                connection.Open();
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = "select * from sqlite_master";
                /*
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows) // если есть данные
                    {
                        while (reader.Read())   // построчно считываем данные
                        {
                            var id = reader.GetValue(0);
                            var name = reader.GetValue(1);
                            ;
                            Console.WriteLine($"{id} \t {name}=");
                        }
                    }
                }
                */
            }
            return null;
        }
    }
}
