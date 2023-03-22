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
using System.Windows.Shapes;
using WpfApp7.Models;

namespace WpfApp7
{
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
            AppConnect.database = new keramikaEntities();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window5 window5 = new Window5();
            window5.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window6 window6 = new Window6();
            window6.Show();
        }

        private void Window_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if(Visibility == Visibility.Visible)
            {
                try
                {
                    ProductsListBox.ItemsSource = AppConnect.database.ProductsT1.ToList();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Error Exception", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}
