namespace Day07;

public class MutationFactory
{
    private readonly Dictionary<int, Operation[][]> _mutationCache = new();

    public Operation[][] ProduceAllMutations(int amountOfOperations)
    {
        if (_mutationCache.TryGetValue(amountOfOperations, out var mutations)) return mutations;
        
        Operation[][] allPossibleVariations = new Operation[(int) Math.Pow(2, amountOfOperations)][];
        
        int i = 0;
        for (int amountPointers = 0; amountPointers <= amountOfOperations; amountPointers++)
        {
            int[] patternGenerationPointers = InitPatternGeneratingPointers(amountPointers);
            do
            {
                allPossibleVariations[i] = new Operation[amountOfOperations];
                Array.Fill(allPossibleVariations[i], Operation.Addition);
                foreach (int pointer in patternGenerationPointers)
                {
                    allPossibleVariations[i][pointer] = Operation.Multiplication;
                }
                i += 1;
            } while (TryToMovePointers(patternGenerationPointers, amountOfOperations));
        }
        
        _mutationCache[amountOfOperations] = allPossibleVariations;
        return allPossibleVariations;
    }

    private int[] InitPatternGeneratingPointers(int amount)
    {
        int[] patternGeneratingPointers = new int[amount];
        for (int i = 0; i < amount; i++)
        {
            patternGeneratingPointers[i] = i;
        }

        return patternGeneratingPointers;
    }

    private bool TryToMovePointers(int[] patternGeneratingPointers, int amountOfOperations)
    {
        for (int ptr = 0; ptr < patternGeneratingPointers.Length; ptr++)
        {
            int ptrIndex = patternGeneratingPointers.Length - ptr - 1;
            if (patternGeneratingPointers[ptrIndex] < amountOfOperations - ptr - 1)
            {
                // pointer can still move
                patternGeneratingPointers[ptrIndex] += 1;
                // reset following pointers to the position just after the last moved pointer
                for (int i = 1; ptrIndex+i < patternGeneratingPointers.Length; i++)
                {
                    patternGeneratingPointers[ptrIndex+i] = patternGeneratingPointers[ptrIndex]+i;
                }
                return true;
            }
        }

        return false;
    }
}