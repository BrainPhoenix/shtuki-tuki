using shtuki_tuki.domain.Enumerables;
using shtuki_tuki.domain.Repository;
using System.Web.Http;

namespace shtuki_tuki.web.Controllers
{
    public class WebPublicGoodsController : ApiController
    {
        private readonly GoodsRepository _repositoryGoods = GoodsRepository.Current;

        [HttpGet]
        public IHttpActionResult GoodCollectionCategory(int category)
        {
            var typeCategory = SetCategory(category);
            var listgoods = _repositoryGoods.GetGoods(typeCategory);

            return Ok(listgoods);
        }

        public IHttpActionResult Good(int id)
        {
            return Ok();
        }

        public IHttpActionResult GoodCollectionPop()
        {
            return Ok();
        }        

        public IHttpActionResult GoodCollectionOrder()
        {
            return Ok();
        }

        /// <summary>
        /// Установка занчения TypeCategory для коллекции получаемых товаров
        /// </summary>
        /// <param name="category">Значение Id элемента перечисления TypeCategory</param>
        /// <returns></returns>
        private TypeCategory SetCategory(int category)
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
