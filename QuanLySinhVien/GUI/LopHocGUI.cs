using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLySinhVien.DTO;
using QuanLySinhVien.BUS;

namespace QuanLySinhVien.GUI
{
    public partial class LopHocGUI : Form
    {
        public LopHocBUS lophoc;
        public SinhVienGUI sinhvien;
        public LopHocGUI()
        {
            InitializeComponent();
        }
        //Hàm có nhiệm vụ lấy tham số truyền vào
        private void GetMessage(ListView lv)
        {
            lstLop = lv;
        }
        private void LopHocGUI_Load(object sender, EventArgs e)
        {
            lophoc = new LopHocBUS();
            lophoc.hienthi(lstLop);

        }
        private void lstLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in lstLop.SelectedItems)
            {
                txtMaLop.Text = lvi.SubItems[0].Text;
                cbxKhoa.Text = lvi.SubItems[1].Text;
                cbxHeDaoTao.Text = lvi.SubItems[2].Text;

                break;
            }
        }
        private void lvSinhVienLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in lstLop.SelectedItems)
            { 
                txtMaLop.Text = lvi.SubItems[0].Text;
                cbxKhoa.Text = lvi.SubItems[1].Text;
                cbxHeDaoTao.Text = lvi.SubItems[2].Text;
                break;
            }
        }
        private void ptbAdd_Click(object sender, EventArgs e)
        {
            LopHocDTO lh = new LopHocDTO();
            lh.MaLop = txtMaLop.Text;
            lh.Khoa = cbxKhoa.Text;
            lh.HeDaoTao = cbxHeDaoTao.Text;
            if (lophoc.them(lh) == true)
            {
                lophoc.hienthi(lstLop);
            }
            else
                MessageBox.Show("Mã lớp đã tồn tại!");
        }

        private void ptbSua_Click(object sender, EventArgs e)
        {
            LopHocDTO lh = new LopHocDTO();
            lh.MaLop = txtMaLop.Text;
            lh.Khoa = cbxKhoa.Text;
            lh.HeDaoTao = cbxHeDaoTao.Text;
            if (!lophoc.sua(lh))
            {
                MessageBox.Show("Không sửa dữ liệu được!");
            }
            else
            {
                lophoc.hienthi(lstLop);
            }
        }

        private void ptbDelete_Click(object sender, EventArgs e)
        {
            bool ok = false;
            foreach (ListViewItem lvi in lstLop.SelectedItems)
            {
                ok = true;
                lophoc.xoa(lvi.SubItems[0].Text);
            }
            if (ok)
            {
                lophoc.hienthi(lstLop);
            }
        }

        private void ptbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in lstLop.SelectedItems)
            {
                DSsinhvienlop dssv = new DSsinhvienlop(lvi.SubItems[0].Text, lvi.SubItems[1].Text, lvi.SubItems[2].Text);
                dssv.Show();
                break;
            }
        }
    }
}
