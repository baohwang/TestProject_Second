using QLBH_BUS;
using QLBH_DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class QLBH_ThongTinKhachHang : Form
    {
        BUS_KhachHang busKH = new BUS_KhachHang();
        string stremail = QLBH_MainFRM.mail; //Nhận mail từ form main

        public QLBH_ThongTinKhachHang()
        {
            InitializeComponent();
        }

        private void ResetValues()
        {
            txtSearch.Text = "Nhập vào số điện thoại...";
            txtDienThoai.Text = null;
            txtTenKH.Text = null;
            txtDiaChi.Text = null;

            txtDienThoai.Enabled = false;
            txtTenKH.Enabled = false;
            txtDiaChi.Enabled = false;

            rdbNam.Enabled = false;
            rdbNu.Enabled = false;

            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
            btnLamMoi.Enabled = true;
            btnDanhSach.Enabled = true;
            btnSearch.Enabled = false;
            btnThoat.Enabled = true;
        }

        private void LoadGridView_KhachHang()
        {
            dgvKhachHang.DataSource = busKH.getKhachHang();
            dgvKhachHang.Columns[0].HeaderText = "Điện thoại";
            dgvKhachHang.Columns[1].HeaderText = "Họ tên";
            dgvKhachHang.Columns[2].HeaderText = "Địa chỉ";
            dgvKhachHang.Columns[3].HeaderText = "Phái";
        }

        private void QLBH_ThongTinKhachHang_Load(object sender, EventArgs e)
        {
            ResetValues();
            LoadGridView_KhachHang();
        }

        //Load datas to controls
        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvKhachHang.Rows.Count > 1)
            {
                btnLuu.Enabled = false;
                txtTenKH.Enabled = true;
                txtDiaChi.Enabled = true;
                rdbNam.Enabled = true;
                rdbNu.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                //Show data from selected row to controls
                txtDienThoai.Text = dgvKhachHang.CurrentRow.Cells["dienthoai"].Value.ToString();
                txtTenKH.Text = dgvKhachHang.CurrentRow.Cells["tenkhach"].Value.ToString();
                txtDiaChi.Text = dgvKhachHang.CurrentRow.Cells["DiaChi"].Value.ToString();
                if (dgvKhachHang.CurrentRow.Cells["phai"].Value.ToString() == rdbNam.Text)
                {
                    rdbNam.Checked = true;
                }else
                {
                    rdbNu.Checked = true;
                }
            }
            else
            {
                MessageBox.Show("Bảng ko tồn tại dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtDienThoai.Text = null;
            txtTenKH.Text = null;
            txtDiaChi.Text = null;

            txtDienThoai.Enabled = true;
            txtTenKH.Enabled = true;
            txtDiaChi.Enabled = true;

            rdbNam.Enabled = true;
            rdbNu.Enabled = true;

            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnLamMoi.Enabled = false;
            btnDanhSach.Enabled = false;
            btnSearch.Enabled = false;
            btnThoat.Enabled = false;
            txtDienThoai.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            float intDienThoai;
            bool isInt = float.TryParse(txtDienThoai.Text.Trim().ToString(), out intDienThoai);
            string phai = "Nam";
            if(rdbNu.Checked == true)
            {
                phai = "Nữ";
            }

            if(!isInt || float.Parse(txtDienThoai.Text) < 0) //kiem tra so dien thoai
            {
                MessageBox.Show("Vui lòng nhập đúng đinh dạng sđt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDienThoai.Clear();
                txtDienThoai.Focus();
                return;
            }
            else
            {
                DTO_KhachHang kh = new DTO_KhachHang(txtDienThoai.Text, txtTenKH.Text, txtDiaChi.Text, phai, stremail);
                if(busKH.InsertDataToKhachHang(kh))
                {
                    MessageBox.Show("Thêm thành công!");
                    ResetValues();
                    LoadGridView_KhachHang();
                } else
                {
                    MessageBox.Show("Thêm không thành công!");
                }    
            }
        }
    }
}
