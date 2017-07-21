using System.Web.Helpers;
using shtuki_tuki.domain.Repository;
using System.Web.Http;
using System.Web.Mvc;
using shtuki_tuki.domain.Entities;
using shtuki_tuki.web.Infrastructure;

namespace shtuki_tuki.web.Controllers
{
    public class WebGoodsController : ApiController
    {
        private readonly GoodsRepository _repositoryGoods = GoodsRepository.Current;

        /// <summary>
        /// Получение списка товаров с установленным в true свойства Popular
        /// </summary>
        /// <returns></returns>
        [System.Web.Http.AllowAnonymous]
        [System.Web.Http.HttpGet]
        public IHttpActionResult Get()
        {
            return Ok(_repositoryGoods.GetGoodCollectionPop());
        }

        /// <summary>
        /// Получение списка товаров определенной категории из каталога
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        [System.Web.Http.AllowAnonymous]
        [System.Web.Http.HttpGet]
        public IHttpActionResult Get(int categoryId)
        {
            return Ok(_repositoryGoods.GetGoodCollectionCategory(categoryId));
        }

        [System.Web.Mvc.HttpPost]
        public JsonResult Post(int categoryId)
        {
            //, string name, string descript, string size, string material, decimal price
            //if (categoryId > 0 && !string.IsNullOrEmpty(name) && price >= 0)
            //{
            //    var good = new Good
            //    {
            //        Name = name,
            //        Price = price,
            //        Discription = descript,
            //        Material = material,
            //        Size = size
            //    };
                
            //    return Ok(_repositoryGoods.CreateGood(good, categoryId));
            //}

            return new JsonResult
            {
                Data = BadRequest("Input parameters error"),
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };
        }

        [System.Web.Http.HttpPut]
        public IHttpActionResult Put(int categoryId, int goodId, string name, string descript, string size, string material, decimal price)
        {
            return Ok();
        }

        [System.Web.Http.HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            return Ok();
        }
    }
}
