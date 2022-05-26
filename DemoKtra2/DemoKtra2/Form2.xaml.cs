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

namespace DemoKtra2
{
    /// <summary>
    /// Interaction logic for Form2.xaml
    /// </summary>
    public partial class Form2 : Window
    {
        public string nhanVien { get; set; }
        public Form2()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;

        }
        private void WindowLoaded(object sender, RoutedEventArgs e)
        {

            
            edtTest.Text= "aaaaa";
        }
    }
}
