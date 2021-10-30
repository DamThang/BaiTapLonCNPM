using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QLTV
{
    class clSach
    {
        private String masach;
        private String nhande;
        private int sotrang;
        private int namxb;
        private int lanxb;
        private int solanmuon;
        private String maloai;
        private String nxb;
        private String tacgia;
        private String ngaynhap;
        
        public clSach()
        {
            this.masach = "";
            this.nhande = "";
            this.sotrang = 0;
            this.solanmuon = 0;
            this.namxb = 0;
            this.lanxb = 0;
            this.maloai = "";
            this.nxb = "";
            this.tacgia = "";
            this.ngaynhap = "";
        }

        public clSach(String ms, String nd, String loai, String nxb, String tg, String ngay, int st, int namxb, int lanxb, int slm)
        {
            this.masach = ms;
            this.nhande = nd;
            this.maloai = loai;
            this.nxb = nxb;
            this.tacgia = tg;
            this.ngaynhap = ngay;
            this.sotrang = st;
            this.solanmuon = slm;
            this.namxb = namxb;
            this.lanxb = lanxb;
        }
        
    }
}
