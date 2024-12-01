namespace Day01;

public class MultiplyingCounter
{
    public Dictionary<int, int> CountAndMultiply(List<int> countAndMultiplyByItself)
    {
        var dictionary = new Dictionary<int, int>();
        foreach (var toBeCounted in countAndMultiplyByItself)
        {
            dictionary[toBeCounted] = (dictionary.GetValueOrDefault(toBeCounted) / toBeCounted + 1) * toBeCounted;
        }
        return dictionary;
    }
}