using shtuki_tuki.domain.Enumerables;
using shtuki_tuki.domain.Repository;
using shtuki_tuki.web.Infrastructure;
using System.Web.Http;

namespace shtuki_tuki.web.Controllers
{
    [CustomAuthorize(Roles = "Administrators")]
    public class WebGoodsController : ApiController
    {
        private readonly GoodsRepository _repositoryGoods = GoodsRepository.Current;

        [AllowAnonymous]
        [HttpGet]
        public IHttpActionResult GoodCollectionCategory(ushort category)
        {
            var typeCategory = SetCategory(category);
            var listgoods = _repositoryGoods.GetGoodCollectionCategory(typeCategory);

            return Ok(listgoods);
        }

        [AllowAnonymous]
        [HttpGet]
        public IHttpActionResult GoodCollectionPop()
        {
            var listgoods = _repositoryGoods.GetGoodCollectionPop();
            return Ok(listgoods);
        }          

        [AllowAnonymous]
        [HttpGet]
        public IHttpActionResult GoodCollectionOrder()
        {
            return Ok();
        }

        /// <summary>
        /// Установка занчения TypeCategory для коллекции получаемых товаров
        /// </summary>
        /// <param name="category">Значение Id элемента перечисления TypeCategory</param>
        /// <returns></returns>
        private TypeCategory SetCategory(ushort category)
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
