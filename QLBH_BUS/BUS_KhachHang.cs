using QLBH_DAL;
using QLBH_DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_BUS
{
    public class BUS_KhachHang
    {
        DAL_KhachHang dalKH = new DAL_KhachHang();

        //Danh sách khách hàng
        public DataTable getKhachHang()
        {
            return dalKH.getKhachHang();
        }

        //Thêm khách hàng
        public bool InsertDataToKhachHang(DTO_KhachHang kh)
        {
            return dalKH.InsertDataToKhachHang(kh);
        }
    }
}
