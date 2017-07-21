using shtuki_tuki.web.Infrastructure;
using System.Web.Mvc;

namespace shtuki_tuki.web.Controllers
{
    [CustomAuthorize(Roles = "Administrators")]
    public class AdminGoodsController : Controller
    {
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