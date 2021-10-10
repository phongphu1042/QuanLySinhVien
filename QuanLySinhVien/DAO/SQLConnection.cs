using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLySinhVien.DAO
{
    class SQLConnection
    {
        private static SQLConnection instance;
        private string conSTr = "Data Source=DESKTOP-0QT1GB7;Initial Catalog=QuanLySinhVien;Integrated Security=True";

        public static SQLConnection Instance
        {
            get
            {
                if (instance == null) instance = new SQLConnection();
                return SQLConnection.instance;
            }
            private set { SQLConnection.instance = value; }
        }
        public DataTable Query(string qr)
        {
            DataTable dc = new DataTable();
            using (SqlConnection conn = new SqlConnection(conSTr))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(qr, conn);
                SqlDataAdapter dt = new SqlDataAdapter(command);
                dt.Fill(dc);
                conn.Close();
            }
            return dc;
        }

        public SqlConnection setKhoa()
        {
            return new SqlConnection(conSTr);
        }
        public SqlConnection setSV()
        {
            return new SqlConnection(conSTr);
        }
    }
}
