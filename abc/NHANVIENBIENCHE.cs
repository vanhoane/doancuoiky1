using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace abc
{
    internal class NHANVIENBIENCHE:NHANVIEN
    {
        private double hesoluong;
        public double Hesoluong
        {
            set { hesoluong = value; }
            get { return hesoluong; }
        }
        public NHANVIENBIENCHE():base() 
        { }
        public NHANVIENBIENCHE(string manv, string hoten, DateTime ngaysinh, string gioitinh, long socm, DateTime ngayvaocoquan, double hesoluong):
            base(manv, hoten, ngaysinh, gioitinh, socm, ngayvaocoquan)
        {
            this.hesoluong = hesoluong;
        }
        public double tinhPhuCap()
        {
            if (base.tinhthamnien() >= 10)
                return base.luongcoban * 0.1 + 500000;
            else
                return base.luongcoban * 0.1 + 200000;
        }
        public double tinhThuclinh()
        {
            return(base.luongcoban * this.hesoluong) + this.tinhPhuCap();
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap he so luong: ");
            this.hesoluong = double.Parse(Console.ReadLine());

        }
        public override void Xuat()
        {
            base.Xuat();
            Console.Write("he so luong: "+this.hesoluong);
            Console.Write("than nien:"+   base.tinhthamnien());
            Console.Write("He so luong" + this.tinhThuclinh());
        }
        
    }
}
