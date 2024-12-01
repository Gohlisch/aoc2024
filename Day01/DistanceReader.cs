namespace Day01;

public class DistanceReader
{
    public (List<int>, List<int>) Read(string input)
    {
        var lines = input.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
        var left = new List<int>();
        var right = new List<int>();
        foreach (var l in lines)
        {
            var leftAndRight = l.Split("   ", StringSplitOptions.RemoveEmptyEntries);
            left.Add(int.Parse(leftAndRight[0]));
            right.Add(int.Parse(leftAndRight[1]));
        }
        left.Sort();
        right.Sort();
        return (left, right);
    }
}