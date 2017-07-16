using Dapper;
using shtuki_tuki.domain.DbProvider;
using shtuki_tuki.domain.Entities;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace shtuki_tuki.domain.Repository
{
    public class SocialNetworksRepository
    {
        private static SocialNetworksRepository repo = new SocialNetworksRepository();

        public static SocialNetworksRepository Current
        {
            get
            {
                return repo;
            }
        }

        private readonly DatabaseProvider _dbProvider = new DatabaseProvider();

        public List<SocialNetwork> GetSocialNetworkCollection()
        {
            List<SocialNetwork> result = new List<SocialNetwork>();

            using (SqlConnection connect = new SqlConnection(_dbProvider.ConnectionString()))
            {
                connect.Open();

                result = connect.Query<SocialNetwork>("Select LinkNetwork, TypeNetwork From SocialNetworks").ToList();

                connect.Close();
            }

            return result;
        }
    }
}
