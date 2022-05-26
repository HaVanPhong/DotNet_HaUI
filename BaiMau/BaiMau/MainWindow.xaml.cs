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

namespace BaiMau
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<NhanVien> list = new List<NhanVien>();
        public MainWindow()
        {
            InitializeComponent();
           
            
        }

        private void btnThoat_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv.MaNV = txtMaNV.Text;
            nv.HoTen = txtHoTen.Text;
            if (rbNam.IsChecked == true)
                nv.GioiTinh = "Nam";
            else
                nv.GioiTinh = "Nữ";
            nv.NgaySinh = DateTime.Parse(dpNgaySinh.Text);
            nv.Luong = double.Parse(txtTienLuongNgay.Text);
            nv.SoNgayLam = int.Parse(txtNgayLam.Text);
            list.Add(nv);
        }

        private void btnHienThi_Click(object sender, RoutedEventArgs e)
        {
            lvNhanVien.Items.Clear();
            foreach (NhanVien nv in list)
                lvNhanVien.Items.Add(nv);
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            txtMaNV.Text = "";
            txtHoTen.Text = "";
            rbNam.IsChecked = true;
            dpNgaySinh.SelectedDate = DateTime.Now;
            txtTienLuongNgay.Text = "";
            txtNgayLam.Text = "";
            txtMaNV.Focus();
        }

        private void onClickMaNV(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("haha");
        }

        private void clickMaNV(object sender, MouseButtonEventArgs e)
        {

            NhanVien nhanVien = (NhanVien)lvNhanVien.SelectedItem;
            MessageBox.Show(nhanVien.ToString());
            
        }
    }
}
