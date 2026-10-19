using WildLifeRehabilitationCenter.Data;

namespace WildLifeRehabilitationCenter.Business
{
    public class SummaryService
    {
        // Calculates the totals, averages and per-status counts for a list of animals.
        public SummaryResult BuildSummary(List<Animal> animals)
        {
            SummaryResult result = new SummaryResult();

            // Start every status at 0 so statuses with no animals still appear.
            result.StatusCounts["Critical"] = 0;
            result.StatusCounts["Serious"] = 0;
            result.StatusCounts["Stable"] = 0;
            result.StatusCounts["Recovering"] = 0;
            result.StatusCounts["Release-Ready"] = 0;

            result.TotalAnimals = animals.Count;

            if (animals.Count == 0)
            {
                return result;
            }

            int scoreTotal = 0;
            int ageTotal = 0;
            int animalsWithAge = 0;

            foreach (Animal animal in animals)
            {
                scoreTotal = scoreTotal + animal.RecoveryScore;

                // Adds age if empty
                if (animal.Age != null)
                {
                    ageTotal = ageTotal + animal.Age.Value;
                    animalsWithAge = animalsWithAge + 1;
                }



                ////////////////
                // TODO: replace this line with the team's classification method (Step 2A).
                ////////////
                string status = "";

                result.StatusCounts[status] = result.StatusCounts[status] + 1;
            }

            result.AverageScore = (double)scoreTotal / animals.Count;

            if (animalsWithAge > 0)
            {
                result.AverageAge = (double)ageTotal / animalsWithAge;
            }

            return result;
        }
    }
}