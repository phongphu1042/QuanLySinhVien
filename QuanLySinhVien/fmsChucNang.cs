using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLySinhVien.GUI;
using QuanLySinhVien.BUS;

namespace QuanLySinhVien
{
    public partial class fmsChucNang : Form
    {
        internal LopHocBUS lh = new LopHocBUS();
        //internal SinhVienBUS sv = new SinhVienBUS();
        public fmsChucNang()
        {
            InitializeComponent();
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thật sự muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                this.Close();
        }

        private void QLLopHocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LopHocGUI gui = new LopHocGUI();
            gui.Show();
        }

        private void quanLySinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SinhVienGUI gui = new SinhVienGUI();
            gui.Show();
        }

        private void fmsChucNang_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
        }

     
    }
}
