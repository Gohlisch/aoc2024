using AoCUtils;

namespace Day02;

public class PartOneSolver : ISolver
{
    private readonly ReportParser _reportParser = new();
    private readonly ReportSafetyValidator _reportSafetyValidator = new();
    
    public string Solve(string input)
    {
        return input.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries)
            .Select(_reportParser.Parse)
            .Where(_reportSafetyValidator.Validate)
            .Count()
            .ToString();
    }
}