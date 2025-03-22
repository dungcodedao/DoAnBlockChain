using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnBlockChain
{
    public partial class Form1 : Form
    {
        private readonly string connection = @"Server=NGOVANDUNG\SQLEXPRESS;Database=QLSV;Integrated Security=True";        

        public Form1()
        {
            InitializeComponent();
            string hashValue = BlockchainHelper.GenerateHash("Dữ liệu cần mã hóa");
            MessageBox.Show(hashValue);
        }

        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                string query = "SELECT * FROM SinhVien";
                using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
         }

        private void ThemSinhVien()
        {
            if (!DateTime.TryParse(txtNgaySinh.Text, out DateTime ngaySinh))
            {
                MessageBox.Show("Ngày sinh không hợp lệ! Định dạng hợp lệ: yyyy-MM-dd hoặc dd/MM/yyyy.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();

                string query = "INSERT INTO SinhVien (MaSV, HoDem, Ten, NS, GioiTinh, Lop, MaKhoa) VALUES (@MaSV, @HoDem, @Ten, @NS, @GioiTinh, @Lop, @MaKhoa)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaSV", txtMaSV.Text);
                    cmd.Parameters.AddWithValue("@HoDem", txtHoDem.Text);
                    cmd.Parameters.AddWithValue("@Ten", txtTen.Text);
                    cmd.Parameters.AddWithValue("@NS", ngaySinh);
                    cmd.Parameters.AddWithValue("@GioiTinh", txtGioiTinh.Text);
                    cmd.Parameters.AddWithValue("@Lop", txtLop.Text);
                    cmd.Parameters.AddWithValue("@MaKhoa", txtMaKhoa.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công!");
                    LoadData();

                    // Ghi vào Blockchain
                    string newData = $"{txtHoDem.Text}-{txtTen.Text}-{ngaySinh}-{txtGioiTinh.Text}-{txtLop.Text}-{txtMaKhoa.Text}";
                    BlockChainLogger.LogAction("Thêm", txtMaSV.Text, "N/A", newData);
                }
            }
        }

        private void SuaSinhVien()
        {
            if (!DateTime.TryParse(txtNgaySinh.Text, out DateTime ngaySinh))
            {
                MessageBox.Show("Ngày sinh không hợp lệ! Vui lòng nhập đúng định dạng.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();

                // Lấy dữ liệu cũ
                string oldDataQuery = "SELECT * FROM SinhVien WHERE MaSV=@MaSV";
                SqlCommand oldCmd = new SqlCommand(oldDataQuery, conn);
                oldCmd.Parameters.AddWithValue("@MaSV", txtMaSV.Text);
                SqlDataReader reader = oldCmd.ExecuteReader();

                string oldData = "";
                if (reader.Read())
                {
                    oldData = $"{reader["HoDem"]}-{reader["Ten"]}-{reader["NS"]}-{reader["GioiTinh"]}-{reader["Lop"]}-{reader["MaKhoa"]}";
                }
                reader.Close();

                string query = "UPDATE SinhVien SET HoDem=@HoDem, Ten=@Ten, NS=@NS, GioiTinh=@GioiTinh, Lop=@Lop, MaKhoa=@MaKhoa WHERE MaSV=@MaSV";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaSV", txtMaSV.Text);
                    cmd.Parameters.AddWithValue("@HoDem", txtHoDem.Text);
                    cmd.Parameters.AddWithValue("@Ten", txtTen.Text);
                    cmd.Parameters.AddWithValue("@NS", ngaySinh);
                    cmd.Parameters.AddWithValue("@GioiTinh", txtGioiTinh.Text);
                    cmd.Parameters.AddWithValue("@Lop", txtLop.Text);
                    cmd.Parameters.AddWithValue("@MaKhoa", txtMaKhoa.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sửa thành công!");
                    LoadData();

                    // Ghi vào Blockchain
                    string newData = $"{txtHoDem.Text}-{txtTen.Text}-{ngaySinh}-{txtGioiTinh.Text}-{txtLop.Text}-{txtMaKhoa.Text}";
                    BlockChainLogger.LogAction("Sửa", txtMaSV.Text, oldData, newData);
                }
            }
        }

        private void XoaSinhVien()
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();

                // Lấy dữ liệu cũ
                string oldDataQuery = "SELECT * FROM SinhVien WHERE MaSV=@MaSV";
                SqlCommand oldCmd = new SqlCommand(oldDataQuery, conn);
                oldCmd.Parameters.AddWithValue("@MaSV", txtMaSV.Text);
                SqlDataReader reader = oldCmd.ExecuteReader();

                string oldData = "";
                if (reader.Read())
                {
                    oldData = $"{reader["HoDem"]}-{reader["Ten"]}-{reader["NS"]}-{reader["GioiTinh"]}-{reader["Lop"]}-{reader["MaKhoa"]}";
                }
                reader.Close();

                string query = "DELETE FROM SinhVien WHERE MaSV=@MaSV";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaSV", txtMaSV.Text);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Xóa thành công!");
                        BlockChainLogger.LogAction("Xóa", txtMaSV.Text, oldData, "N/A");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sinh viên để xóa!");
                    }

                    LoadData();
                }
            }
        }

        private void TimKiemSinhVien()
        {
            string maSV = txtTimSV.Text.Trim(); // Kiểm tra đúng ô nhập
            MessageBox.Show("Tìm kiếm sinh viên có MaSV = " + maSV); // Debug

            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                string query = "SELECT * FROM SinhVien WHERE MaSV = @MaSV";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaSV", maSV);

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;

                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("Không tìm thấy sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            BlockChainLogger.LogAction("Tìm kiếm", maSV, "Không tìm thấy", "N/A");
                        }
                        else
                        {
                            // Lấy dữ liệu sinh viên tìm thấy để lưu log
                            DataRow row = dt.Rows[0];
                            string foundData = $"{row["HoDem"]}-{row["Ten"]}-{row["NS"]}-{row["GioiTinh"]}-{row["Lop"]}-{row["MaKhoa"]}";

                            BlockChainLogger.LogAction("Tìm kiếm", maSV, "N/A", foundData);
                        }
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLSVDataSet1.BlockChain' table. You can move, or remove it, as needed.
            this.blockChainTableAdapter.Fill(this.qLSVDataSet1.BlockChain);
            // TODO: This line of code loads data into the 'qLSVDataSet.SinhVien' table. You can move, or remove it, as needed.
            this.sinhVienTableAdapter.Fill(this.qLSVDataSet.SinhVien);
            LoadBlockchainData();

        }

        private void LoadBlockchainData()
        {
            string query = "SELECT BlockID, ActionType, MaSV, PreviousHash, DataHash, OldData, NewData, Timestamp FROM Blockchain";


            using (SqlConnection conn = new SqlConnection(connection))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView2.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải dữ liệu Blockchain: " + ex.Message);
                }
            }
        }

        private void bttThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bttThem_Click(object sender, EventArgs e)
        {
            ThemSinhVien();
        }

        private void bttSua_Click(object sender, EventArgs e)
        {
            SuaSinhVien();
        }

        private void bttXoa_Click(object sender, EventArgs e)
        {
            XoaSinhVien();
        }

        private void bttReLoad_Click(object sender, EventArgs e)
        {
            
            LoadData();
            LoadBlockchainData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TimKiemSinhVien();
        }
    }
}
