using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTablePrettyPrinter;

namespace aaaaaa
{
    abstract class NHANVIEN
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
        public String Manv
        {
            set { this.manv = value; }
            get { return this.manv; }
        }
        public String Hoten
        {
            set { this.hoten = value; }
            get { return this.hoten; }
        }
        public String Gioitinh
        {
            set { this.gioitinh = value; }
            get { return this.gioitinh; }
        }
        public DateTime Ngaysinh
        {
            set { this.ngaysinh = value; }
            get { return this.ngaysinh; }
        }
        public DateTime Ngayvaocoquan
        {
            set { this.ngayvaocoquan = value; }
            get { return this.ngayvaocoquan; }
        }
        public long SoCM
        {
            set { this.socm = value; }
            get { return this.socm; }
        }
        public NHANVIEN()
        { }
        public NHANVIEN(string manv, string hoten, DateTime ngaysinh, string gioitinh,
            long socm, DateTime ngayvaocoquan)
        {
            this.manv = manv;
            this.hoten = hoten;
            this.ngaysinh = ngaysinh;
            this.gioitinh = gioitinh;
            this.socm = socm;
            this.ngayvaocoquan = ngayvaocoquan;
        }
        public int tinhThamnien()
        {
            DateTime ngayhientai = DateTime.Today;
            return (int)((ngayhientai - this.ngayvaocoquan).TotalDays / 365.242199);
        }
        public virtual void Nhap()
        {
            Console.WriteLine("Nhap ma nhan vien:");
            this.manv = Console.ReadLine();
            Console.WriteLine("Nhap ho ten nhan vien:");
            this.hoten = Console.ReadLine();
            Console.WriteLine("Nhap ngay sinh nhan vien:");
            this.ngaysinh = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Nhap gioi tinh nhan vien:");
            this.gioitinh = Console.ReadLine();
            Console.WriteLine("Nhap vao co quan nhan vien:");
            this.Ngayvaocoquan = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so chung minh nhan vien:");
            this.socm = long.Parse(Console.ReadLine());
        }
        public virtual void Xuat()
        {


            //Console.WriteLine("Ma nhan vien:" + this.manv);
            //Console.WriteLine("Ho ten nhan vien:" + this.hoten);
            //Console.WriteLine("Ngay sinh nhan vien:" + this.ngaysinh.ToString("dd/MM/yyyy"));
            //Console.WriteLine("Gioi tinh nhan vien:" + this.gioitinh);
            //Console.WriteLine("Ngay vao co quan nhan vien:" + this.Ngayvaocoquan.ToString("dd/MM/yyyy"));
            //Console.WriteLine("So chung minh nhan vien:" + this.socm);
            //Console.WriteLine("Tham nien nhan vien:" + this.tinhThamnien());
        }
    }
}