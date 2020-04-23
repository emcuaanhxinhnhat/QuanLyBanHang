using System;

namespace Chuong3_bt6
{
    class Program
    {
        static void Main(string[] args)
        {
            DanhSachSinhVien htttaK21 = new DanhSachSinhVien();
            htttaK21.Nhap();
            
            htttaK21.SapXep();
            htttaK21.Xuat();

            Console.ReadLine();

        }
    }
}
