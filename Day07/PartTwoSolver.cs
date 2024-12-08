using AoCUtils;

namespace Day07;

public class PartTwoSolver : ISolver
{
    public string Solve(string input)
    {
        var combinator = new DesperatelyTryingCalculator(new MutationFactory<Operation>([Operation.Addition, Operation.Multiplication, Operation.Concatenation]));
        return new OperandParser().Parse(input)
            .Select((resultAndOperands) => combinator.TryToSolve(resultAndOperands.Item1, resultAndOperands.Item2))
            .Where(res => res != null)
            .Sum()
            .ToString();
    }
}