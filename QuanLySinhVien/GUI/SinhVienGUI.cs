using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using QuanLySinhVien.DTO;
using QuanLySinhVien.BUS;

namespace QuanLySinhVien.GUI
{
    public partial class SinhVienGUI : Form
    {
        public SinhVienGUI sinhvien;
        SinhVienBUS XuLy = new SinhVienBUS();
        private int viTri = 0;
        public SinhVienGUI()
        {
            InitializeComponent();
        }
        private void btnThem_Click_1(object sender, EventArgs e)
        {
            string maSinhVien = txtMaSinhVien.Text;
            string hoTen = txtHoten.Text;
            DateTime ngaySinh = dtpNgaysinh.Value;
            string gioiTinh = null;
            if (radiobtnNam.Checked == true)
            {
                gioiTinh = "Nam";
            }
            else if (radiobtnNu.Checked == true)
            {
                gioiTinh = "Nữ";
            }
            string diaChi = txtDChi.Text;
            string email = txtEmail.Text;
            SinhVienDTO sinhVien = new SinhVienDTO(maSinhVien, hoTen, ngaySinh, gioiTinh, diaChi, email);
            XuLy.dsSV().Add(sinhVien);
            hienThiDanhSachSinhVien(XuLy.dsSV(), lvSinhVien);

        }
        public void hienThiDanhSachSinhVien(List<SinhVienDTO> danhsach, ListView lv)
        {
            lv.Items.Clear();
            for (int i = 0; i < danhsach.Count; i++)
            {
                SinhVienDTO sinhVien = new SinhVienDTO();
                sinhVien = danhsach[i];
                ListViewItem lvi = new ListViewItem(sinhVien.MaSinhVien);
                lvi.SubItems.Add(sinhVien.HoTenSV);
                lvi.SubItems.Add(sinhVien.NgaySinh.ToString());
                lvi.SubItems.Add(sinhVien.GioiTinh);
                lvi.SubItems.Add(sinhVien.DiaChi.ToString());
                lvi.SubItems.Add(sinhVien.Email.ToString());
                lv.Items.Add(lvi);
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            string maSinhVien = txtMaSinhVien.Text;
            string hoTen = txtHoten.Text;
            DateTime ngaySinh = dtpNgaysinh.Value;
            string gioiTinh = null;
            if (radiobtnNam.Checked == true)
            {
                gioiTinh = "Nam";
            }
            else if (radiobtnNu.Checked == true)
            {
                gioiTinh = "Nữ";
            }
            string diaChi = txtDChi.Text;
            string email = txtEmail.Text;
            SinhVienDTO sinhVien = new SinhVienDTO(maSinhVien, hoTen, ngaySinh, gioiTinh, diaChi, email);
            XuLy.dsSV()[viTri] = sinhVien;
            hienThiDanhSachSinhVien(XuLy.dsSV(), lvSinhVien);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn thật sự muốn xóa thông tin sinh viên này!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                XuLy.dsSV().RemoveAt(viTri);
                hienThiDanhSachSinhVien(XuLy.dsSV(), lvSinhVien);
            }
        }

        public void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(int i in lvSinhVien.SelectedIndices)
            {
                viTri = i;
            }
            hienThi1HocVien(this.XuLy.dsSV()[viTri]);
        }
        private void hienThi1HocVien(SinhVienDTO sinhVien)
        {
            txtMaSinhVien.Text = sinhVien.MaSinhVien;
            txtHoten.Text = sinhVien.HoTenSV;
            dtpNgaysinh.Value = sinhVien.NgaySinh;
            string gioiTinh = sinhVien.GioiTinh;
            if (gioiTinh.Equals("Nam"))
                radiobtnNam.Checked = true;
            else if (gioiTinh.Equals("Nữ"))
                radiobtnNu.Checked = true;
            txtDChi.Text = sinhVien.DiaChi;
            txtEmail.Text = sinhVien.Email;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            //FileStream fs = new FileStream("sinhvien.out", FileMode.Create);
            //BinaryFormatter bf = new BinaryFormatter();
            //bf.Serialize(fs, this.dsSinhVien);
            //fs.Close();
            DialogResult result = MessageBox.Show("Bạn có thật sự muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
       
        private void btnTim_Click(object sender, EventArgs e)
        {          
            if (radTimTheoMa.Checked == true)
            {       
                if (XuLy.timSinhVienTheoMa(txtTimTheoMa.Text).Count == 0)
                    MessageBox.Show("không tìm thấy", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    hienThiDanhSachSinhVien(XuLy.timSinhVienTheoMa(txtTimTheoMa.Text), lvSinhVien);
                }
            }
            else if (radTimTheoTen.Checked == true)
            {              
                if (XuLy.timSinhVienTheoTen(txtTimTheoTen.Text).Count==0)
                    MessageBox.Show("không tìm thấy", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    hienThiDanhSachSinhVien(XuLy.timSinhVienTheoTen(txtTimTheoTen.Text), lvSinhVien);
            }
        }

      
    }
}
