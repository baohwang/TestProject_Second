using QLBH_DAL;
using QLBH_DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_BUS
{
    public class BUS_NhanVien
    {
        DAL_NhanVien dalNV = new DAL_NhanVien();

        public bool NhanVienDangNhap(DTO_NhanVien nhanVien)
        {
            return dalNV.NhanVienDangNhap(nhanVien);
        }

        //xử lí md5
        public string encryption(string password)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] encrypt;
            UTF8Encoding encoding = new UTF8Encoding();
            //encrypt the given password string into Encrypted Data
            encrypt = md5.ComputeHash(encoding.GetBytes(password));
            StringBuilder encryptdata = new StringBuilder();
            //Create new string by using encryted data
            for (int i = 0; i < encrypt.Length; i++)
            {
                encryptdata.Append(encrypt[i].ToString());
            }
            return encryptdata.ToString();
        }

        public bool NhanVienQuenMK(string email)
        {
            return dalNV.NhanVienQuenMK(email);
        }

        public bool TaoMatKhauMoi(string email, string password)
        {
            return dalNV.TaoMatKhauMoi(email, password);
        }
        public DataTable VaiTroNhanVien(string email)
        {
            return dalNV.VaiTroNhanVien(email);
        }

        public bool UpdateMatKhau(string email, string oldPass, string newPass)
        {
            return dalNV.UpdateMatKhau(email, oldPass, newPass);
        }

        //Xử lí nhân viên

        //Lấy danh sách nhân viên
        public DataTable getNhanVien()
        {
            return dalNV.getNhanVien();
        }

        //Thêm nhân viên
        public bool InsertNhanVien(DTO_NhanVien nv)
        {
            return dalNV.InsertNhanVien(nv);
        }

        //Cập nhật nhân viên
        public bool UpdateNhanVien(DTO_NhanVien nv)
        {
            return dalNV.UpdateNhanViend(nv);
        }

        //Xóa nhân viên
        public bool DeleteNhanVien(string email)
        {
            return dalNV.DeleteNhanVien(email);
        }

        //Tìm kiếm nhân viên
        public DataTable SearchNhanVien(string name)
        {
            return dalNV.SearcNhanVien(name);
        }
    }
}
