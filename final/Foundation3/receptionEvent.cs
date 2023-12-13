public class ReceptionEvent : Event
{
    private string _rsvpEmail;

    public ReceptionEvent(string title, string description, DateTime dateAndTime, string streetAddress, string rsvpEmail)
        : base(title, description, dateAndTime, streetAddress)
        {
            _type = "Reception";
            _rsvpEmail = rsvpEmail;
        }

        public override string GetFullDetails()
        {
            return base.GetFullDetails() + $"\n-RSVP Email: {_rsvpEmail}";
        }
}