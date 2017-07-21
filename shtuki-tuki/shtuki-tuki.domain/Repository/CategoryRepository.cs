using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using shtuki_tuki.domain.DbProvider;
using shtuki_tuki.domain.Entities;

namespace shtuki_tuki.domain.Repository
{
    public class CategoryRepository
    {
        public static CategoryRepository Current { get; } = new CategoryRepository();
        private readonly DatabaseProvider _dbProvider = new DatabaseProvider();

        public List<Category> GetCategoryCollection()
        {
            List<Category> result;

            using (SqlConnection connect = new SqlConnection(_dbProvider.ConnectionString()))
            {
                connect.Open();
                result = connect.Query<Category>("Select Id, Name, TypeCategory From Categories").ToList();
                connect.Close();
            }

            return result;
        }
    }
}
