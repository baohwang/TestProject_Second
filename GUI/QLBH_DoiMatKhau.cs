using QLBH_BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class QLBH_DoiMatKhau : Form
    {
        string stremail;
        BUS_NhanVien busNV = new BUS_NhanVien();
        QLBH_DanhNhapFRM dn = new QLBH_DanhNhapFRM();

        public QLBH_DoiMatKhau(string email)
        {
            InitializeComponent();
            stremail = email;
            txtEmail.Text = stremail;
            txtEmail.Enabled = false;
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            if(txtMatKhauCu.Text.Trim().Length == 0) //Kiem tra du lieu hop phap
            {
                MessageBox.Show("Vui long nhap mat khau cu", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMatKhauCu.Focus();
                return;
            } else if (txtMatKhauMoi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui long nhap mat khau moi", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMatKhauMoi.Focus();
                return;
            } else if(txtConfirmPass.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui long xac nhan mat khau moi", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtConfirmPass.Focus();
                return;
            }
            else
            {
                if(MessageBox.Show("Bạn chắc chắn muốn đổi mật khẩu", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    string matKhauMoi = busNV.encryption(txtMatKhauMoi.Text);
                    string matKhauCu = busNV.encryption(txtMatKhauCu.Text);
                    if (busNV.UpdateMatKhau(txtEmail.Text, txtMatKhauCu.Text, txtMatKhauMoi.Text))
                    {
                        QLBH_MainFRM.profile = 1; //Update password successfully
                        QLBH_MainFRM.session = 0; //Return to non-user status
                        MessageBox.Show("Cap nhat mat khau thanh cong, ban phai dang nhap lai");
                        dn.SendMail(stremail, txtConfirmPass.Text);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Cap nhat mat khau that bai!");
                        txtConfirmPass.Clear();
                        txtMatKhauCu.Clear();
                        txtMatKhauMoi.Clear();
                        txtMatKhauMoi.Focus();
                    }
                }else
                {
                    txtConfirmPass.Clear();
                    txtMatKhauCu.Clear();
                    txtMatKhauMoi.Clear();
                }
            }
        }

        private void QLBH_DoiMatKhau_Load(object sender, EventArgs e)
        {

        }
    }
}
