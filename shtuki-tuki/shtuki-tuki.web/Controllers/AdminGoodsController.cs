using shtuki_tuki.domain.Repository;
using shtuki_tuki.web.Infrastructure;
using System.Web.Mvc;

namespace shtuki_tuki.web.Controllers
{
    [CustomAuthorize(Roles = "Administrators")]
    public class AdminGoodsController : Controller
    {
        private readonly GoodsRepository _repositoryGoods = GoodsRepository.Current;

        [HttpPost]
        public JsonResult CreateGood(int categoryId, string name, string descript, string size, string material, decimal price)
        {
            return new JsonResult
            {
                Data = "Excellent",
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };
        }

        [HttpPut]
        public JsonResult EditGood(int categoryId, int goodId, string name, string descript, string size, string material, decimal price)
        {
            return new JsonResult
            {
                Data = "Excellent",
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };
        }

        [HttpDelete]
        public JsonResult DeleteGood(int goodId)
        {
            return new JsonResult
            {
                Data = "Excellent",
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };
        }

        [HttpPost]
        public JsonResult SetHitGood(bool flag, int goodId)
        {
            return new JsonResult
            {
                Data = "Excellent",
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };
        }

        [HttpPost]
        public JsonResult SetNewGood(bool flag, int goodId)
        {
            return new JsonResult
            {
                Data = "Excellent",
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };
        }

        [HttpPost]
        public JsonResult SetPopGood(bool flag, int goodId)
        {
            return new JsonResult
            {
                Data = "Excellent",
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };
        }

        [HttpPost]
        public JsonResult GetAdditionalImages(int goodId)
        {
            return new JsonResult
            {
                Data = "Excellent",
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };
        }

        [HttpPost]
        public JsonResult UploadAdditionalImages(int goodId)
        {
            return new JsonResult
            {
                Data = "Excellent",
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };
        }

        [HttpDelete]
        public JsonResult DeleteAdditionalImage(int imageId)
        {
            return new JsonResult
            {
                Data = "Excellent",
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };
        }

        [HttpGet]
        public JsonResult GetNoRelationGoods(int goodId, int categoryId)
        {
            return new JsonResult
            {
                Data = "Excellent",
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };
        }

        [HttpGet]
        public JsonResult GetRelationGoods(int goodId, int categoryId)
        {
            return new JsonResult
            {
                Data = "Excellent",
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };
        }

        [HttpPost]
        public JsonResult SetRelationGoods(int goodId, int goodRelationId, int categoryId)
        {
            return new JsonResult
            {
                Data = "Excellent",
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };
        }

        [HttpDelete]
        public JsonResult DeleteRelationGoods(int goodId, int goodRelationId, int categoryId)
        {
            return new JsonResult
            {
                Data = "Excellent",
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };
        }
    }
}