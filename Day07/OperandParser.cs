namespace Day07;

public class OperandParser
{
    public (long, long[])[] Parse(string s)
    {
        return s.Split(Environment.NewLine)
            .Where(str => str.Length > 0)
            .Select(line =>
            {
                var resultAndOperands = line.Split(":");
                return (long.Parse(resultAndOperands[0]), resultAndOperands[1].Trim()
                    .Split(" ")
                    .Select(long.Parse)
                    .ToArray());
            }).ToArray();
    }
}