using System.Data.SqlClient;

namespace shtuki_tuki.domain.DbProvider
{
    public class DatabaseProvider
    {
        //Local
        private readonly string Connection = @"Data Source=.\sqlexpress;Initial Catalog=ShtukiTuki;Integrated Security=True";
        //Server
        //private readonly string Connection = @"Data Source=31.31.196.115;Initial Catalog=u0295663_shtukituki; User Id=u0295663_phoenixnet;" +
        //    "Password=Uehr8!31; MultipleActiveResultSets=True; Integrated Security=False; Connect Timeout=15;Encrypt=False; Packet Size=4096";

        public string ConnectionString()
        {
            return Connection;
        }

        /// <summary>
        /// Метод обеспечивающий открытие соединения с базой данных
        /// </summary>
        /// <param name="connect"></param>
        public void OpenConnection(SqlConnection connect)
        {
            if (connect != null)
            {
                connect.Open();
            }
        }

        /// <summary>
        /// Метод обеспечивающий закрытие соединения с базой данных
        /// </summary>
        public void CloseConnection(SqlConnection connect)
        {
            if (connect != null)
            {
                connect.Close();
            }
        }
    }
}
