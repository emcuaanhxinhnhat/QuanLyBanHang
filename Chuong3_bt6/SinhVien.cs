using System;
using System.Collections.Generic;
using System.Text;

namespace Chuong3_bt6
{
    class SinhVien
    {
        private string masv;
        private string HoTen;
        private int NamSinh;
        private double DiemLT, DiemCSDL, DiemTB;

        //chuyen privare ==> public ( khong dc trung ten o tren (Masv)) 
        public string Masv
        {
            get
            {
                return this.masv;
            }
            set
            {
                this.masv = value;
            }
        }


        //Hàm khởi tạo không tham số ( tên hàm trùng tên class )

        public SinhVien()
        {
            masv = "";
            HoTen = "";
            NamSinh = 1900;
            DiemLT = DiemCSDL = DiemTB = 0;
        }
        // hàm khởi tạo chứa 5 tham số 

        public SinhVien(string masv, string HoTen, int NamSinh, double DiemLT, double DiemCSDL)
        {
            this.masv = masv;
            this.HoTen= HoTen;
            this.NamSinh = NamSinh;
            this.DiemLT = DiemLT;
            this.DiemCSDL = DiemCSDL;
            this.DiemTB = (DiemLT + DiemCSDL)* 0.5;
        }
    
        public void Nhap()
        {
            Console.WriteLine("Hay nhap ma cua sinh vien:");
            masv = Console.ReadLine();
            Console.WriteLine("Hay nhap ten cua sinh vien:");
            HoTen = Console.ReadLine();
            Console.WriteLine("Hay nhap nam sinh cua sinh vien:");
            NamSinh = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hay nhap diem LT cua sinh vien:");
            DiemLT = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hay nhap diem CSDL cua sinh vien:");
            DiemCSDL = Convert.ToInt32(Console.ReadLine());

            


        }

        public void Xuat ()
        {
            Console.WriteLine(" Ma cua sinh vien la:"+ masv);
            Console.WriteLine(" Ten cua sinh vien la:" + HoTen);
            Console.WriteLine(" Sinh vien sinh nam :" + NamSinh);
            Console.WriteLine("diem LT cua sinh vien la:" + DiemLT);
            Console.WriteLine("Diem CSDL cua sinh vien la:" + DiemCSDL);
            Console.WriteLine(" Diem TB cua sinh vien la:" + DiemTB);

        }

    }
}
