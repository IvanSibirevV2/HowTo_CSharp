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

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Expander _Expander = new Expander();
                _Expander.Content = "dasdas";
                _Expander.Header = "Добавил сам";
                    StackPanel _StackPanel = new StackPanel();
                    CheckBox _CheckBox = new CheckBox();
                        _CheckBox.Content = "dsad";
                    _StackPanel.Children.Add(_CheckBox);
                _Expander.Content = _StackPanel;
            this.p_StackPanel.Children.Add(_Expander);
        }

        private void Expander_TouchUp(object sender, TouchEventArgs e)
        {
            
        }

        private void Expander_Expanded(object sender, RoutedEventArgs e)
        {
            this.Title = "!!!";
        }
    }
}
