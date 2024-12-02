namespace Day02;

internal abstract class Program
{
    private static void Main()
    {
        Console.WriteLine("Day 2 - Puzzle 1");
        Console.WriteLine(new PartOneSolver().Solve(Puzzle.input));
        Console.WriteLine("Day 2 - Puzzle 2");
        // 341
        Console.WriteLine(new PartTwoSolver().Solve(Puzzle.input));
    }
}