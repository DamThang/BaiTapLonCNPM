using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTHUVIEN.Object
{
    class sachObj
    {
        string masach, nhande, sotrang, soluong, namxb, lanxb, solanmuon, maloai, nxb, tacgia, ngaynhap;

        public sachObj() { }
        public sachObj(string masach, string nhande, string sotrang, string soluong, string namxb, string lanxb, string solanmuon, string maloai, string nxb, string tacgia, string ngaynhap)
        {
            this.Masach = masach;
            this.Nhande = nhande;
            this.Sotrang = sotrang;
            this.Soluong = soluong;
            this.Namxb = namxb;
            this.Lanxb = lanxb;
            this.Solanmuon = solanmuon;
            this.Maloai = maloai;
            this.Nxb = nxb;
            this.Tacgia = tacgia;
            this.Ngaynhap = ngaynhap;
        }

        public string Lanxb
        {
            get
            {
                return lanxb;
            }

            set
            {
                lanxb = value;
            }
        }

        public string Maloai
        {
            get
            {
                return maloai;
            }

            set
            {
                maloai = value;
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

        public string Namxb
        {
            get
            {
                return namxb;
            }

            set
            {
                namxb = value;
            }
        }

        public string Ngaynhap
        {
            get
            {
                return ngaynhap;
            }

            set
            {
                ngaynhap = value;
            }
        }

        public string Nhande
        {
            get
            {
                return nhande;
            }

            set
            {
                nhande = value;
            }
        }

        public string Nxb
        {
            get
            {
                return nxb;
            }

            set
            {
                nxb = value;
            }
        }

        public string Solanmuon
        {
            get
            {
                return solanmuon;
            }

            set
            {
                solanmuon = value;
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

        public string Sotrang
        {
            get
            {
                return sotrang;
            }

            set
            {
                sotrang = value;
            }
        }

        public string Tacgia
        {
            get
            {
                return tacgia;
            }

            set
            {
                tacgia = value;
            }
        }
    }
}
