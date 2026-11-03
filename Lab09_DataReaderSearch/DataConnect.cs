using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Lab09_DataReaderSearch
{
    public static class DataConnect
    {
        private const string ConnectionString =
@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLSinhVien;Integrated Security=True";

        public static SqlConnection Create()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}
