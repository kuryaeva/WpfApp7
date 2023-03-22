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

namespace WpfApp7
{
    /// <summary>
    /// Логика взаимодействия для Window7client.xaml
    /// </summary>
    public partial class Window7client : Window
    {
        public Window7client()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window8client window8Client = new Window8client();
            window8Client.Show();
        }

        private void Registr_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
