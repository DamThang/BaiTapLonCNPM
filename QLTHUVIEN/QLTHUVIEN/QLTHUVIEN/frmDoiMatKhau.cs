using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTHUVIEN
{
    public partial class frmdoimk : Form
    {
        xuly xl = new xuly();
        public static string UsertName = "";
        Connection cn = new Connection();
        public frmdoimk()
        {
            InitializeComponent();
        }

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmdoimk_Load(object sender, EventArgs e)
        {
            txtUser.Text = UsertName;
            txtUser.Enabled = false;
            txtmkcu.Focus();
        }

        private void btndoimk_Click(object sender, EventArgs e)
        {
            string mkmoi = txtmkmoi.Text;
            string mkmoi2 = txtnhaplaimkmoi.Text;
            string mkcu = txtmkcu.Text;
            string mkcu2 = lblmkcu.Text;
            if (mkcu == "" || mkmoi == "" || mkmoi2 == "")
            {
                MessageBox.Show("Không được bỏ trống!");
                txtmkcu.Clear();
                txtmkmoi.Clear();
                txtnhaplaimkmoi.Clear();
                txtmkcu.Focus();
            }
            else           
                if(frmDangnhap.quyenhan == "admin" || frmDangnhap.quyenhan == "thuthu")
                {
                    if (txtmkmoi.Text.CompareTo(txtnhaplaimkmoi.Text) == 0)
                    {
                        cn.OpenConn();
                        string cm1 = "update  nhanvien set matkhau='" + txtmkmoi.Text + "' where manhanvien='" + txtUser.Text + "' and matkhau ='" + txtmkcu.Text + "' ";
                        try
                        {
                            if (cn.executeUpdate(cm1) == true)

                            { MessageBox.Show("Cập nhật mật khẩu thành công"); this.Dispose(); }
                            else
                                MessageBox.Show("Mật khẩu củ không trùng khớp!");
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show("" + ex.ToString());
                        }
                    }
                    else
                        MessageBox.Show("Mật khẩu mới không trùng khớp!");
                 }
                 else
                    if (txtmkmoi.Text.CompareTo(txtnhaplaimkmoi.Text) == 0)
                    {
                        cn.OpenConn();
                        string cm1 = "update  docgia set matkhau='" + txtmkmoi.Text + "' where madocgia='" + txtUser.Text + "' and matkhau ='" + txtmkcu.Text + "' ";
                        try
                        {
                            if (cn.executeUpdate(cm1) == true)

                            { MessageBox.Show("Cập nhật mật khẩu thành công"); this.Dispose(); }
                            else
                                MessageBox.Show("Mật khẩu củ không trùng khớp!");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("" + ex.ToString());
                        }
                    }
                    else
                        MessageBox.Show("Mật khẩu mới không trùng khớp!");
        }
    }
}
   
    
    

    
       
