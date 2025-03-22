using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DoAnBlockChain
{
    internal class BlockChainLogger                         
    {

        private static string connectionString = @"Server=NGOVANDUNG\SQLEXPRESS;Database=QLSV;Integrated Security=True";
        public static string GenerateHash(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = sha256.ComputeHash(bytes);
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }

        public static void LogAction(string actionType, string maSV, string oldData, string newData)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Lấy Hash của Block trước đó
                string prevHash = "0";
                SqlCommand getPrevHash = new SqlCommand("SELECT TOP 1 DataHash FROM Blockchain ORDER BY BlockID DESC", conn);
                object result = getPrevHash.ExecuteScalar();
                if (result != null) prevHash = result.ToString();

                // Tạo Hash từ dữ liệu mới
                string dataHash = GenerateHash($"{actionType}-{maSV}-{oldData}-{newData}");

                // Lưu vào Blockchain
                string query = "INSERT INTO Blockchain (ActionType, MaSV, PreviousHash, DataHash, OldData, NewData, Timestamp) VALUES (@actionType, @maSV, @prevHash, @dataHash, @oldData, @newData, @timestamp)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@actionType", actionType);
                    cmd.Parameters.AddWithValue("@maSV", maSV);
                    cmd.Parameters.AddWithValue("@prevHash", prevHash);
                    cmd.Parameters.AddWithValue("@dataHash", dataHash);
                    cmd.Parameters.AddWithValue("@oldData", oldData ?? "N/A");
                    cmd.Parameters.AddWithValue("@newData", newData ?? "N/A");
                    cmd.Parameters.AddWithValue("@timestamp", DateTime.Now);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
