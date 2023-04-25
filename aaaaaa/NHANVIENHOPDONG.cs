using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aaaaaa
{
    class NHANVIENHOPDONG : NHANVIEN
    {
        private double mucluong;
        public double Mucluong
        {
            set { this.mucluong = value; }
            get { return this.mucluong; }
        }

        public double Hesoluong { get; internal set; }

        public NHANVIENHOPDONG() : base() { }
        public NHANVIENHOPDONG(string manv, string hoten, DateTime ngaysinh, string gioitinh,
            long socm, DateTime ngayvaocoquan, double mucluong) :
            base(manv, hoten, ngaysinh, gioitinh, socm, ngayvaocoquan)
        {
            this.mucluong = mucluong;
        }
        override public double tinhPhuCap()
        {
            if (base.tinhThamnien() >= 2)
                return this.mucluong * 0.1 + 200000;
            else
                return this.mucluong * 0.1 + 100000;
        }
        override public double tinhThucLinh()
        {
            return (base.luongcoban + this.mucluong) + this.tinhPhuCap();
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap he so luong:");
            this.mucluong = double.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.Write("He so luong:" + this.mucluong);
            Console.Write("Than nien:" + base.tinhThamnien());
            Console.Write("He so luong:" + this.tinhThucLinh());
        }

    }
}
