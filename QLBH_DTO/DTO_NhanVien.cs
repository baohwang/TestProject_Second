using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_DTO
{
    public class DTO_NhanVien
    {
        private string email;
        private string matkhau;
        private string tennv;
        private string diachi;
        private string vaitro;
        private string tinhtrang;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string MatKhau
        {
            get { return matkhau; }
            set { matkhau = value; }
        }

        public string TenNV
        {
            get { return tennv; }
            set { tennv = value; }
        }

        public string DiaChi
        {
            get { return diachi; }
            set { diachi = value; }
        }
        public string VaiTro
        {
            get { return vaitro; }
            set { vaitro = value; }
        }

        public string TinhTrang
        {
            get { return tinhtrang; }
            set { tinhtrang = value; }
        }

        public DTO_NhanVien(string email, string matkhau, string tennv, string diachi, string vaitro, string tinhtrang)
        {
            this.email = email;
            this.matkhau = matkhau;
            this.tennv = tennv;
            this.diachi = diachi;
            this.vaitro = vaitro;
            this.tinhtrang = tinhtrang;
        }

        public DTO_NhanVien(string email, string tennv, string diachi, string vaitro, string tinhtrang)
        {
            this.email = email;
            this.tennv = tennv;
            this.diachi = diachi;
            this.vaitro = vaitro;
            this.tinhtrang = tinhtrang;
        }

        public DTO_NhanVien() { }
    }
}
