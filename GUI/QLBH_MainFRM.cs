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

        public QLBH_MainFRM()
        {
            InitializeComponent();
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
            if(!CheckExistForm("QLBH_DangNhapFRM"))
            {
                dn.MdiParent = this;
                dn.Show();
            } else
            {
                ActiveChildForm("QLBH_DangNhapFRM");
            }
        }
    }
}
