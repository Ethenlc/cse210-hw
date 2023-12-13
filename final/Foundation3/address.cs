public class Address
{
    private string _streetAddress;

    public Address(string streetAddress)
    {
        _streetAddress = streetAddress;
    }

    public override string ToString()
    {
        return _streetAddress;
    }
}