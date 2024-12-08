namespace Day07;

public class MutationFactory<T>(T[] variations)
{
    private readonly Dictionary<int, T[][]> _mutationCache = new();

    public T[][] ProduceAllMutations(int lengthOfCombinations)
    {
        if (_mutationCache.TryGetValue(lengthOfCombinations, out var mutations)) return mutations;
        
        T[][] allPossibleCombinations = new T[(int) Math.Pow(variations.Length, lengthOfCombinations)][];
        
        int i = 0;
        for (int amountPointers = 0; amountPointers <= lengthOfCombinations; amountPointers++)
        {
            (int, int)[] patternGenerationPointers = InitPatternGeneratingPointers(amountPointers);
            do
            {
                allPossibleCombinations[i] = new T[lengthOfCombinations];
                Array.Fill(allPossibleCombinations[i], variations[0]);
                foreach ((int,int) pointer in patternGenerationPointers)
                {
                    var (ptrIndex, variation) = pointer;
                    allPossibleCombinations[i][ptrIndex] = variations[variation];
                }
                i += 1;
            } while (TryToMovePointers(patternGenerationPointers, lengthOfCombinations));
        }
        
        _mutationCache[lengthOfCombinations] = allPossibleCombinations;
        return allPossibleCombinations;
    }

    private (int,int)[] InitPatternGeneratingPointers(int amount)
    {
        (int,int)[] patternGeneratingPointers = new(int,int)[amount];
        
        for (int i = 0; i < amount; i++)
        {
            // The pointer start with the first non-standard variation, as the 0th variation is set by default
            patternGeneratingPointers[i] = (i, 1);
        }

        return patternGeneratingPointers;
    }

    private bool TryToMovePointers((int,int)[] patternGeneratingPointers, int lengthOfCombinations)
    {
        for (int ptr = 0; ptr < patternGeneratingPointers.Length; ptr++)
        {
            int ptrIndex = patternGeneratingPointers.Length - ptr - 1;
            if (patternGeneratingPointers[ptrIndex].Item2 < variations.Length - 1)
            {
                // pointer has still some variations to go through
                patternGeneratingPointers[ptrIndex].Item2 += 1;
                // reset following pointers to the first variation so they have to go through all variations again
                for (int i = 1; ptrIndex + i < patternGeneratingPointers.Length; i++)
                {
                    patternGeneratingPointers[ptrIndex + i].Item2 = 1;
                }

                return true;
            }
        }

        for (int ptr = 0; ptr < patternGeneratingPointers.Length; ptr++)
        {
            int ptrIndex = patternGeneratingPointers.Length - ptr - 1;
            
            if (patternGeneratingPointers[ptrIndex].Item1 < lengthOfCombinations - ptr - 1)
            {
                // pointer can still move
                patternGeneratingPointers[ptrIndex].Item1 += 1;
                // reset following pointers to the position just after the last moved pointer
                for (int i = 1; ptrIndex+i < patternGeneratingPointers.Length; i++)
                {
                    patternGeneratingPointers[ptrIndex+i].Item1 = patternGeneratingPointers[ptrIndex].Item1+i;
                }
                // reset following pointers to the first variation so they have to go through all variations again
                for (var i = 0; i < patternGeneratingPointers.Length; i++)
                {
                    patternGeneratingPointers[i].Item2 = 1;
                }

                return true;
            }
        }

        return false;
    }
}