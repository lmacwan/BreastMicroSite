using System.Web.Mvc;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;

namespace BreastMicroSite.Live
{
    public class HomeController : RenderMvcController
    {
        public override ActionResult Index(RenderModel model)
        {
            return base.Index(model);
        }

        public JsonResult Subscribe(string none, string email)
        {
            var success = false;
            var msg = string.Empty;

            if (MailUtility.SendSingleMail(email))
            {
                success = true;
                msg = "Your request has been submitted successfully.";
            }

            return Json(new { success = success, message = msg }, JsonRequestBehavior.AllowGet);
        }
    }
}
