using System.Web.Http;
using shtuki_tuki.domain.Repository;

namespace shtuki_tuki.web.Controllers
{
    public class WebCategoryController : ApiController
    {
        private readonly CategoryRepository _repositoryGoods = CategoryRepository.Current;

        public IHttpActionResult Get()
        {
            return Ok(_repositoryGoods.GetCategoryCollection());
        }
    }
}
