using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTablePrettyPrinter;

namespace aaaaaa
{
    class DANHSACHNHANVIEN:INPUTOUTPUT
    {
        Dictionary<String, NHANVIEN> listStaff;
        public DANHSACHNHANVIEN()
        {
            this.listStaff = new Dictionary<string, NHANVIEN>();
        }
        public void Nhap()
        {
            char c = 'y';
            while (c == 'y')
            {
                NHANVIEN nv = null;
                char loai = ' ';
                Console.WriteLine("Nhap ky tu (B) bien che (H) hop dong");
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
                }//end switch
                if (nv != null)
                    this.listStaff.Add(nv.Manv, nv);
                Console.WriteLine("Nhap ky tu 'y' de tiep tuc");
                c = Convert.ToChar(Console.ReadLine());
            }// end while
        }//end Nhap()

        public void Xuat()
        {

            DataTable table = new DataTable("DANHSACHNHANVOEN");

            table.Columns.Add("Ma nhan vien", typeof(string));
            table.Columns.Add("Ho ten", typeof(String));
            table.Columns.Add("Ngay sinh", typeof(DateTime));
            table.Columns.Add("gioi tinh", typeof(String));
            table.Columns.Add("Ngayvao co quan", typeof(DateTime));
            table.Columns.Add("So chung minh", typeof(long));

            foreach (NHANVIEN nv in listStaff.Values)
                table.Rows.Add(nv.Manv, nv.Hoten, nv.Ngaysinh.ToString("dd/MM/yyyy"), nv.Gioitinh,nv.Ngayvaocoquan,nv.SoCM);

            Console.WriteLine(table.ToPrettyPrintedString());
            //Console.WriteLine("Mã nhân viên |      Họ Tên    |  Ngày sinh  |    Giơi tính |   Số Chứng minh |  Phụ Cấp |  thực lĩnh|");
            //foreach (NHANVIEN nv in listStaff.Values)
            //    Console.WriteLine("{0,2} {1,10} {2,20}", nv.Manv, nv.Hoten, nv.Ngaysinh.ToString("dd/MM/yyyy"));
        }//end Xuat()
        public NHANVIEN Tim()
        {
            Console.WriteLine("Nhap ma nv can tim:");
            String manv = Console.ReadLine();
            return this.listStaff[manv];
        }// end tim()
        public void Xoa()
        {
            Console.WriteLine("Nhap ma nv can xoa:");
            String manv = Console.ReadLine();
            this.listStaff.Remove(manv);
        }// end Xoa()
        public void thongke()
        {
            int tongbienche = 0; int tonghopdong = 0;
            foreach (NHANVIEN nv in this.listStaff.Values)
            {
                if (nv is NHANVIENBIENCHE)
                    tongbienche++;
                else if (nv is NHANVIENHOPDONG)
                    tonghopdong++;
            }
            Console.WriteLine("Tong so nhan vien bien che hien co:" + tongbienche);
            Console.WriteLine("Tong so nhan vien hop dong hien co:" + tonghopdong);
        }// end thongke()
        public void tinhTongQuyLuong()
        {
            double tongluong = 0;
            foreach (NHANVIEN nv in this.listStaff.Values)
            {

                tongluong += nv.tinhThucLinh();

            }
            Console.WriteLine("tong quy luong:" + tongluong);
        }//end tinhTongQuyLuong()
        public void ReadFile()
        {
            string filename = "C:\\Users\\DN_Hocvien\\Documents\\QUANLYNHANVIEN.txt";
            string[] AllLines=File.ReadAllLines(filename);
            foreach(String line in AllLines)
            {
                string[] infor = line.Split(',');
                NHANVIEN nv = null;
                if (infor[0] == "B")
                {
                    nv = new NHANVIENBIENCHE();
                    ((NHANVIENBIENCHE)nv).Hesoluong= double.Parse(infor[7]);
                }
                else
                {
                    nv = new NHANVIENHOPDONG();
                    ((NHANVIENHOPDONG)nv).Mucluong = double.Parse(infor[7]);
                }
                nv.Manv = infor[1];
                nv.Hoten= infor[2];
                nv.Gioitinh= infor[3];
                nv.Ngaysinh = DateTime.Parse(infor[4]);
                nv.SoCM = long.Parse(infor[5]);
                nv.Ngayvaocoquan = DateTime.Parse(infor[6]);
                this.listStaff.Add(nv.Manv, nv);
            }//end foreach
        }
        public void WriteFile()
        {
            string filename = "C:\\Users\\DN_Hocvien\\Documents\\QUANLYNHANVIEN.txt";
            StreamWriter writer = new StreamWriter(filename);
            foreach(NHANVIEN nv in listStaff.Values)
            {
                string infor = null;
                double hesoluong_mucluong;
                if (nv is NHANVIENBIENCHE)
                {
                    infor = "B,";
                    hesoluong_mucluong = ((NHANVIENBIENCHE)(nv)).Hesoluong;
                }
                else
                {
                    infor = "H,";
                    hesoluong_mucluong = ((NHANVIENHOPDONG)(nv)).Hesoluong;
                }
                infor += nv.Manv + ","
                    + nv.Hoten + ","
                    + nv.Gioitinh + ","
                    + nv.Ngaysinh.ToString("dd/MM/yyyy") + ","
                    + nv.SoCM + ","
                    + nv.Ngayvaocoquan.ToString("dd/MM/yyyy") + ","
                    + hesoluong_mucluong;
                writer.WriteLine(infor);
            }//end foreach
            writer.Close();
        }
    }//end class DANHSACHNHANVIEN
}
