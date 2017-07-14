using shtuki_tuki.domain.Common;
using shtuki_tuki.domain.DbProvider;
using shtuki_tuki.domain.Entities;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace shtuki_tuki.domain.Repository
{
    public class GoodsRepository
    {
        private readonly DatabaseProvider _dbProvider = new DatabaseProvider();

        public IList<Good> GetGoods()
        {
            using(SqlConnection connect = new SqlConnection())
            {
                connect.ConnectionString = _dbProvider.ConnectionString();

                try
                {
                    _dbProvider.OpenConnection(connect);


                }
                catch
                {
                    return new List<Good>();
                }
                finally
                {
                    _dbProvider.CloseConnection(connect);
                }
            }

            return null;
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
