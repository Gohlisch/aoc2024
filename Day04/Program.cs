namespace Day04;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Day 4 - Puzzle 1");
        Console.WriteLine(new PartOneSolver().Solve(Puzzle.input));
        Console.WriteLine("Day 4 - Puzzle 2");
        // 341
        Console.WriteLine(new PartTwoSolver().Solve(Puzzle.input));
    }
}