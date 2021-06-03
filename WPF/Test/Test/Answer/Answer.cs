using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Test
{
    public class Answer
    {
        public System.Int32 Id = -1;
	    public System.String Text="";

        
        public static List<Answer>  GetOll() 
        {
            new SQL("SELECT * from Answer").ExecuteReader()
                .ForEach(a=> {
                    System.Console.WriteLine("*******");
                })
                ;
            return null;
        }
    }
}
