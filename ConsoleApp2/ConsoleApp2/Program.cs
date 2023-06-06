using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Speech.Recognition;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Привет мир");
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            bool completed = true;

            SpeechRecognitionEngine sre = new SpeechRecognitionEngine()
                .Set(b=>
                    b.LoadGrammar(
                        new Grammar(
                            new GrammarBuilder().Set(a => a.Culture = new CultureInfo("en-Gb")).Set(a => a.AppendDictation())
                        ).Set(a => a.Enabled = true)
                    )
                )
                .Set(a => {
                    a.BabbleTimeout = TimeSpan.FromHours(1);
                    a.EndSilenceTimeout = TimeSpan.FromSeconds(10);
                    a.InitialSilenceTimeout = TimeSpan.FromSeconds(10);
                    //a.SpeechRecognized += sre_SpeechRecognized;
                    //a.RecognizeCompleted += sre_RecognizeCompleted;
                })
            ;
            
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            
            //System.Speech
            System.Console.ReadLine();
        }
        /*
         

        public Recognition()
        {
            var grammarBuilder = new GrammarBuilder();
            grammarBuilder.Culture = new CultureInfo("en-Gb");
            grammarBuilder.AppendDictation();

            var grammar = new Grammar(grammarBuilder);
            
            grammar.Enabled = true;
            sre.LoadGrammar(grammar);
            sre.BabbleTimeout = TimeSpan.FromHours(1);
            sre.EndSilenceTimeout = TimeSpan.FromSeconds(10);
            sre.InitialSilenceTimeout = TimeSpan.FromSeconds(10);
            sre.SpeechRecognized += sre_SpeechRecognized;
            sre.RecognizeCompleted += sre_RecognizeCompleted;
        }
         */
    }
}
