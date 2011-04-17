namespace CreditCardUtils
{
    public interface ICreditCardAuthorizationProvider
    {
        ICreditCardAuthorizationResponse VerifyCreditCardInfo(ICreditCardAuthorizationRequest request);
    }
}
