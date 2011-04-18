namespace CreditCardUtils
{
    public interface ICreditCardAuthorizationRequest
    {
        string FirstName { get; }
        string LastName { get; }
        CreditCardInfo CreditCardInfo { get; }
        AddressInfo AddressInfo { get; }
    }
}
