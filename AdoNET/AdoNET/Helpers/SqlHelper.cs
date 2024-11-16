using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNET.Helpers
{
    static class SqlHelper
    {
        const string conStr = "Server=.\\SQLEXPRESS;Database=BP215;Trusted_Connection=True;TrustServerCertificate=True";
        public static bool Exec(string command)
        {
            int result = 0;
            using (SqlConnection conn = new(conStr))
            {
                using (SqlCommand cmd = new(command, conn))
                {
                    conn.Open();
                    result = cmd.ExecuteNonQuery();
                }
            }
            return result > 0;
        }
        public static DataTable Read(string query)
        {
            DataTable dt = new();
            using (SqlConnection conn = new(conStr))
            {
                using (SqlDataAdapter sda = new(query, conn))
                {
                    conn.Open();
                    sda.Fill(dt);
                }
            }
            return dt;
        }
    }
}
