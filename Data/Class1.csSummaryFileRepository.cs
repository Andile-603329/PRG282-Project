using System.Globalization;
using WildLifeRehabilitationCenter.Business;

namespace WildLifeRehabilitationCenter.Data
{
    public class SummaryFileRepository
    {
        // summary.txt is saved next to the .exe, so it works on any computer.
        private readonly string summaryPath = Path.Combine(AppContext.BaseDirectory, "summary.txt");

        // Turns the summary results into the report text required by the brief.
        public string BuildReportText(SummaryResult result, DateTime generatedAt)
        {
            List<string> lines = new List<string>();
            string dashes = new string('-', 40);

            // Averages: "N/A" when empty, otherwise 2 decimals with a full stop.
            string averageAgeText = "N/A";
            if (result.AverageAge != null)
            {
                averageAgeText = result.AverageAge.Value.ToString("F2", CultureInfo.InvariantCulture);
            }

            string averageScoreText = "N/A";
            if (result.AverageScore != null)
            {
                averageScoreText = result.AverageScore.Value.ToString("F2", CultureInfo.InvariantCulture);
            }

            lines.Add("BAOBAB RIDGE WILDLIFE REHABILITATION CENTRE");
            lines.Add("ANIMAL SUMMARY REPORT");
            lines.Add("Generated: " + generatedAt.ToString("yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture));
            lines.Add(dashes);
            lines.Add("Total animals:".PadRight(26) + result.TotalAnimals);
            lines.Add("Average age (years):".PadRight(26) + averageAgeText);
            lines.Add("Average recovery score:".PadRight(26) + averageScoreText);
            lines.Add(dashes);
            lines.Add("Animals per status:");

            // Fixed order so all five statuses always appear in the same order.
            string[] statusOrder = { "Critical", "Serious", "Stable", "Recovering", "Release-Ready" };
            foreach (string status in statusOrder)
            {
                lines.Add(("  " + status + ":").PadRight(26) + result.StatusCounts[status]);
            }

            return string.Join(Environment.NewLine, lines);
        }

        // Saves the report to summary.txt, replacing the old file. Returns true if it worked.
        public bool WriteSummary(string reportText)
        {
            try
            {
                File.WriteAllText(summaryPath, reportText);
                return true;
            }
            catch (IOException)
            {
                // File is open in another program, or the folder is missing.
                return false;
            }
            catch (UnauthorizedAccessException)
            {
                // File is read-only or we have no permission.
                return false;
            }
        }
    }
}