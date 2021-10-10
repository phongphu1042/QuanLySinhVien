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
    public partial class DSsinhvienlop : Form
    {
        internal LopHocBUS lh = new LopHocBUS();
        internal SinhVienBUS sv = new SinhVienBUS();
        private SinhVienGUI svgui = new SinhVienGUI();
        public DSsinhvienlop()
        {
            InitializeComponent();
        }

        public DSsinhvienlop(string lop,string khoa,string hedt) :this() //hiển thị lớp đã được chọn
        {
            lblLop.Text = lop;
            lblKhoa.Text = khoa;
            lblBac.Text = hedt;
        }
        private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void lstDS_SV_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void DSsinhvienlop_Load(object sender, EventArgs e)
        {
            //List<SinhVienDTO> ds = new List<SinhVienDTO>();
            //FileStream fs = new FileStream("sinhvien.out", FileMode.Open);
            //BinaryFormatter bf = new BinaryFormatter();
            //ds = (List<SinhVienDTO>)bf.Deserialize(fs);
            //fs.Close();
            //svgui.hienThiDanhSachSinhVien(ds, lvSinhVien);
        }
    }
}
