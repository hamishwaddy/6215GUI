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

namespace ManualButton
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //private void My_Handler(object sender, RoutedEventArgs e)
        //{
        //    var btn = new Button();
        //    btn.Content = "Click Me Again!";
        //    btn.Background = Brushes.Red;
        //    btn.FontSize = 30;

        //    MyGrid.Children.Add(btn);
        //}

        private void My_Handler(object sender, RoutedEventArgs e)
        {
            Label label = new Label();
            label.Content = txtbox.Text;
            label.FontSize = 30;
            
            MyGrid.Children.Add(label);
        }
    }
}
