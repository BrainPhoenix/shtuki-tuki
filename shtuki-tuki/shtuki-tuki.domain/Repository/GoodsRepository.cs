using Dapper;
using shtuki_tuki.domain.Common;
using shtuki_tuki.domain.DbProvider;
using shtuki_tuki.domain.Entities;
using shtuki_tuki.domain.Enumerables;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace shtuki_tuki.domain.Repository
{
    public class GoodsRepository
    {
        private static GoodsRepository repo = new GoodsRepository();

        public static GoodsRepository Current
        {
            get
            {
                return repo;
            }
        }

        private readonly DatabaseProvider _dbProvider = new DatabaseProvider();

        public List<Good> GetGoods(TypeCategory category)
        {
            List<Good> result = new List<Good>();

            using (SqlConnection connect = new SqlConnection(_dbProvider.ConnectionString()))
            {
                connect.Open();

                int categoryId = connect.Query<int>("Select Id From Categories Where TypeCategory = @Type; SELECT CAST(SCOPE_IDENTITY() as int)", new { Type = category }).First();
                result = connect.Query<Good>("Select Id, Name, Price, Hit, New, Pop From Goods Where Category_Id = @ID", new { ID = categoryId }).ToList();

                connect.Close();
            }

            return result;
        }

        public ValidEvents CreateGood(Good goodCreate)
        {
            return new ValidEvents();
        }

        public ValidEvents UpdateGood(Good goodUpdate)
        {
            return new ValidEvents();
        }

        public ValidEvents DeleteGood(Good goodDelete)
        {
            return new ValidEvents();
        }
    }
}
