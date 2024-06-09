using QLBH_BUS;
using QLBH_DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class QLBH_ThongTinNhanVien : Form
    {
        BUS_NhanVien busNV = new BUS_NhanVien();

        public QLBH_ThongTinNhanVien()
        {
            InitializeComponent();
        }

        private void LoadGridView_NhanVien()
        {
            dgvNhanVien.DataSource = busNV.getNhanVien();
            dgvNhanVien.Columns[0].HeaderText = "Email";
            dgvNhanVien.Columns[1].HeaderText = "Tên nhân viên";
            dgvNhanVien.Columns[2].HeaderText = "Địa chỉ";
            dgvNhanVien.Columns[3].HeaderText = "Vai trò";
            dgvNhanVien.Columns[4].HeaderText = "Tình trạng";
        }

        private void ResetValues()
        {
            txtSearch.Text = "Nhập vào tên nhân viên...";
            txtEmail.Text = null;
            txtTenNV.Text = null;
            txtDiaChi.Text = null;

            txtEmail.Enabled = false;
            txtTenNV.Enabled = false;
            txtDiaChi.Enabled = false;

            ckbNhanVien.Enabled = false;
            ckbQuanLi.Enabled = false;
            rdbHoatDong.Enabled = false;
            rdbNgungHoatDong.Enabled=false;

            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
            btnLamMoi.Enabled = true;
            btnDanhSach.Enabled = true;
            btnSearch.Enabled = false; 
            btnThoat.Enabled = true;
        }

        private void LoadDataToControls()
        {
            if (dgvNhanVien.Rows.Count > 1)
            {
                btnLuu.Enabled = false;
                txtTenNV.Enabled = true;
                txtDiaChi.Enabled = true;
                ckbQuanLi.Enabled = true;
                ckbNhanVien.Enabled = true;
                rdbHoatDong.Enabled = true;
                rdbNgungHoatDong.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                //Show data from selected row to controls
                txtEmail.Text = dgvNhanVien.CurrentRow.Cells["email"].Value.ToString();
                txtTenNV.Text = dgvNhanVien.CurrentRow.Cells["TenNV"].Value.ToString();
                txtDiaChi.Text = dgvNhanVien.CurrentRow.Cells["DiaChi"].Value.ToString();
                if (int.Parse(dgvNhanVien.CurrentRow.Cells["VaiTro"].Value.ToString()) == 1)
                {
                    ckbQuanLi.Checked = true;
                    ckbNhanVien.Checked = false;
                }
                else
                {
                    ckbNhanVien.Checked = true;
                    ckbQuanLi.Checked = false;
                }

                if (int.Parse(dgvNhanVien.CurrentRow.Cells["tinhtrang"].Value.ToString()) == 1)
                {
                    rdbHoatDong.Checked = true;
                }
                else
                {
                    rdbNgungHoatDong.Checked = true;
                }
            }
            else
            {
                MessageBox.Show("Bảng ko tồn tại dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SendMail(string email)
        {
            try
            {
                MailMessage Msg = new MailMessage();
                Msg.Body = "Chào anh/ chị. : Mật khẩu truy cập phần mềm là abc123. Vui lòng nhập và thay đồi mật khẩu";
                Msg.To.Add(email);
                Msg.From = new MailAddress("bhgamer712@gmail.com");
                Msg.Subject = "Chúc mừng bạn đã được nhận vào làm";

                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;

                client.Credentials = new NetworkCredential("bhgamer712@gmail.com", "crbu hrpq czvg flsm");
                client.Send(Msg);
                MessageBox.Show("Mail đã được gửi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void QLBH_ThongTinNhanVien_Load(object sender, EventArgs e)
        {
            ResetValues();
            LoadGridView_NhanVien();
        }

        public bool IsValid(string emailaddress) // check rule email
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex);
                return false;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtEmail.Text = null;
            txtTenNV.Text = null;
            txtDiaChi.Text = null;

            txtEmail.Enabled = true;
            txtTenNV.Enabled = true;
            txtDiaChi.Enabled = true;

            ckbNhanVien.Enabled = true;
            ckbQuanLi.Enabled = true;
            rdbHoatDong.Enabled = true;
            rdbNgungHoatDong.Enabled = true;

            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnLamMoi.Enabled = false;
            btnDanhSach.Enabled = false;
            btnSearch.Enabled = false;
            btnThoat.Enabled = false;
            txtEmail.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int role = 0; //vai tro nhan vien
            if(ckbQuanLi.Checked )
            {
                role = 1;
            }

            int tinhtrang = 0; //ngung hoat dong
            if(rdbHoatDong.Checked)
            {
                tinhtrang = 1;
            }
            else if(!IsValid(txtEmail.Text.Trim()))
            {
                MessageBox.Show("Bạn phải nhập đúng định dạng email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.Focus();
                return;
            }
            else if (txtTenNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenNV.Focus();
                return;
            }

            else if (txtDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiaChi.Focus();
                return;
            }

            if (ckbQuanLi.Checked == false && ckbNhanVien.Checked == false)
            {
                MessageBox.Show("Bạn phải nhập vai trò", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenNV.Focus();
                return;
            }

            if (rdbHoatDong.Checked == false && rdbNgungHoatDong.Checked == false)
            {
                MessageBox.Show("Bạn phải nhập tình trạng ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenNV.Focus();
                return;
            }
            else
            {
                // Tạo 1 DTO
                DTO_NhanVien nv = new DTO_NhanVien(txtEmail.Text, txtTenNV.Text, txtDiaChi.Text, role, tinhtrang);
                if (busNV.InsertNhanVien(nv))
                {
                    MessageBox.Show("Thêm thành công");
                    ResetValues();
                    LoadGridView_NhanVien();
                    SendMail(nv.Email);
                }
                else
                {
                    MessageBox.Show("Thêm ko thành công");
                }
            }
        }
        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadDataToControls();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(txtTenNV.Text.Trim().Length == 0) 
            {
                MessageBox.Show("Bạn phải nhập tên nv", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenNV.Focus();
                return;
            }else if (txtDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ nv", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiaChi.Focus();
                return;
            }
            else
            {
                int role = 0;
                if(ckbQuanLi.Checked)
                {
                    role = 1;
                }
                int tinhtrang = 0;
                if(rdbHoatDong.Checked)
                {
                    tinhtrang = 1;
                }
                //Tạo DTO
                DTO_NhanVien nv = new DTO_NhanVien(txtEmail.Text, txtTenNV.Text, txtDiaChi.Text, role, tinhtrang);
                if(MessageBox.Show("Bạn có chắc muốn chỉnh sửa", "Confirm", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if(busNV.UpdateNhanVien(nv))
                    {
                        MessageBox.Show("Sửa thành công!");
                        ResetValues();
                        LoadGridView_NhanVien();
                    }else
                    {
                        MessageBox.Show("Sửa ko thành công!");
                    }
                }
                else
                {
                    ResetValues();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            if(MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Confirm!",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                if(busNV.DeleteNhanVien(email))
                {
                    MessageBox.Show("Xóa dữ liệu thành công");
                    ResetValues();
                    LoadGridView_NhanVien();
                } else
                {
                    MessageBox.Show("Xóa dữ liệu không thành công");
                }
            }else
            {
                ResetValues();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ResetValues();
            LoadGridView_NhanVien();
        }

        private void btnDanhSach_Click(object sender, EventArgs e)
        {
            ResetValues();
            LoadGridView_NhanVien();
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = null;
            btnSearch.Enabled = true;
            txtSearch.BackColor = Color.White;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = txtSearch.Text;
            DataTable ds = busNV.SearchNhanVien(name);
            if(ds.Rows.Count > 0) //founded
            {
                dgvNhanVien.DataSource = ds;
                dgvNhanVien.Columns[0].HeaderText = "Email";
                dgvNhanVien.Columns[1].HeaderText = "Tên nhân viên";
                dgvNhanVien.Columns[2].HeaderText = "Địa chỉ";
                dgvNhanVien.Columns[3].HeaderText = "Vai Trò";
                dgvNhanVien.Columns[4].HeaderText = "Tình trạng";
            } else
            {
                MessageBox.Show("Không tìm thấy nhân viên!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtSearch.Text = "Nhập vào tên nhân viên...";
            txtSearch.BackColor = Color.LightGray;
            ResetValues();
        }

        
    }
}
