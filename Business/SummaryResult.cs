namespace WildLifeRehabilitationCenter.Business
{
    // Holds the results of the summary calculation.
    public class SummaryResult
    {
        public int TotalAnimals { get; set; }
        public double? AverageAge { get; set; }
        public double? AverageScore { get; set; }
        public Dictionary<string, int> StatusCounts { get; set; } = new Dictionary<string, int>();
    }
}