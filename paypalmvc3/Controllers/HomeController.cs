using System.Web.Mvc;
using CreditCardUtils;
using CreditCardUtils.Enumerations;

namespace paypalmvc3.Controllers
{
    [RequireHttps]
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
