using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HaVanPhong_Thuchanh_13052022
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        ObservableCollection<CuonSach> liem;
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            liem = new ObservableCollection<CuonSach>();
            liem.Add(new CuonSach("1", "van 11", 11, "Văn học", "NXB Văn hóa"));
            datList.ItemsSource = liem;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string error = "";
            try
            {
                string maCuon = edtMaCuon.Text;
                if (maCuon == "" && !Regex.IsMatch(maCuon, @"^S\\d{2}$"))
                {
                    error += "Ma cuon khong hop le\n";
                }

                string tenCuon = edtTenCuon.Text;
                if (tenCuon == "" && !Regex.IsMatch(tenCuon, @"^[a-zA-Z ]+$"))
                {
                    error += "Ten sach khong hop le\n";
                }
                string soTrang = edtSoTrang.Text;
                if (int.Parse(soTrang)<100 || int.Parse(soTrang)>500 && !Regex.IsMatch(tenCuon, @"^\\d{3}$"))
                {
                    error += "So trang phai tu 100 den 500\n";
                }
                string theLoai="";
                if ((bool)rdCNTT.IsChecked)
                {
                    theLoai = "CNTT";
                }
                else if ((bool)rdVanHoc.IsChecked)
                {
                    theLoai = "Văn học";
                }else
                {
                    error += "The loai khong duoc bo trong";
                }
                string nxb = "";
                ComboBoxItem item = (ComboBoxItem)cbNXB.SelectedItem;
                if (item != null)
                {
                    nxb = item.Content.ToString();
                }
                

                if (nxb == "")
                {
                    error += "NXB khong duoc de trong";
                }

                if (error == "")
                {
                    CuonSach cuonSach = new CuonSach(maCuon, tenCuon, int.Parse(soTrang), theLoai, nxb);

                    liem.Add(cuonSach);
                    datList.ItemsSource = liem;
                }else
                {
                    lbError.Content = error;
                }
            } catch (NullReferenceException err)
            {
                error += "Vui long nhap du thong tin";
            }
            catch(Exception err)
            {
                error += err.Message;
            }
            finally
            {
                lbError.Content = error;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            CuonSach cuonSach = (CuonSach)datList.SelectedItems[0];
            Window1 obj = new Window1();
            obj.cs = cuonSach;
            obj.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
