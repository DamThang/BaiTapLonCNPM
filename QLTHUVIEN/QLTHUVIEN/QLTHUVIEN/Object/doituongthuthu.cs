using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLTHUVIEN.Object
{
    class doituongthuthu
    {
        string mathuthu, hoten, diachi, tendangnhap, quyenhan, matkhau;

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

        public string Mathuthu
        {
            get
            {
                return mathuthu;
            }

            set
            {
                mathuthu = value;
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

        public doituongthuthu()
        { }
        public doituongthuthu(string mathuthu, string hoten, string diachi, string tendangnhap, string quyenhan, string matkhau)
        {
            this.mathuthu = mathuthu;
            this.hoten = hoten;
            this.diachi = diachi;
            this.tendangnhap = tendangnhap;
            this.quyenhan = quyenhan;
            this.matkhau = matkhau;
        }
    }
}
