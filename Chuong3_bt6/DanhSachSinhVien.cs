using System;
using System.Collections.Generic;
using System.Text;

namespace Chuong3_bt6
{
    class DanhSachSinhVien
    {
        private int n;
        private SinhVien[] DS;

        public void Nhap()
        {
            Console.WriteLine("Hay nhap so sinh vien trong danh sach:");
            n = Convert.ToInt32(Console.ReadLine());


            DS = new SinhVien[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Hay nhap thong tin cho sinh vien thu:" + i);
                DS[i] = new SinhVien();
                DS[i].Nhap();
            }
        }
            
        public void Xuat()
        {
                if (DS != null && n>0 )
                {
                    for (int i=0; i<n; i++)
                    {
                    DS[i].Xuat();
                    }    
                }    
        }

        public void SapXep() // sap xep theo thu tu tang dan 
        {
            for (int i=0;i<n-1;i++)
                for (int j=i+1; j<n;j++)
                {
                    if ( String.Compare(DS[i].Masv,DS[j].Masv, true) >0)
                    {
                        SinhVien tg = new SinhVien();
                        tg = DS[i];
                        DS[i] = DS[j];
                        DS[j] = tg;

                    }    
                }    
        }

    }
}

