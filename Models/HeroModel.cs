namespace SuperHeroSpeedNetworking.Models
{
    using System.Collections.Generic;

    public class HeroModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public List<HeroPreferenceModel> Preferences { get; set; }
    }
}
