
namespace WritersCorner.Data.Contracts
{
    //общо за Прослойките и Градовете
    public interface ICivilizationEssentials
    {
        #region Essential
        public string CreationOn { get; set; }
        public string Resources { get; set; }
        public string Hierarchy { get; set; }

        public string Rulers { get; set; }

        public string Flaws { get; set; }
        public string Merits { get; set; }

        public string Size { get; set; }
        public string SituatedIn { get; set; }

        public string BargainingChip { get; set; }
        #endregion

        #region Appearance
        public string Clothes { get; set; }

        #endregion

        public string Punishments { get; set; }
        public string Characteristics { get; set; }
        public string EmotionalState { get; set; }
    }
}
