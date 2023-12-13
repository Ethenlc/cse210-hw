public class Event
{
    protected string _type;
    private string _title;
    private string _description;
    private DateTime _dateAndTime;
    private Address _address;

    public Event(string title, string description, DateTime dateAndTime, string streetAddress)
    {
        _title = title;
        _description = description;
        _dateAndTime = dateAndTime;
        _address = new Address(streetAddress);
    }

    public string GetStandardDetails()
    {
        return $"-Title: {_title}\n-Description: {_description}\n-Date and Time: {_dateAndTime}\n-Address: {_address}";
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    public string GetShortDescription()
    {
        return $"-Type: {_type}\n-Title: {_title}\n-Date: {_dateAndTime.Date}";
    }
}