namespace WildLifeRehabilitationCenter.Business
{
    public static class AnimalClassifier
    {
        // Works out the status and housing unit for a recovery score (0-100).
        public static (string Status, string HousingUnit) Classify(int score)
        {
            if (score <= 19) return ("Critical", "Intensive Care Unit");
            if (score <= 39) return ("Serious", "High-Dependency Ward");
            if (score <= 59) return ("Stable", "Recovery Ward");
            if (score <= 79) return ("Recovering", "Outdoor Enclosure");
            return ("Release-Ready", "Pre-Release Camp");
        }
    }
}