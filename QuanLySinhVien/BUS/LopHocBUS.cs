using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;
using QuanLySinhVien.DTO;
using QuanLySinhVien.GUI;

namespace QuanLySinhVien.BUS
{
    public class LopHocBUS
    {
        private Hashtable lophoc;
        public LopHocBUS()
        {
            this.lophoc = new Hashtable();
        }
        public Hashtable dslophoc
        {
            get { return lophoc; }
        }
        public LopHocDTO[] arrayLopHoc
        {
            get
            {
                LopHocDTO[] a = new LopHocDTO[lophoc.Count];
                lophoc.Values.CopyTo(a, 0);
                return a;

            }
        }
        public LopHocDTO tim(string key)
        {
            return (LopHocDTO)dslophoc[key];
        }
        public bool them(LopHocDTO lopdto)
        {
            try
            {
                lophoc.Add(lopdto.MaLop, lopdto);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public void hienthi(ListView lvw)
        {
            lvw.Items.Clear();
            foreach (LopHocDTO lh in lophoc.Values)
            {
                ListViewItem lvi = lvw.Items.Add(lh.MaLop);
                lvi.SubItems.Add(lh.Khoa);
                lvi.SubItems.Add(lh.HeDaoTao);
            }
        }
        public bool sua(LopHocDTO lh)
        {
            try
            {
                LopHocDTO a = (LopHocDTO)dslophoc[lh.MaLop];
                if (a == null) return false;
                a.Khoa = lh.Khoa;
                a.HeDaoTao = lh.HeDaoTao;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool xoa(string key)
        {
            try
            {
                dslophoc.Remove(key);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
