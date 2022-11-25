using codeKatas.MarsRovers.Directions;

namespace codeKatas.MarsRovers;

public class Grid
{
    private const int MaxDistance = 10;
    private const int MinDistance = 0;

    public List<Position> _obstacles { get; private set; } = new List<Position>();

    public Grid(List<Position> obstacles)
    {
        _obstacles = obstacles;
    }

    public Position NextPosition(Position currentPosition, Direction direction)
    {
        Position nextPosition = null;
        switch (direction)
        {
            case North:
                nextPosition = MoveUp(currentPosition);
                break;
            case East:
                nextPosition = MoveRight(currentPosition);

                break;
            case West:
                nextPosition = MoveLeft(currentPosition);

                break;
            case South:
                nextPosition = MoveDown(currentPosition);

                break;
        }

        return nextPosition;
    }

    private Position MoveUp(Position current)
    {
        var newY = (current.Y % MaxDistance) + 1;
        var nextPosition = new Position(current.X, newY);

        return IsNotObstacle(nextPosition) ? nextPosition : null;
    }

    private Position MoveRight(Position current)
    {
        var newX = (current.X % MaxDistance) + 1;
        var nextPosition = new Position(newX, current.Y);

        return IsNotObstacle(nextPosition) ? nextPosition : null;
    }

    private Position MoveDown(Position current)
    {
        var nextY = current.Y == MinDistance ? 9 : current.Y - 1;
        var nextPosition = new Position(current.X, nextY);

        return IsNotObstacle(nextPosition) ? nextPosition : null;
    }

    private Position MoveLeft(Position current)
    {
        var nextX = current.X == MinDistance ? 9 : current.X - 1;
        var nextPosition = new Position(nextX, current.Y);

        return IsNotObstacle(nextPosition) ? nextPosition : null;
    }

    private bool IsNotObstacle(Position nextPosition)
    {
        return _obstacles.All(a => a != nextPosition);
    }
}