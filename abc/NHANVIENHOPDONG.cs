using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abc
{
    internal class NHANVIENHOPDONG:NHANVIEN
    {
        private double mucluong;
        public double Mucluong
        {
            set { mucluong = value; }
            get { return mucluong; }
        }
        public NHANVIENHOPDONG() : base() { }
        public NHANVIENHOPDONG(string manv, string hoten, DateTime ngaysinh, string gioitinh, long socm, DateTime ngayvaocoquan, double hesoluong) :
            base(manv, hoten, ngaysinh, gioitinh, socm, ngayvaocoquan)
        {
            this.Mucluong = mucluong;
        }
         override public double tinhPhuCap()
        {
            if (base.tinhthamnien() >= 10)
                return base.luongcoban * 0.1 + 500000;
            else
                return base.luongcoban * 0.1 + 200000;
        }
        override public double tinhThuclinh()
        {
            return (base.luongcoban * this.Mucluong) + this.tinhPhuCap();
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("nhap he so luong: ");

        }
    }
}
