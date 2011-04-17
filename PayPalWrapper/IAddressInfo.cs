namespace CreditCardUtils
{
    public interface IAddressInfo
    {
        string Address1 { get; }
        string Address2 { get; }
        string City { get; }
        string State { get; }
        string ZipCode { get; }
        string Country { get; }
    }
}   
