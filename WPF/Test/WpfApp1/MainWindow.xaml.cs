using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SQLite;


namespace WpfApp1
{
    public static class Ext_Set
    {
        public static T Set<T>(this T _this, System.Action<T> _act) { _act(_this); return _this; }
    }
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //p_StackPanel.Children.Add(new TextBlock() { Text = "re" });
            //p_StackPanel.Children.Add(new TextBlock() { Text = "re" });
            ;
            //var qwe =(new SQL("SELECT * from Answer").ExecuteReader());
            /*
            (new SQL("SELECT * from Test").ExecuteReader())
                .ForEach(a =>
                {

                    a.ForEach(b =>
                    {
                        p_StackPanel.Children.Add(new TextBlock() { Text = b.ToString() }); ;

                    });
                });
            */
            //< TextBlock > Однажды в студеную зимнюю пору...</ TextBlock >
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            (new SQL("SELECT Id,Text from Test;").ExecuteReader())
                .Select(ListString_Test =>
                {
                    Expander _Test = new Expander() {
                        Header = ListString_Test[1],
                        Content = (new StackPanel()).Set(_StackPanel_Question=> {
                            /*
                            new SQL(
                                "SELECT Question.Id, Question.Text from TestQuestion LEFT JOIN  Question"
                                + " WHERE(TestQuestion.TestId = " + ListString_Test[0] + ") and(TestQuestion.QuestionId = Question.Id)"
                            ).ExecuteReader()
                            .Select(ListString_Question => {
                                Expander _Question = new Expander()
                                { 
                                    Header = ListString_Question[1],
                                    Content = (new StackPanel()).Set(_StackPanel_Answer =>
                                    { 

                                    })
                                };
                                return _Question;
                            })
                            .ToList().ForEach(a=>_StackPanel_Question.Children.Add(a))
                            ;
                            */
                        })
                    };
                    /*
                    new SQL(
                        "SELECT Question.Id,Question.Text from Question LEFT JOIN TestQuestion"
                        + "WHERE TestQuestion.TestId = 1 and TestQuestion.QuestionId = Question.Id"
                    ).ExecuteReader()
                    
                    .Select(ListString_Question => {
                        Expander _Question = new Expander();
                        _Question.Header = ListString_Question[1];
                        StackPanel _TestQuestion = new StackPanel();
                        _Question.Content = _TestQuestion;
                        return _Question;
                    })
                    .ToList().ForEach(a=>_TestContent.Children.Add(a));
                    _Test.Content = _TestContent;

                    */
                    ;

                    return _Test;
                })
                .ToList().ForEach(a => p_StackPanel.Children.Add(a));
            ;
            /*
                .ForEach(_TestRow =>
                {
                    /*
                    p_StackPanel.Add(
                        (new Expander() { Header = _TestRow[1].ToString() })
                        .Set(_Expander=> {
                            _Expander.Content = (new StackPanel()).Children.Add
                                
                            ;
                        })
                    ) ;
                    
                });
            */
            /*
            (new SQLiteConnection("Data Source=DB_Test.db")).Set(connection => {
                connection.CreateCommand().Set(command=> {
                    command.CommandText = "SqlComand";
                    (new System.Data.SQLite.SQLiteDataAdapter(command))
                        .Set(adapter=>
                        {
                            //adapter.InsertCommand.CommandType = CommandType.StoredProcedure
                            System.Data.DataSet _DataSet =new System.Data.DataSet();
                            adapter.Fill(p_Tests);
                        });
                });
            })
            ;
            //SQLiteConnection connection = ;
            //SQLiteCommand command = connection.CreateCommand();
            */

        }
    }
}
