using Dapper;
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
        public static GoodsRepository Current { get; } = new GoodsRepository();

        private readonly DatabaseProvider _dbProvider = new DatabaseProvider();

        public List<Good> GetGoodCollectionCategory(int category)
        {
            var typeCategory = SetCategory(category);
            List<Good> result;

            using (SqlConnection connect = new SqlConnection(_dbProvider.ConnectionString()))
            {
                connect.Open();

                int categoryId = connect.Query<int>("Select Id From Categories Where TypeCategory = @Type; SELECT CAST(SCOPE_IDENTITY() as int)", new { Type = typeCategory }).First();
                result = connect.Query<Good>("Select Id, Name, Price, Hit, New, Pop From Goods Where Category_Id = @ID", new { ID = categoryId }).ToList();

                connect.Close();
            }

            return result;
        }

        public List<Good> GetGoodCollectionPop()
        {
            List<Good> result;

            using(SqlConnection connect = new SqlConnection(_dbProvider.ConnectionString()))
            {
                connect.Open();

                result = connect.Query<Good>("Select Id, Name, Price, Category_Id From Goods Where Pop = @Bool", new { Bool = 1 }).ToList();

                connect.Close();
            }

            return result;
        }

        public Good GetGood(long id)
        {
            Good result;

            using(SqlConnection connect= new SqlConnection(_dbProvider.ConnectionString()))
            {
                connect.Open();

                result = connect.QueryFirst<Good>("Select Id, Name, Size, Discription, Material, Price, Hit, New, Pop From Goods Where Id = @ID", new { ID = id });

                connect.Close();
            }

            return result;
        }

        public long CreateGood(Good good, long categoryId)
        {
            long result;

            using (SqlConnection connect = new SqlConnection(_dbProvider.ConnectionString()))
            {
                connect.Open();
                result = connect.QueryFirst("INSERT INTO Goods (Name, Size, Discription, Material, Price, Category_Id) VALUES (@name, @size, @description, @material, @price, @category_Id); SELECT CAST(SCOPE_IDENTITY() as int)",
                    new {name = good.Name, size = good.Size, description = good.Discription, material = good.Material, price = good.Price, category_Id = categoryId});
                connect.Close();
            }

            return result;
        }

        public void AddGoodAvatar(GoodsPhoto goodsPhoto, long goodId, string typeMethod)
        {
            using (SqlConnection connect = new SqlConnection(_dbProvider.ConnectionString()))
            {
                connect.Open();

                if (typeMethod == "create")
                {

                }
                else if (typeMethod == "edit")
                {

                }
                //connect.Query("INSERT INTO Goods (Name, Size, Discription, Material, Price, Category_Id) VALUES (@name, @size, @description, @material, @price, @category_Id)",
                //    new { name = good.Name, size = good.Size, description = good.Discription, material = good.Material, price = good.Price, category_Id = categoryId });

                connect.Close();
            }
        }

        public void UpdateGood(Good goodUpdate)
        {
            
        }

        public void DeleteGood(long id)
        {
            
        }

        /// <summary>
        /// Установка занчения TypeCategory для коллекции получаемых товаров
        /// </summary>
        /// <param name="category">Значение Id элемента перечисления TypeCategory</param>
        /// <returns></returns>
        private TypeCategory SetCategory(long category)
        {
            TypeCategory result = new TypeCategory();

            if (category.Equals(0))
            {
                result = TypeCategory.Doors;
            }
            else if (category.Equals(3))
            {
                result = TypeCategory.Fixtures;
            }
            else if (category.Equals(2))
            {
                result = TypeCategory.Furniture;
            }
            else if (category.Equals(1))
            {
                result = TypeCategory.Stairs;
            }
            else if (category.Equals(4))
            {
                result = TypeCategory.DesignExp;
            }

            return result;
        }
    }
}
