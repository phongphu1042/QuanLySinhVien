using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.DTO
{
    public class SinhVienDTO
    {
        private string maSinhVien;
        private string hoTenSV;
        private DateTime ngaySinh;
        private string gioiTinh;
        private string diaChi;
        private string email;
        public SinhVienDTO()
        {
            this.maSinhVien = null;
            this.hoTenSV = null;
            this.ngaySinh = DateTime.Today;
            this.gioiTinh = null;
            this.diaChi = null;
            this.email = null;
        }

        public SinhVienDTO(DataRow dr)
        {
            Dr = dr;
        }

        public SinhVienDTO(string maSinhVien, string hoTenSV, DateTime ngaySinh, string gioiTinh, string diaChi, string email)
        {
            this.maSinhVien = maSinhVien;
            this.hoTenSV = hoTenSV;
            this.ngaySinh = ngaySinh;
            this.gioiTinh = gioiTinh;
            this.diaChi = diaChi;
            this.email = email;
        }
        public string MaSinhVien
        {
            get { return this.maSinhVien; }
            set { this.maSinhVien = value; }
        }
        public string HoTenSV
        {
            get { return this.hoTenSV; }
            set { this.hoTenSV = value; }
        }
        public DateTime NgaySinh
        {
            get { return this.ngaySinh; }
            set { this.ngaySinh = value; }
        }
        public string GioiTinh
        {
            get { return this.gioiTinh; }
            set { this.gioiTinh = value; }
        }
        public string DiaChi
        {
            get { return this.diaChi; }
            set { this.diaChi = value; }
        }
        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public DataRow Dr { get; }
    }
}
