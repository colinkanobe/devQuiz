namespace SuperHeroSpeedNetworking.Models
{
    using System;
    using System.Collections.Generic;

    public class EventModel
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public DateTime StartUtc { get; set; }
        public string Timezone { get; set; }
        public int NumberOfTimeslots { get; set; }
        public int MeetingDuration { get; set; }
        public List<HeroModel> Heroes { get; set; }
        public List<EventMeetingModel> Meetings { get; set; }
    }
}