using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLySinhVien.DTO;
using System.Data;
using System.Data.SqlClient;
using QuanLySinhVien.DAO ;

namespace QuanLySinhVien.BUS
{
    public class SinhVienBUS
    {
        public static List<SinhVienDTO> dsSinhvien = getSinhVien();
        static public List<SinhVienDTO> getSinhVien()
        {
            List<SinhVienDTO> dstam = new List<SinhVienDTO>();
            string query = "select * from SINHVIEN";
            DataTable data = SQLConnection.Instance.Query(query);
            foreach (DataRow dr in data.Rows)
            {
                SinhVienDTO sinhVien = new SinhVienDTO(dr);
                dstam.Add(sinhVien);
            }
            return dstam;
        }
        public static List<SinhVienDTO> returnListSV()
        {
            return dsSinhvien;
        }
        private List<SinhVienDTO> dsSinhVien;

        public SinhVienBUS()
        {
            dsSinhVien = new List<SinhVienDTO>();
        }
        public List<SinhVienDTO> dsSV()
        {
            return dsSinhVien;
        }
        public void themSinhVien(ref List<SinhVienDTO> dsSinhvien, string tensv, string masv, DateTime ngaysinh, string gioitinh, string diachi, string email)
        {
            SinhVienDTO sinhVien = new SinhVienDTO(tensv, masv, ngaysinh, gioitinh, diachi, email);
            dsSinhvien.Add(sinhVien);
        }
        public void suaSinhVien(ref List<SinhVienDTO> dsSinhvien, string masv, string tensv, DateTime ngaysinh, string gioitinh, string diachi, string email, int vitri)
        {
            dsSinhvien[vitri].MaSinhVien = masv;
            dsSinhvien[vitri].HoTenSV = tensv;
            dsSinhvien[vitri].NgaySinh = ngaysinh;
            dsSinhvien[vitri].GioiTinh = gioitinh;
            dsSinhvien[vitri].DiaChi = diachi;
            dsSinhvien[vitri].Email = email;
        }
        public void xoaSinhVien(ref List<SinhVienDTO> dsSinhvien, int vitri)
        {
            dsSinhVien.Remove(dsSinhvien[vitri]);
        }

        public List<SinhVienDTO> timSinhVienTheoMa(string maSinhVien)
        {
            List<SinhVienDTO> kq = new List<SinhVienDTO>();
            for (int i = 0; i < dsSV().Count; i++)
            {
                if (dsSV()[i].MaSinhVien.Equals(maSinhVien))
                {
                    kq.Add(dsSV()[i]);
                }
            }
            return kq;
        }
        public List<SinhVienDTO> timSinhVienTheoTen(string tenSinhVien)
        {
            List<SinhVienDTO> dsSV = new List<SinhVienDTO>();
            for (int i = 0; i < dsSinhVien.Count; i++)
            { 
                if (dsSinhVien[i].HoTenSV.Equals(tenSinhVien))
                {
                    dsSV.Add(dsSinhVien[i]);
                }
            }
            return dsSV;
        }
            

    }
}