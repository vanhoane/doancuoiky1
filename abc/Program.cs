using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace abc
{
    internal class Program
    {
        static DANHSACHNHANVIEN danhsach;
        static void Menu()
        {
            Console.WriteLine(" Nhap tu 1-6 de thuc hien cac chuc nang sau:");
            Console.WriteLine("1. Nhap nhan vien");
            Console.WriteLine("2. Xuat nhan vien");
            Console.WriteLine("3. Tim nhan vien");
            Console.WriteLine("4. Xoa nhan vien");
            Console.WriteLine("5. Thong ke nhan vien");
            Console.WriteLine("6. tinh tong quy luong");
            int menu = 0;
            menu = Convert.ToInt32(Console.ReadLine());
            switch (menu)
            {
                case 1:
                    {
                        danhsach.Nhap();
                        break;
                    }
                case 2:
                    {
                        danhsach.Xuat();
                        break;
                    }
                case 3:
                    {
                        danhsach.Tim().Xuat();
                        break;
                    }
                case 4:
                    {
                        danhsach.Xoa();
                        break;
                    }
                case 5:
                    {
                        danhsach.thongke();
                        break;
                    }
                case 6:
                    {
                        danhsach.tinhTongQuyLuong();
                        break;
                    }
            }// end switch
        }//end Menu
        static void Main(string[] args)
        {
            danhsach = new DANHSACHNHANVIEN();
            char c = 'y';
            while (c == 'y')
            {
                Menu();
                Console.WriteLine("Nhap ky tu 'y' de tro ve menu");
                c = Convert.ToChar(Console.ReadLine().ToLower());
            }
        }
    }
}
 
