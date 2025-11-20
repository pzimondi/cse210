using System;

public class Address
{
    private string street;
    private string city;
    private string stateOrProvince;
    private string country;

    public Address(string street, string city, string stateOrProvince, string country)
    {
        this.street = street;
        this.city = city;
        this.stateOrProvince = stateOrProvince;
        this.country = country;
    }

    public string Street { get { return street; } set { street = value; } }
    public string City { get { return city; } set { city = value; } }
    public string StateOrProvince { get { return stateOrProvince; } set { stateOrProvince = value; } }
    public string Country { get { return country; } set { country = value; } }

    public bool IsInUSA()
    {
        return country.Trim().ToUpper() == "USA";
    }

    public string GetFullAddress()
    {
        return $"{street}\n{city}, {stateOrProvince}\n{country}";
    }
}
