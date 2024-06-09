using QLBH_BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class QLBH_MainFRM : Form
    {
        QLBH_DanhNhapFRM dn;
        QLBH_DoiMatKhau doimk;
        QLBH_ThongTinNhanVien nv;
        BUS_NhanVien busNV = new BUS_NhanVien();

        public static int session = 0;
        public static int profile = 0;
        public static string mail;

        //public string vaitro { get; set; }
        //public string matkhau { get; set; }

        public QLBH_MainFRM()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        // CheckExistForm để kiẻm tra xem 1 form với tên nào đó đã hiển thị trong 
        // Form Cha (Login) chưa? => Trả về True (đã hiển thị) hoặc False (nếu chưa hiển thị)
        private bool CheckExistForm(string name)
        {
            bool check = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }

        // ActiveChildForm dùng để kích hoạt hiện thị lên trên 
        // cùng các trong số các form con nếu nó đã hiện mà ko phải tạo thể hiện mới
        private void ActiveChildForm(string name)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    frm.Activate();
                    break;
                }
            }
        }

        //Show form đăng nhập
        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dn = new QLBH_DanhNhapFRM();
            if (!CheckExistForm("QLBH_DangNhapFRM"))
            {
                dn.MdiParent = this;
                dn.Show();
                dn.FormClosed += new FormClosedEventHandler(QLBH_DanhNhapFRM_FormClosed);
            } else
            {
                ActiveChildForm("QLBH_DangNhapFRM");
            }
        }

        private void VaiTroNv()
        {
            nhânViênToolStripMenuItem.Visible = false;
            thốngKêToolStripMenuItem.Visible = false;
        }

        // thiết lập lại phân quyền khi load form main
        private void ResetValue()
        {
            if (session == 1)
            {
                thôngTinToolStripMenuItem.Text = "Chào " + QLBH_MainFRM.mail;
                đổiMậtKhẩuToolStripMenuItem.Visible = true;
                nhânViênToolStripMenuItem.Visible = true;
                danhMụcToolStripMenuItem.Visible = true;
                đăngXuấtToolStripMenuItem.Enabled = true;
                thốngKêToolStripMenuItem.Visible = true;
                thốngKêSảnPhẩmToolStripMenuItem.Visible = true;
                đăngNhậpToolStripMenuItem.Enabled = false;
                if (int.Parse(dn.vaitro) == 0)
                {
                    VaiTroNv();
                }

            }
            else
            {
                đổiMậtKhẩuToolStripMenuItem.Visible = false;
                nhânViênToolStripMenuItem.Visible = false;
                danhMụcToolStripMenuItem.Visible = false;
                đăngXuấtToolStripMenuItem.Enabled = false;
                thốngKêToolStripMenuItem.Visible = false;
                thốngKêSảnPhẩmToolStripMenuItem.Visible = false;
                đăngNhậpToolStripMenuItem.Enabled = true;
            }
        }

        private void QLBH_DanhNhapFRM_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Refresh();
            QLBH_MainFRM_Load(sender, e);
        }

        private void QLBH_DoiMatKhau_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Refresh();
            QLBH_MainFRM_Load(sender, e);
        }

        private void QLBH_MainFRM_Load(object sender, EventArgs e)
        {
            ResetValue();
            if (profile == 1) // Nếu vừa cập nhật mật khẩu thì 
                              // phải login lại, mục 'thông tin nhân viên ẩn'
            {
                thôngTinToolStripMenuItem.Text = null;
                profile = 0;
            }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thôngTinToolStripMenuItem.Text = null;
            session = 0;
            ResetValue();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("QLBH_DoiMatKhau"))
            {
                doimk = new QLBH_DoiMatKhau(QLBH_MainFRM.mail);
                doimk.MdiParent = this;
                doimk.Show();
                doimk.FormClosed += new FormClosedEventHandler(QLBH_DanhNhapFRM_FormClosed);
            }
            else
            {
                ActiveChildForm("QLBH_DoiMatKhau");
            }
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("QLBH_ThongTinNhanVien"))
            {
                nv = new QLBH_ThongTinNhanVien();
                nv.MdiParent = this;
                nv.Show();
                nv.FormClosed += new FormClosedEventHandler(QLBH_DanhNhapFRM_FormClosed);
            }
            else
            {
                ActiveChildForm("QLBH_ThongTinNhanVien");
            }
        }
    }
}
