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

namespace Image_Gallery_MOO_ICT
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        int i = 1;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void GoBack(object sender, RoutedEventArgs e)
        {
          
        }

        private void GoNext(object sender, RoutedEventArgs e)
        {
            
        }

        private System.DateTime _DateTime = System.DateTime.Now;
    private void picHolder_MouseMove(object sender, MouseEventArgs e)
        {
            System.DateTime _NewDateTime = System.DateTime.Now;
           
            if (new TimeSpan(0, 0, 0, 0, 250) < (TimeSpan)(_NewDateTime- _DateTime))
            {
                
                System.Double X = System.Windows.Input.Mouse.GetPosition(this.picHolder).X;
                System.Double AW = this.picHolder.ActualWidth;

                if ((AW * 1 / 4) > X) 
                {
                    if (++i == 7) i = 6;
                }
                if (X > (AW * 3 / 4)) 
                {
                    if (--i == 0) i = 1;
                }
                if (((AW * 1 / 4) < X) & (X < (AW * 3 / 4)))
                {
                }
                this.picHolder.Source = new BitmapImage(new Uri(@"images/" + i + ".jpg", UriKind.Relative));

                this._DateTime = _NewDateTime;
            }
            
            
            //GoNext(null, null);
            //this.Title = System.Windows.Input.Mouse.GetPosition(this.picHolder).ToString() + "__"  + this.picHolder.ActualWidth ;
        }
    }
}
