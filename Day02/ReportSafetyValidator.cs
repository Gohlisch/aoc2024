namespace Day02;

public class ReportSafetyValidator
{
    public bool Validate(Report report)
    {
        return report.Levels
                   .Zip(report.Levels.Skip(1), (a, b) => new Tuple<int, int>(a, b))
                   .Select(tuplen => tuplen.Item1 - tuplen.Item2)
                   .All(diff => diff is >= 1 and <= 3)
               || report.Levels
                   .Zip(report.Levels.Skip(1), (a, b) => new Tuple<int, int>(a, b))
                   .Select(tuplen => tuplen.Item2 - tuplen.Item1)
                   .All(diff => diff is >= 1 and <= 3);
    }
}