namespace SuperHeroSpeedNetworking.Models
{
    using System;

    public class EventMeetingModel
    {
        public string Id { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public int TableNumber { get; set; }
        public string HeroId1 { get; set; }
        public string HeroId2 { get; set; }
    }
}