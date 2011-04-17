namespace CreditCardUtils
{
    public class AddressInfo : IAddressInfo
    {
        public AddressInfo(string a1, string a2, string city, string state, string zipcode, string country)
        {
            Address1 = a1;
            Address2 = a2;
            City = city;
            State = state;
            ZipCode = zipcode;
            Country = country;
        }

        public string Address1 { get; private set; }
        public string Address2 { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string ZipCode { get; private set; }
        public string Country { get; private set; }
    }
}
