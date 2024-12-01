namespace Day01;

internal abstract class Program
{
    private static void Main()
    {
        Console.WriteLine("Day 1 - Puzzle 1");
        Console.WriteLine(new PartOneSolver().Solve(Puzzle.input));
        Console.WriteLine("Day 1 - Puzzle 2");
        Console.WriteLine(new PartTwoSolver().Solve(Puzzle.input));
    }
}