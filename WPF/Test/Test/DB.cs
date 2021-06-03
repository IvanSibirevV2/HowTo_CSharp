using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Test
{
    public static class DB
    {
        public static System.String ConnectionString = @"Data Source=DB_Test.db";
        public static void Init() 
        {
            if (new SQL("SELECT Name FROM sqlite_master;").ExecuteReader().Where(a => a[0].ToString() == "Answer").Count().Set(a => { var qwe = a;
                ;
            }) == 0)
            {
                new SQL("CREATE TABLE 'Answer'('Id'    INTEGER NOT NULL UNIQUE,'Text'  TEXT NOT NULL,PRIMARY KEY('Id' AUTOINCREMENT));").Execute();
            }
        }
    }
    public class SQL
    {

        private SQLiteConnection connection = new SQLiteConnection("Data Source=DB_Test.db");
        private System.String CommandText = "";
        public SQL() { }
        public SQL(System.String _CommandText)
        {
            CommandText = _CommandText;

        }

        public void Execute()
        {
            connection.Open(); SQLiteCommand command = connection.CreateCommand();
            command.CommandText = CommandText;
            command.ExecuteNonQuery();
            connection.Close();
        }
        public List<List<object>> ExecuteReader()
        {
            List<List<object>> ListListObject = new List<List<object>>();
            connection.Open(); SQLiteCommand command = connection.CreateCommand();
            command.CommandText = CommandText;
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read())   // построчно считываем данные
                    {
                        List<object> ListObject = new List<object>();
                        for (int i = 0; i < reader.FieldCount; i++)
                            ListObject.Add(reader.GetValue(i));
                        ListListObject.Add(ListObject);
                    }
                }
            }
            connection.Close();
            
            ListListObject.ForEach(a => {
                a.ForEach(b => {
                    System.Console.Write(b); System.Console.Write(" ## ");
                }); System.Console.WriteLine("");
                System.Console.WriteLine("##########################################");
            });
            ;
            
            return ListListObject;
        }
        //SELECT name FROM my_db.sqlite_master WHERE type = 'table';
    }
}
