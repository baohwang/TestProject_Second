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
using QLBH_DTO;
using QLBH_BUS;

namespace QLBH_GUI
{
    public partial class QLBH_DangNhapFRM : Form
    {
        BUS_NhanVien busNV = new BUS_NhanVien();

        public QLBH_DangNhapFRM()
        {
            InitializeComponent();
        }

        //Tao chuoi ngau nhien
        public string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
            {
                return builder.ToString().ToLower();
            }

            return builder.ToString();
        }

        //Tao so ngau nhien
        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        //Gui mail
        public void SendMail(string email, string password)
        {
            try
            {
                MailMessage Msg = new MailMessage();
                Msg.Body = "Chào anh/ chị. Mật khẩu mới: " + password;
                Msg.To.Add(email);
                Msg.From = new MailAddress("bhgamer712@gmail.com");
                Msg.Subject = "Bạn đã sử dụng tính năng quên mật khẩu";

                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;

                client.Credentials = new NetworkCredential("bhgamer712@gmail.com", "crbu hrpq czvg flsm");
                client.Send(Msg);
                MessageBox.Show("Gửi mail thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DTO_NhanVien dtoNV = new DTO_NhanVien();
            dtoNV.Email = txtEmail.Text;
            dtoNV.MatKhau = busNV.encryption(txtPassword.Text);
            if(busNV.NhanVienDangNhap(dtoNV))
            {
                MessageBox.Show("Đăng nhập thành công");
                this.Close();
            } else
            {
                MessageBox.Show("Đăng nhập ko thành công!");
                txtEmail.Clear();
                txtPassword.Clear();
                txtEmail.Focus();
            }    
        }

        private void forgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(txtEmail.Text != "")
            {
                if (busNV.NhanVienQuenMK(txtEmail.Text))
                {
                    StringBuilder builder = new StringBuilder();
                    builder.Append(RandomString(4, true));
                    builder.Append(RandomNumber(1000, 9999));
                    builder.Append(RandomString(2, false));
                    MessageBox.Show(builder.ToString());    
                    string matkhaumoi = busNV.encryption(builder.ToString());
                    busNV.TaoMatKhauMoi(txtEmail.Text, matkhaumoi);
                    SendMail(txtEmail.Text, builder.ToString());
                } else
                {
                    MessageBox.Show("Email ko tồn tại!");
                }
            } else
            {
                MessageBox.Show("Vui lòng nhập email!");
                txtEmail.Focus();
            }    
        }
    }
}
