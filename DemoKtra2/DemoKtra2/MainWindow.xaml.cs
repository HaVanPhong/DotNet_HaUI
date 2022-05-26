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
using System.Collections.ObjectModel;

namespace DemoKtra2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<NhanVien> liem;
        public MainWindow()
        {
            InitializeComponent();
            liem= new ObservableCollection<NhanVien>();
            liem.Add(new NhanVien(1, "DUong", "nam", "1-1-2001", 1000, 44));
            //dataList.ItemsSource = liem;
            //dataList.ColumnWidth = 130;
            dob.SelectedDate=DateTime.Today.AddDays(-1);
        }


        private void Thoat(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Them(object sender, RoutedEventArgs e)
        {
            int maNV = int.Parse(edtMaNV.Text);
            string hoTen = edtHoTen.Text;
            string gioiTinh = "Nam";
            if (rdNam.IsChecked==true)
            {
                gioiTinh = "Nam";
            }else
            {
                gioiTinh = "Nữ";
            }
            string ngaySinh= dob.DisplayDate.ToString();
            long luongNgay = long.Parse(edtLuongNgay.Text);
            int soNgay = int.Parse(edtSoNgayLam.Text);
            NhanVien nhanVien = new NhanVien(maNV, hoTen, gioiTinh, ngaySinh, luongNgay, soNgay);
            liem.Add(nhanVien);
            //dataList.ItemsSource = liem;
        }

        private void chiTiet(object sender, RoutedEventArgs e)
        {
            //NhanVien nhanVien = (NhanVien)dataList.SelectedItems[0];
            Form2 fr = new Form2();
            fr.nhanVien = "hahahaa";
            fr.ShowDialog();
        }
    }
}
