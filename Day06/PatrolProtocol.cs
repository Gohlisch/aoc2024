using Day04;

namespace Day06;

enum Direction
{
    North,
    East,
    South,
    West
}

static class DirectionMethods
{
    public static Direction TurnToRight(this Direction currentDirection)
    {
        switch (currentDirection)
        {
            case Direction.North: return Direction.East;
            case Direction.East: return Direction.South;
            case Direction.South: return Direction.West;
            case Direction.West: return Direction.North;
        }

        throw new Exception("Illegal state. currentDirection is unknown: " + currentDirection);
    }

    public static (int, int) MoveForward(this Direction currentDirection)
    {
        switch (currentDirection)
        {
            case Direction.North: return (-1, 0);
            case Direction.East: return (0, 1);
            case Direction.South: return (1, 0);
            case Direction.West: return (0, -1);
        }

        throw new Exception("Illegal state. currentDirection is unknown: " + currentDirection);
    }
}

public class PatrolProtocol(Grid labMap)
{
    public int ExecuteProcol()
    {
        var (guardRow, guardCol) = labMap.FindAllLocations('^').First();
        Direction guardDirection = Direction.North;

        do
        {
            labMap.Set(guardRow, guardCol, 'X');
            var (rowMovement, colMovement) = guardDirection.MoveForward();
            int nextRow = guardRow + rowMovement;
            int nextCol = guardCol + colMovement;

            if (labMap.OutOfBounds(nextRow, nextCol))
            {
                return labMap.FindAllLocations('X').Count;
            }

            if (labMap.Get(nextRow, nextCol) == '#')
            {
                guardDirection = guardDirection.TurnToRight();
            }
            else
            {
                guardRow = nextRow;
                guardCol = nextCol;
            }
        } while (true);
    }
}