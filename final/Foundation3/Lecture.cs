using System;

namespace EventPlanner
{
    public class Lecture : Event
    {
        private string _speaker;
        private int _capacity;

        public Lecture(string eventTitle, string description, DateTime date, TimeSpan time, Address address, string speaker , int capacity)
            : base(eventTitle, description, date, time, address)
        {
            _speaker = speaker;
            _capacity = capacity;
        }

        public override string GetFullDetails()
        {
            return base.GetFullDetails() + $"\nSpeaker: {_speaker}\nCapacity {_capacity}";
        }
    }
}