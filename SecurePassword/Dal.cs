using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SecurePassword
{
    internal class Dal
    {
        public string GetConnectionString()
        {
            string con = "Server=localhost;Database=SecurePassword;Trusted_Connection=True";
            return con;
        }

        public void FindUser()
        {
            string sqlString = "";
        }
    }
}
