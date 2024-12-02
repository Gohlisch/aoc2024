using System.Collections.Immutable;

namespace Day02;

public class ReportSafetyValidator
{
    public bool ProblemDampenerActive { get; set; }

    public bool Validate(Report report)
    {
        if(!ProblemDampenerActive) return IsMonotonic(report.Levels);

        for (int i = 0; i < report.Levels.Count; i++)
        {
            var levels = report.Levels.Select(l => l).ToList();
            levels.RemoveAt(i);
            if (IsMonotonic(levels))
            {
                return true;
            }
        }

        return false;
    }

    private bool IsMonotonic(List<int> levels)
    {
        return levels
                   .Zip(levels.Skip(1), (a, b) => new Tuple<int, int>(a, b))
                   .Select(tuplen => tuplen.Item1 - tuplen.Item2)
                   .All(diff => diff is >= 1 and <= 3)
               || levels
                   .Zip(levels.Skip(1), (a, b) => new Tuple<int, int>(a, b))
                   .Select(tuplen => tuplen.Item2 - tuplen.Item1)
                   .All(diff => diff is >= 1 and <= 3);
    }
}