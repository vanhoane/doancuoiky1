using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abc
{
    internal class DANHSACHNHANVIEN
    {
        Dictionary<string, NHANVIEN> listStaff;
        public DANHSACHNHANVIEN()
        {
            this.listStaff = new Dictionary<string, NHANVIEN>();
        }

        public void Nhap()
            {
                char k = 'y';
                while (k == 'y')
                {
                    NHANVIEN nv = null;
                    char loai = ' ';
                    Console.WriteLine("Nhap ky tu (B) Bien Che (H) Hop Dong: ");
                    loai = Convert.ToChar(Console.ReadLine().ToUpper());
                    switch (loai)
                    {
                        case 'B':
                            {
                                nv = new NHANVIENBIENCHE();
                                nv.Nhap();
                                break;
                            }
                        case 'H':
                            {
                                nv = new NHANVIENHOPDONG();
                                nv.Nhap();
                                break;
                            }
                    }//end s
                    if (nv != null) { this.listStaff.Add(nv.Manv, nv); }
                    Console.WriteLine("Nhap ky tu 'y' de tiep tuc");
                    k = Convert.ToChar(Console.ReadLine());
                }
            }
        public void Xuat()
        {
            foreach (NHANVIEN nv in listStaff.Values) 
                nv.Xuat();
        }//end xuat
        public NHANVIEN Tim()
        {
            Console.WriteLine("Nhap ma nhan vien can tim: ");
            string manv = Console.ReadLine();
            return this.listStaff[manv];
        }//end tim
        public void Xoa()
        {
            Console.WriteLine("nhap ma nv can xoa:");
            string manv = Console.ReadLine() ;
            this.listStaff.Remove(manv);
        }//end xoa
        public void thongke()
        {
            int tongbienche = 0; int tonghopdong = 0;
            foreach (NHANVIEN nv in listStaff.Values)
            {
                if (nv is NHANVIENBIENCHE) 
                    tongbienche++;
                else if (nv is NHANVIENHOPDONG)
                        tonghopdong++;
            }
            Console.WriteLine("Tong so nhan vien bien che hien co: " + tongbienche);
            Console.WriteLine("tong so nhan vien vien hop dong hien co: " + tonghopdong);
        }//end thongke
        public void tinhTongQuyLuong()
        {
            double tongluong = 0;
            foreach (NHANVIEN nv in this.listStaff.Values)
            {
                if (nv is NHANVIENBIENCHE)
                    tongluong += ((NHANVIENBIENCHE)nv).tinhThuclinh();
                else if (nv is NHANVIENHOPDONG)
                    tongluong += ((NHANVIENHOPDONG)nv).tinhThuclinh();
        }
            Console.WriteLine("tong quy luong" + tongluong);
        }

    }
}
