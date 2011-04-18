using com.paypal.sdk.profiles;
using com.paypal.sdk.services;
using com.paypal.sdk.util;
using CreditCardUtils.Enumerations;

namespace CreditCardUtils.Implementations
{
    internal class PayPalAuthorizationProvider : ICreditCardAuthorizationProvider
    {
        public ICreditCardAuthorizationResponse VerifyCreditCardInfo(ICreditCardAuthorizationRequest request)
        {
            var caller = new NVPCallerServices();
            IAPIProfile profile = ProfileFactory.createSignatureAPIProfile();

            // Set up your API credentials, PayPal end point, API operation and version.
            profile.APIUsername = "mv1_1302977681_biz_api1.hotmail.com";
            profile.APIPassword = "1302977698";
            profile.APISignature = "AzbQABSL2jEPPHG.eDus2jfMT0xEAUITxvhhUWGmd3DHxaPXx6Zs1MPR";
            profile.Environment = "sandbox";
            caller.APIProfile = profile;

            var encoder = new NVPCodec();

            encoder["SIGNATURE"] = "AzbQABSL2jEPPHG.eDus2jfMT0xEAUITxvhhUWGmd3DHxaPXx6Zs1MPR";
            encoder["USER"] = "mv1_1302977681_biz_api1.hotmail.com";
            encoder["PWD"] = "1302977698";
            encoder["VERSION"] = "60.0";
            encoder["METHOD"] = "DoDirectPayment";

            // Add request-specific fields to the request.
            encoder["PAYMENTACTION"] = CreditCardPaymentActions.Authorization.ToString();
            encoder["AMT"] = "100";
            encoder["CREDITCARDTYPE"] = request.CreditCardInfo.Type.ToString();
            encoder["IPADDRESS"] = "192.168.0.1";
            encoder["ACCT"] = request.CreditCardInfo.CreditCardNumber;
            encoder["EXPDATE"] = request.CreditCardInfo.ExpirationDate.ToString("MMyyyy");
            encoder["CVV2"] = request.CreditCardInfo.Cvv2Number;
            encoder["FIRSTNAME"] = request.FirstName;
            encoder["LASTNAME"] = request.LastName;
            encoder["STREET"] = request.AddressInfo.Address1;
            encoder["CITY"] = request.AddressInfo.City;
            encoder["STATE"] = request.AddressInfo.State;
            encoder["ZIP"] = request.AddressInfo.ZipCode;
            encoder["COUNTRYCODE"] = request.AddressInfo.Country;
            encoder["CURRENCYCODE"] = "USD";

            // Execute the API operation and obtain the response.
            string pStrrequestforNvp = encoder.Encode();
            string pStresponsenvp = caller.Call(pStrrequestforNvp);

            var decoder = new NVPCodec();
            decoder.Decode(pStresponsenvp);
            return new CreditCardAuthorizationReponse(decoder["ACK"] == "Success");
        }
    }
}