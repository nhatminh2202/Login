using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp
{
    internal class Modify
    {
        public Modify()
        {
        }

        public List<Account> Accounts(string query)
        {

            List<Account> accounts = new List<Account>();

            /* Thành phần máy ảo .NET (CLR) không giải phóng tài nguyên dc file - stream, CSDL
            cho nên phải sử dụng using */

            using (SqlConnection connection = Connection.getConnect())
            {
                // Khởi tạo đối tượng SqlCommand để kết nối CSDL và truy vấn dữ liệu
                SqlCommand cmd = new SqlCommand(query, connection);

                connection.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        accounts.Add(new Account(reader.GetString(0), reader.GetString(1)));
                    }
                }
                connection.Close();
            }
            return accounts;
        }

        public void Command(string query)
        {
            using (SqlConnection connection = Connection.getConnect())
            {
                connection.Open();
                // Thực hiện truy vấn
                var cmd = new SqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
