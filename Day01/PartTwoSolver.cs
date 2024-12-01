using AoCUtils;

namespace Day01;

public class PartTwoSolver : ISolver
{
    public string Solve(string input)
    {
        var (left, right) = new DistanceReader().Read(input);
        var multipliedByCount = new MultiplyingCounter().CountAndMultiply(right);
        
        return left
            .Select(x => multipliedByCount.GetValueOrDefault(x))
            .Sum()
            .ToString();
    }
}