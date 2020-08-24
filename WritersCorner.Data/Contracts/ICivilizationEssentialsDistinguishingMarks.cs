
namespace WritersCorner.Data.Contracts
{
    public interface ICivilizationEssentialsDistinguishingMarks
    {
        public string Languages { get; set; }
        public string Dialects { get; set; }
        public string Asscents { get; set; }

        public string Trading { get; set; }
        public string Food { get; set; }
        public string FoodObtainingWays { get; set; }

        public string Art { get; set; }
        public string Holidays { get; set; }
        public string Entertainments { get; set; }
    }
}
