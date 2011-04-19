using System.Web.Mvc;
using CreditCardUtils;
using CreditCardUtils.Enumerations;

namespace TheApp.Controllers
{
    [Common.RequireHttps]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        // 
        // POST /home/verify 
        //
        [HttpPost]
        public ActionResult Verify(CreditCardAuthorizationRequest authorizationRequest)
        {
            var provider = CreditCardProviderFactory.Create(CreditCardGatewayProviders.PayPal);
            return Json(provider.VerifyCreditCardInfo(authorizationRequest));
        }
    }
}
