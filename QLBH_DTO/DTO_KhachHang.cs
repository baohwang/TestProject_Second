using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_DAL
{
    public class DTO_KhachHang
    {
        private string tenkhach;
        private string dienthoai;
        private string diachi;
        private string phai;
        private string emailKhach;
        private string maNV;

        public string TenKhach
        {
            get { return tenkhach; }
            set { tenkhach = value; }
        }

        public string DienThoai
        {
            get { return dienthoai; }
            set { dienthoai = value; }
        }

        public string DiaChi
        {
            get { return diachi; }
            set { diachi = value; }
        }

        public string Phai
        {
            get { return phai; }
            set { phai = value; }
        }

        public string EmailKhach
        {
            get { return emailKhach; }
            set { emailKhach = value; }
        }

        public string MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }

        public DTO_KhachHang(string tenkhach, string dienthoai, string diachi, string phai, string emailKhach)
        {
            this.tenkhach = tenkhach;
            this.dienthoai = dienthoai;
            this.diachi = diachi;
            this.phai = phai;   
            this.emailKhach = emailKhach;
        }
    }
}
