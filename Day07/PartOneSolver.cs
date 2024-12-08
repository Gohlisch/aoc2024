using AoCUtils;

namespace Day07;

public class PartOneSolver : ISolver
{
    public string Solve(string input)
    {
        var combinator = new DesperatelyTryingCalculator(new MutationFactory<Operation>([Operation.Addition, Operation.Multiplication]));
        return new OperandParser().Parse(input)
            .Select((resultAndOperands) => combinator.TryToSolve(resultAndOperands.Item1, resultAndOperands.Item2))
            .Where(res => res != null)
            .Sum()
            .ToString();
    }

}