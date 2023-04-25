using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aaaaaa
{
    class NHANVIENBIENCHE : NHANVIEN
    {
        private double hesoluong;
        public double Hesoluong
        {
            set { this.hesoluong = value; }
            get { return this.hesoluong; }
        }
        public NHANVIENBIENCHE() : base()
        { }
        public NHANVIENBIENCHE(string manv, string hoten, DateTime ngaysinh, string gioitinh,
            long socm, DateTime ngayvaocoquan, double hesoluong) :
            base(manv, hoten, ngaysinh, gioitinh, socm, ngayvaocoquan)
        {
            this.hesoluong = hesoluong;
        }
        override public double tinhPhuCap()
        {
            if (base.tinhThamnien() >= 10)
                return base.luongcoban * 0.1 + 500000;
            else
                return base.luongcoban * 0.1 + 200000;
        }
        override public double tinhThucLinh()
        {
            return (base.luongcoban * this.hesoluong) + this.tinhPhuCap();
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap he so luong:");
            this.hesoluong = double.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.Write("He so luong:" + this.hesoluong);
            Console.Write("Than nien:" + base.tinhThamnien());
            Console.Write("He so luong:" + this.tinhThucLinh());
        }
    }
}
