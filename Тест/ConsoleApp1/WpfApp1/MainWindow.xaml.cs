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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// Пример отображения кнопок для запуска теста и ответов  осталось доделать примерно 2/3
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            System.Windows.Controls.Button _Button = new System.Windows.Controls.Button();
            
            this.phonesList.Items.Add(new { Content= "123" });
            this.phonesList.Items.Add(new { Content = "234" });
            this.phonesList.Items.Add(new { Content = "345" });
            this.phonesList.Items.Add(new { Content = "456" });
            this.phonesList.Items.Add(new { Content = "567" });
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
