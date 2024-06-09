using QLBH_DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_DAL
{
    public class DAL_KhachHang : DBConnect
    {
        //Danh sách khách hàng
        public DataTable getKhachHang()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DanhSachKhachHang";
                cmd.Connection = _conn;
                DataTable dtNV = new DataTable();
                dtNV.Load(cmd.ExecuteReader());
                return dtNV;
            }
            finally
            {
                _conn.Close();
            }
        }

        //Thêm khách hàng
        public bool InsertDataToKhachHang(DTO_KhachHang kh)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "InsertDataToKhachHang";
                cmd.Connection = _conn;
                cmd.Parameters.AddWithValue("dienthoai", kh.DienThoai);
                cmd.Parameters.AddWithValue("tenkhach", kh.TenKhach);
                cmd.Parameters.AddWithValue("diachi", kh.DiaChi);
                cmd.Parameters.AddWithValue("phai", kh.Phai);
                cmd.Parameters.AddWithValue("email", kh.EmailKhach);
                cmd.Parameters.AddWithValue("manv", kh.MaNV);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }catch (Exception ex)
            {
                throw ex;
            }finally { _conn.Close(); }
            return false;
        }

    }
}
