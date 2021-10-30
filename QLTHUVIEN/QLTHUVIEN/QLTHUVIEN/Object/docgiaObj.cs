using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTHUVIEN.Object
{
    class docgiaObj
    {
        string madocgia, hoten, ngaysinh, makhoa, diachi, ngaylapthe, matkhau;


        public docgiaObj()
        { }
        public docgiaObj(string madocgia, string hoten, string ngaysinh, string makhoa, string diachi, string ngaylapthe, string matkhau)
        {
            this.madocgia = madocgia;
            this.hoten = hoten;
            this.ngaysinh = ngaysinh;
            this.makhoa = makhoa;
            this.diachi = diachi;
            this.ngaylapthe = ngaylapthe;
            this.matkhau = matkhau;
        }

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

        public string Madocgia
        {
            get
            {
                return madocgia;
            }

            set
            {
                madocgia = value;
            }
        }

        public string Makhoa
        {
            get
            {
                return makhoa;
            }

            set
            {
                makhoa = value;
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

        public string Ngaylapthe
        {
            get
            {
                return ngaylapthe;
            }

            set
            {
                ngaylapthe = value;
            }
        }

        public string Ngaysinh
        {
            get
            {
                return ngaysinh;
            }

            set
            {
                ngaysinh = value;
            }
        }
    }
}
