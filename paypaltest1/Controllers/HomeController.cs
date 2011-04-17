using System;
using System.Web.Mvc;
using CreditCardUtils;
using CreditCardUtils.Enumerations;

namespace paypaltest1.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ICreditCardAuthorizationProvider creditCardProvider = CreditCardProviderFactory.Create(CreditCardGatewayProviders.PayPal);

            var response = creditCardProvider.VerifyCreditCardInfo(new CreditCardAuthorizationRequest(
                    "Jaspreet", 
                    "Bakshi",
                    new CreditCardInfo(CreditCardTypes.Visa, "4683075410516684", "362", DateTime.Parse("04/30/2013")), 
                    new AddressInfo("147 W 35TH ST", "STE 1001", "New York", "NY", "10001", "US")));

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
