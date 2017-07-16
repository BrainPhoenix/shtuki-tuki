using Dapper;
using shtuki_tuki.domain.DbProvider;
using shtuki_tuki.domain.Entities;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace shtuki_tuki.domain.Repository
{
    public class ContactsRepository
    {
        private static ContactsRepository repo = new ContactsRepository();

        public static ContactsRepository Current
        {
            get
            {
                return repo;
            }
        }

        private readonly DatabaseProvider _dbProvider = new DatabaseProvider();

        public List<Contact> GetContactCollection()
        {
            List<Contact> result = new List<Contact>();

            using (SqlConnection connect = new SqlConnection(_dbProvider.ConnectionString()))
            {
                connect.Open();

                result = connect.Query<Contact>("Select Phone, Email From Contacts").ToList();

                connect.Close();
            }

            return result;
        }
    }
}
