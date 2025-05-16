using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Microsoft.Data.SqlClient;

namespace DAL_QuanLy
{
    public class DBConnect
    {
        protected SqlConnection _conn = new SqlConnection("Data Source=localho;Initial Catalog=QUANLYDAILY;Integrated Security=True;TrustServerCertificate=True");
        public string connString = "Data Source=ADMIN-PC;Initial Catalog=QUANLYDAILY;Integrated Security=True;TrustServerCertificate=True;";
    }
}