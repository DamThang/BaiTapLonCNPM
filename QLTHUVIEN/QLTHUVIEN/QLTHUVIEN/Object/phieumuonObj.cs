using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTHUVIEN.Object
{
    class phieumuonObj
    {
        string madocgia, mgaymuon, masach, manhanvien, soluong, trangthai;

        public phieumuonObj() { }
        public phieumuonObj(string madocgia, string mgaymuon, string masach, string manhanvien, string soluong, string trangthai)
        {
            this.madocgia = madocgia;
            this.mgaymuon = mgaymuon;
            this.masach = masach;
            this.manhanvien = manhanvien;
            this.soluong = soluong;
            this.trangthai = trangthai;
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

        public string Masach
        {
            get
            {
                return masach;
            }

            set
            {
                masach = value;
            }
        }

        public string Mgaymuon
        {
            get
            {
                return mgaymuon;
            }

            set
            {
                mgaymuon = value;
            }
        }

        public string Soluong
        {
            get
            {
                return soluong;
            }

            set
            {
                soluong = value;
            }
        }

        public string Trangthai
        {
            get
            {
                return trangthai;
            }

            set
            {
                trangthai = value;
            }
        }
    }
}
