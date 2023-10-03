using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace WinFormsApp
{
    internal class Connection
    {
        private static string source = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\This PC\Desktop\WinFormsApp\WinFormsApp\Database1.mdf"";Integrated Security=True";

        public static SqlConnection getConnect()
        {
            return new SqlConnection(source);
        }
    }
}
