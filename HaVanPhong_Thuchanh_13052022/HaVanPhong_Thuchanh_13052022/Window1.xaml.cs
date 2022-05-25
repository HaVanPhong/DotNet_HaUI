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

namespace HaVanPhong_Thuchanh_13052022
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public CuonSach cs { get; set; }
        public Window1()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void WindowLoaded(object sender, RoutedEventArgs e)
        {
            
            tvMaCuon.Text = cs.maCuon;
            tvTenSach.Text = cs.tenSach;
            tvSoTrang.Text = cs.soTrang+"";
            tvTheLoai.Text = cs.theLoai;
            tvNXB.Text = cs.nhaXuatBan;
        }
    }
}
