namespace Day07;

public class DesperatelyTryingCalculator(MutationFactory mutationFactory)
{
    public long? TryToSolve(long desiredResult, long[] operands)
    {
        foreach (var operations in mutationFactory.ProduceAllMutations(operands.Length-1))
        {
            var result = operands[0];
            
            for (int i = 0; i < operations.Length; ++i)
            {
                Operation operation = operations[i];
                if (operation == Operation.Addition)
                {
                    result += operands[i + 1];
                }
                else
                {
                    result *= operands[i + 1];
                }
            }

            if (result == desiredResult)
            {
                return result;
            }
        }

        return null;
    }
}