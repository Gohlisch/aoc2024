using AoCUtils;

namespace Day01;

public class PartOneSolver : ISolver
{
    public string Solve(string input)
    {
        var (left, right) = new DistanceReader().Read(input);
        var calculator = new DistanceCalculator();

        return left
            .Zip(right)
            .Select(d => calculator.CalculateDistance(d.First, d.Second))
            .Sum()
            .ToString();
    }
}