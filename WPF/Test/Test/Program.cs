using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data.SQLite.EF6;
using System.Data.SQLite.Linq;

//Установлен SQLite3
//https://metanit.com/sharp/wpf/21.1.php
//https://metanit.com/sharp/wpf/21.1.php
//https://metanit.com/sharp/adonetcore/4.2.php
namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Test.DB.Init();
            /*
            new SQL(
@"CREATE TABLE 'Answer'(
'Id'    INTEGER NOT NULL UNIQUE,
'Text'  TEXT NOT NULL,
PRIMARY KEY('Id' AUTOINCREMENT)
);
"
            ).Execute();
            */
            System.Console.WriteLine("Привет мир");
            //Test.Answer.GetOll();
            System.Console.ReadLine();

        }
    }
}
