namespace CreditCardUtils
{
    public class AddressInfo : IAddressInfo
    {
        public AddressInfo()
        {}

        public AddressInfo(string a1, string a2, string city, string state, string zipcode, string country)
        {
            Address1 = a1;
            Address2 = a2;
            City = city;
            State = state;
            ZipCode = zipcode;
            Country = country;
        }

        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
    }
}
