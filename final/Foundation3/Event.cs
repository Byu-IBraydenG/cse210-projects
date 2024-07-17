using System;

namespace EventPlanner
{
    public class Event
    {
        private string _eventTitle;
        private string _description;
        private DateTime _date;
        private TimeSpan _time;
        private Address _eventAddress;

        public Event(string eventTitle, string description, DateTime date, TimeSpan time, Address address)
        {
            _eventTitle = eventTitle;
            _description = description;
            _date = date;
            _time = time;
            _eventAddress = address;
        }

        public virtual string GetStandardDetails()
        {
            return $"Title: {_eventTitle}\nDescription: {_description}\nDate: {_date.ToShortDateString()}\nTIme: {_time}\nAddress: {_eventAddress}";
        }

        public virtual string GetFullDetails()
        {
            return GetStandardDetails() + $"\nType: {GetType().Name}";
        }

        public virtual string GetShortDescription()
        {
            return $"Type: {GetType().Name}\nTitle: {_eventTitle}\nDate: {_date.ToShortDateString()}";
        }
    }
}