using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLBH_DTO;

namespace QLBH_DAL
{
    public class DAL_NhanVien : DBConnect
    {
        public bool NhanVienDangNhap(DTO_NhanVien nhanVien)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DangNhap";
                cmd.Parameters.AddWithValue("Email", nhanVien.Email);
                cmd.Parameters.AddWithValue("MatKhau", nhanVien.MatKhau);

                if (Convert.ToInt16(cmd.ExecuteScalar()) > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { _conn.Close(); }
            return false;
        }

        public bool NhanVienQuenMK(string email)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "QuenMatKhau";
                cmd.Parameters.AddWithValue("email", email);

                if (Convert.ToInt16(cmd.ExecuteScalar()) > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { _conn.Close(); }
            return false;
        }

        public bool TaoMatKhauMoi(string email, string password)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "TaoMatKhauMoi";
                cmd.Parameters.AddWithValue("email", email);
                cmd.Parameters.AddWithValue("matkhau", password);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { _conn.Close(); }
            return false;
        }

        public DataTable VaiTroNhanVien(string email)
        {
            try
            {
                //Kết nối 
                _conn.Open();

                SqlCommand cmd = new SqlCommand();

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[LayVaiTroNV]";
                cmd.Parameters.AddWithValue("Email", email);
                cmd.Connection = _conn;

                DataTable dtNhanVien = new DataTable();
                dtNhanVien.Load(cmd.ExecuteReader());
                return dtNhanVien;

            }

            finally
            {
                _conn.Close();
            }

        }

        public bool UpdateMatKhau(string email, string oldPass, string newPass)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ChangePass";
                cmd.Parameters.AddWithValue("email", email);
                cmd.Parameters.AddWithValue("opwd", oldPass);
                cmd.Parameters.AddWithValue("npwd", newPass);

                if(cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }

        //Xử lí nhân viên

        //Lấy danh sách nhân viên
        public DataTable getNhanVien()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DanhSachNV";
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

        //Thêm nhân viên
        public bool InsertNhanVien(DTO_NhanVien nv)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "InsertDataIntoNhanVien";
                cmd.Parameters.AddWithValue("email", nv.Email);
                cmd.Parameters.AddWithValue("tennv", nv.TenNV);
                cmd.Parameters.AddWithValue("diachi", nv.DiaChi);
                cmd.Parameters.AddWithValue("vaitro", nv.VaiTro);
                cmd.Parameters.AddWithValue("tinhtrang", nv.TinhTrang);
                if(cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            } catch (Exception ex)
            {
                throw ex;
            }
            finally { _conn.Close(); }
            return false;
        }

        //Sửa nhân viên
        public bool UpdateNhanViend (DTO_NhanVien nv) 
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();  
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UpdateDataIntoNhanVien";
                cmd.Parameters.AddWithValue("email", nv.Email);
                cmd.Parameters.AddWithValue("tennv", nv.TenNV);
                cmd.Parameters.AddWithValue("diachi", nv.DiaChi);
                cmd.Parameters.AddWithValue("vaitro", nv.VaiTro);
                cmd.Parameters.AddWithValue("tinhtrang", nv.TinhTrang);
                if(cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }catch (Exception ex)
            {
                throw ex;
            }
            finally { _conn.Close(); }
            return false;
        }

        //Xóa nhân viên
        public bool DeleteNhanVien(string email)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DeleteDataFromNhanVien";
                cmd.Parameters.AddWithValue("email", email);
                if( cmd.ExecuteNonQuery() > 0 )
                {
                    return true;
                }
            }catch(Exception ex) { throw ex; }
            finally { _conn.Close(); }
            return false;
        }

        //Tìm kiếm nhân viên

        public DataTable SearcNhanVien(string name)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SearchNhanVien";
                cmd.Parameters.AddWithValue("tennv", name);
                cmd.Connection = _conn;
                DataTable dtNV = new DataTable();
                dtNV.Load(cmd.ExecuteReader());
                return dtNV;
            }
            catch (Exception ex) { throw ex; }
            finally { _conn.Close(); }
        }
    }
}
