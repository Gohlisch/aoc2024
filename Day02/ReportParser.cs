namespace Day02;

public class ReportParser
{
    public Report Parse(string report) => new(report.Split(" ").Select(int.Parse).ToList());
}