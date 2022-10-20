using System;
using System.Collections.Generic;
using System.Drawing;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<SolidColorBrush> brushes;
        private Random random;
        public MainWindow()
        {
            InitializeComponent();
            random = new Random();
            brushes = new List<SolidColorBrush> 
              {
                Brushes.Orange,
                Brushes.Sienna,
                Brushes.Salmon,
                Brushes.AliceBlue,
                Brushes.AntiqueWhite,
                Brushes.Aqua,
     
            };
        }

        private void btn_7_Click(object sender, RoutedEventArgs e)
        {
            if(sender is Button)
            s.Background = brushes[random.Next(0, brushes.Count)];
        }

        private void btn_1_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
             if(sender is Button)
            first_cont.Children.Remove(s);
            Title = s.Content.ToString();
        }
    }
}
