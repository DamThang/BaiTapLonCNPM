using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTHUVIEN.Object
{
    class nhanvienObj
    {
        string manhanvien, hoten, diachi, tendangnhap, quyenhan, matkhau;

        public string Diachi
        {
            get
            {
                return diachi;
            }

            set
            {
                diachi = value;
            }
        }

        public string Hoten
        {
            get
            {
                return hoten;
            }

            set
            {
                hoten = value;
            }
        }

        public string Manhanvien
        {
            get
            {
                return manhanvien;
            }

            set
            {
                manhanvien = value;
            }
        }

        public string Matkhau
        {
            get
            {
                return matkhau;
            }

            set
            {
                matkhau = value;
            }
        }

        public string Quyenhan
        {
            get
            {
                return quyenhan;
            }

            set
            {
                quyenhan = value;
            }
        }

        public string Tendangnhap
        {
            get
            {
                return tendangnhap;
            }

            set
            {
                tendangnhap = value;
            }
        }

        public nhanvienObj()
        { }
        public nhanvienObj(string manhanvien, string hoten, string diachi, string tendangnhap, string quyenhan, string matkhau)
        {
            this.manhanvien = manhanvien;
            this.hoten = hoten;
            this.diachi = diachi;
            this.tendangnhap = tendangnhap;
            this.quyenhan = quyenhan;
            this.matkhau = matkhau;
        }

    }
}
