using System;

namespace EventPlanner
{
    public class OutdoorGathering : Event
    {
        private string _weatherForecast;

        public OutdoorGathering(string eventTitle, string description, DateTime date, TimeSpan time, Address address, string weatherForecast)
            : base (eventTitle, description, date, time, address)
        {
            _weatherForecast = weatherForecast;
        }

        public override string GetFullDetails()
        {
            return base.GetFullDetails() + $"\nWeather: {_weatherForecast}";
        }
    }
}