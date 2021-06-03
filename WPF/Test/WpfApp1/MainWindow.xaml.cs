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
        private System.Windows.Controls.StackPanel GetAnswer_StackPanel(string TextId) 
        {
            StackPanel _StackPanel = new StackPanel();
            new SQL(
                "SELECT Answer.ID, Answer.Text, Answer.IsTrue  From QuestionAnswer LEFT JOIN Answer WHERE QuestionAnswer.QuestionId = " + TextId + " AND Answer.Id = QuestionAnswer.AnswerId"
                
                ).ExecuteReader()
                .Select(ListString_Question =>
                {
                    WrapPanel _WrapPanel = new WrapPanel();
                    _WrapPanel.Children.Add(new TextBlock() { Text = ListString_Question[0]+" "+ListString_Question[1] });
                    _WrapPanel.Children.Add(new CheckBox());
                    return _WrapPanel;
                    //return new TextBlock() { Text = ListString_Question[0] + " " + ListString_Question[1] };
                }
                ).ToList().ForEach(a => _StackPanel.Children.Add(a))
            ;
            return _StackPanel;
        }
        private System.Windows.Controls.StackPanel GetQuestions_StackPanel(string TextId) 
        {
            StackPanel _StackPanel = new StackPanel();
            new SQL("SELECT Question.Id, Question.Text from TestQuestion LEFT JOIN  Question  WHERE(TestQuestion.TestId = " + TextId + ") and(TestQuestion.QuestionId = Question.Id)").ExecuteReader()
                .Select(ListString_Question => 
                    new Expander()
                    {
                        Header = ListString_Question[0]+" "+ ListString_Question[1],
                        Content= GetAnswer_StackPanel(ListString_Question[0])
                    }
                ).ToList().ForEach(a => _StackPanel.Children.Add(a))
            ;
            return _StackPanel;
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            (new SQL("SELECT Id,Text from Test;").ExecuteReader())
                .Select(ListString_Test =>
                     new Expander() 
                     {
                        Header = ListString_Test[0]+" "+ ListString_Test[1],
                        Content = GetQuestions_StackPanel(ListString_Test[0])
                    }
                )
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
