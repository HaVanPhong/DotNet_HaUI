   M S B A M L   `   `   `  ����A  =BaiMau, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:BaiMauBaiMau  5   	       BaiMau.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:BaiMau     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   o� $��25��6   $��Stretch=�6   $	��Top=�69   .@�5      m� $��Hệ thống��6   .@�5      m� -   5        $��Thoát��5      6*   5      m� 5      $��Quản lý nhân viên��6   .@�5      m� -   5        $��Thêm��5      6)   m� 5      -   5        $��Hiển thị��5      6-   m� 5      -   5        $
��Xoá��5      6(   5      5      �� 5   
   $��Quản lý nhân viên��6   $
��Left=�6,   $��
394,30,0,0q�6G   $	��Top=�6[   $��18(�6s   $��Times New Roman)�6�   $
��Bold"�6�   �� 5   
   $��Mã nhân viên:��6   $
��Left=�6(   $��	84,60,0,0q�6C   $	��Top=�6V   �� 5   
   $��
Họ tên:��6   $
��Left=�6"   $��
84,100,0,0q�6=   $	��Top=�6Q   �� 5   
   $��Giới tính:��6   $
��Left=�6%   $��
84,140,0,0q�6@   $	��Top=�6T   �� 5   
   $��Ngày tháng năm sinh:��6   $
��Left=�6/   $��
84,180,0,0q�6J   $	��Top=�6^   �� 5   
   $��Tiền lương ngày:��6   $
��Left=�6+   $��
84,220,0,0q�6F   $	��Top=�6Z   �� 5   
   $��Số ngày làm việc:��6   $
��Left=�6,   $��
84,260,0,0q�6G   $	��Top=�6[   �� 5   
   -   5         ��Name$ txtMaNV��5      $
��Left=�6#   $��
226,60,0,0q�6>    �� TextWrapping$
 Wrap=�6R   $	��Top=�6f   $	��220��6~   $��26��6�   �� 5   
   -   5        $ txtHoTen��5      $
��Left=�6$   $��226,100,0,0q�6?   $
 Wrap=�6T   $	��Top=�6h   $	��220��6�   $��26��6�   	� 5   
   -   5         	�Name$ rbNam��5       d� 	IsChecked$
 TrueY�6%   $	��Nam��66   $
��Left=�6D   $��226,146,0,0q�6_   $	��Top=�6t    	� 	GroupName$ gioitinh��6�   	� 5   
   -   5        $
 rbNu��5      $
��Nữ��6$   $
��Left=�61   $��296,146,0,0q�6L   $	��Top=�6a   $ gioitinh��6y   (  "System.Windows.Controls.DatePicker  5   
   -	   5          Name$ 
dpNgaySinh��5      $
��Left=�6)   $��226,182,0,0q�6D   $	��Top=�6Y   $	��148��6q   �� 5    
   -
   5        $ txtTienLuongNgay��5       $
��Left=�6,   $��226,220,0,0q�6G   $
 Wrap=�6\   $	��Top=�6p   $	��220��6�   $��26��6�   �� 5!   
   -   5        $ 
txtNgayLam��5!      $
��Left=�6&   $��226,260,0,0q�6A   $
 Wrap=�6V   $	��Top=�6j   $	��220��6�   $��26��6�   �� 5"   
   -   5         ��Name$ 
lvNhanVien��5"      $��10,291,10,0q�6R    �� View 5#      �� 5$      .P�5%      �� $��Mã NV��6%   	 �� Width$	 50��6Z   
 �� DisplayMemberBinding
 64   �� *MaNV+6Z   �� 5&      $��	Họ tên��6%   $		 115��6\   
 65   �� *HoTen+6\   �� 5'      $��Giới tính��6%   $	 70��6b   
 68   �� *
GioiTinh+6b   �� 5(      $��
Ngày sinh��6%   $		 100��6b   
 68   �� *
NgaySinh+6b   �� 5)      $��Lương ngày��6%   $	 80��6`   
 69   �� *Luong+6`   �� 5*      $��Số ngày làm việc��6%   $		 100��6?   
 6K   �� *	SoNgayLam+�� 5+      $��Tiền lương��6%   $	 90��6d   
 69   �� *	TienLuong+6d   5,      5.      50      51      