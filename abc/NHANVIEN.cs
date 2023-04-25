using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abc
{
    internal class NHANVIEN
    {
        protected string manv;
        protected string hoten;
        protected DateTime ngaysinh;
        protected string gioitinh;
        protected long socm;
        protected DateTime ngayvaocoquan;
        protected double luongcoban = 1490000;
        abstract public double tinhThucLinh();
        abstract public double tinhPhuCap();
        public NHANVIEN()
        { }
        public NHANVIEN(string manv, string hoten, DateTime ngaysinh, string gioitinh, long socm, DateTime ngayvaocoquan)
        {
            this.manv = Manv;
            this.hoten = Hoten;
            this.ngaysinh = Ngaysinh;
            this.gioitinh = Gioitinh;
            this.socm = Socm;
            this.ngayvaocoquan = Ngayvaocoquan;
           
        }
        public string Manv
        {
            set { this.Manv = value; } 
            get { return this.Manv; }
        }
        public string Hoten
        {
            set { this.Hoten = value; }
            get { return this.Hoten; }
        }
        public string Gioitinh
        {
            set { this.Gioitinh = value;}
            get{return this.Gioitinh;}
        }
        public DateTime Ngaysinh
        {
            set { this.Ngaysinh = value; }
            get { return this.Ngaysinh; }
        }
        public long Socm
        {
            set { this.Socm = value; }
            get { return this.Socm; }
        }
        public DateTime Ngayvaocoquan
        {
            set { this.ngayvaocoquan = value; }
            get { return this.ngayvaocoquan; }
        }
        public int tinhthamnien()
        {
            DateTime ngayhientai = DateTime.Today;
            return (int)((ngayhientai - this.Ngayvaocoquan).TotalDays / 365.242199);

        }
        public virtual void Nhap()
        { 
            Console.WriteLine("Nhap ma nhan vien: ");
            this.Manv = Console.ReadLine();
            Console.WriteLine("Nhap ho ten nhan vien: ");
            this.Hoten = Console.ReadLine();
            Console.WriteLine("Nhap ngay sinh nhan vien: ");
            this.Ngaysinh = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Nhap gioi tinh nhan vien: ");
            this.Gioitinh = Console.ReadLine();
            Console.WriteLine("Nhap ngay vao co quan: ");
            this.Ngayvaocoquan = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Nhap socm nhan vien: ");
            this.Socm = long.Parse(Console.ReadLine());
        }
        public virtual void  Xuat()
        {
            Console.WriteLine("Ma nhan vien :" + this.Manv);
            Console.WriteLine("Nhap ho ten nhan vien :" + this.Hoten);
            Console.WriteLine("Nhap Ngay sinh nhan vien :" + this.Ngaysinh.ToString("dd/MM/yyyy"));
            Console.WriteLine("Nhap gioi tinh nhan vien :" + this.Gioitinh);
            Console.WriteLine("Nhap ngay vao co quan cua nhan vien :" + this.Ngayvaocoquan.ToString("dd/MM/yyyy"));
            Console.WriteLine("Nhap socm nhan vien :" + this.Socm);
            Console.WriteLine("tham nien nhan vien :" + this.tinhthamnien());
        }
    }
}
