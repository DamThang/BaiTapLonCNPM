using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLTV
{
    public partial class frminpm : Form
    {
        Connect conn = new Connect();
        public String madg = "";
        public String masach = "";
        public frminpm()
        {
            InitializeComponent();
        }

        public void Load_cr()
        {
            DataTable dt = new DataTable();
            dt = conn.Table("SELECT phieumuon.madocgia, phieumuon.ngaymuon, phieumuon.masach, phieumuon.manhanvien, phieumuon.ngaytra, docgia.hoten, docgia.diachi, nhanvien.hoten AS Expr1, sach.nhande, sach.tacgia FROM phieumuon INNER JOIN docgia ON phieumuon.madocgia = docgia.madocgia INNER JOIN nhanvien ON phieumuon.manhanvien = nhanvien.manhanvien INNER JOIN sach ON phieumuon.masach = sach.masach WHERE phieumuon.madocgia = '" + madg + "' AND phieumuon.masach = '" + masach + "'");
            CRPhieumuon cr = new CRPhieumuon();
            cr.SetDataSource(dt);
            crystalReportViewer1.ReportSource = cr;
        }
        private void frminpm_Load(object sender, EventArgs e)
        {
            Load_cr();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
