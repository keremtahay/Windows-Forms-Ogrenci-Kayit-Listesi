using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogrenci.CRUD
{
    public class Baglanti
    {
        public static SqlConnection GetConnection()
        {
            return new SqlConnection("Data Source=Victus-16;Initial Catalog=Ogrenci;Integrated Security=True");
        }
    }
}
