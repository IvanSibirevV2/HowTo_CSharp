using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace WpfApp1
{
    public static class DB
    {
        public static System.String ConnectionString = @"Data Source=DB_Test.db";
        public static void Init() 
        {
            if (new SQL("SELECT Name FROM sqlite_master;").ExecuteReader().Where(a => a[0].ToString() == "Answer").Count() == 0)
            {
            
            }
            if (new SQL("SELECT Name FROM sqlite_master;").ExecuteReader().Where(a => a[0].ToString() == "Question").Count() == 0)
            {

            }
            if (new SQL("SELECT Name FROM sqlite_master;").ExecuteReader().Where(a => a[0].ToString() == "Test").Count() == 0)
            {

            }
            if (new SQL("SELECT Name FROM sqlite_master;").ExecuteReader().Where(a => a[0].ToString() == "QuestionAnswer").Count() == 0)
            {
                new SQL("CREATE TABLE 'QuestionAnswer'('Id'    INTEGER NOT NULL UNIQUE,'QuestionId'    INTEGER NOT NULL,'AnswerId'  INTEGER NOT NULL,FOREIGN KEY('QuestionId') REFERENCES 'Question'('Id'),FOREIGN KEY('AnswerId') REFERENCES 'Answer'('Id'),PRIMARY KEY('Id' AUTOINCREMENT));").Execute();
            }
            if (new SQL("SELECT Name FROM sqlite_master;").ExecuteReader().Where(a => a[0].ToString() == "TestQuestion").Count() == 0)
            {
                new SQL("CREATE TABLE 'TestQuestion'('Id'    INTEGER NOT NULL UNIQUE,'QuestionId'    INTEGER NOT NULL,'TestId'    INTEGER NOT NULL,FOREIGN KEY('TestId') REFERENCES 'Test'('Id'),FOREIGN KEY('QuestionId') REFERENCES 'Question'('Id'),PRIMARY KEY('Id' AUTOINCREMENT));").Execute();
            }
        }
    }
    public class SQL
    {

        private SQLiteConnection connection =
            //new SQLiteConnection("Data Source=DB_Test.db")
            new SQLiteConnection("Data Source=DB_Test2")
            ;
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
        public List<List<String>> ExecuteReader()
        {
            List<List<String>> ListListString = new List<List<String>>();
            connection.Open(); SQLiteCommand command = connection.CreateCommand();
            command.CommandText = CommandText;
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read())   // построчно считываем данные
                    {
                        List<String> ListObject = new List<String>();
                        for (int i = 0; i < reader.FieldCount; i++)
                            ListObject.Add(reader.GetValue(i).ToString());
                        ListListString.Add(ListObject);
                    }
                }
            }
            connection.Close();
            
            ListListString.ForEach(a => {
                a.ForEach(b => {
                    System.Console.Write(b); System.Console.Write(" ## ");
                }); System.Console.WriteLine("");
                System.Console.WriteLine("##########################################");
            });
            ;
            
            return ListListString;
        }
        //SELECT name FROM my_db.sqlite_master WHERE type = 'table';
    }
}
