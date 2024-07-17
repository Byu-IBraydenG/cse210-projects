using System;

namespace EventPlanner
{
    public class Reception : Event
    {
        private string _rsvpEmail;

        public Reception(string eventTitle, string description, DateTime date, TimeSpan time, Address address, string rsvpEmail)
            : base (eventTitle, description, date, time, address)
        {
            _rsvpEmail = rsvpEmail;
        }

        public override string GetFullDetails()
        {
            return base.GetFullDetails() + $"\nRSVP Email: {_rsvpEmail}";
        }
    }
}