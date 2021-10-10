using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.DTO
{
    public class LopHocDTO
    {
        private string maLop;
        private string khoa;
        private string heDaoTao;
        public LopHocDTO()
        {
            this.MaLop = null;
            this.Khoa = null;
            this.HeDaoTao = null;

        }
        public LopHocDTO(string maLop, string khoa, string heDaoTao)
        {
            this.MaLop = maLop;
            this.HeDaoTao = heDaoTao;
            this.Khoa = khoa;
        }

        public string MaLop { get => maLop; set => maLop = value; }
        public string Khoa { get => khoa; set => khoa = value; }
        public string HeDaoTao { get => heDaoTao; set => heDaoTao = value; }
        //public LopHocDTO(LopHocDTO dto)
        //{
        //    this.maLop = dto.maLop;
        //    this.heDaoTao = dto.heDaoTao;
        //    this.khoa = dto.khoa;
        //}
    }
}
