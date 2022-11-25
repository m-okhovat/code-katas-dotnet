using codeKatas.Directions;

namespace codeKatas;

public class MarsRover
{
    private readonly Grid _grid;
    private Direction _direction = new North();
    private bool _hasFacedAnObstacle = false;
    private Position _position = new Position(0, 0);

    public MarsRover(Grid grid)
    {
        _grid = grid;
    }

    private const char MoveCommand = 'M';
    private const char TurnLeftCommand = 'L';
    private const char TurnRightCommand = 'R';
    private const int MaxDistance = 10;
    private const int MinDistance = 0;

    public string Execute(string command)
    {
        foreach (var item in command.ToCharArray())
        {
            if (item.Equals(TurnRightCommand))
            {
                TurnRight();
            }

            if (item.Equals(TurnLeftCommand))
            {
                TurnLeft();
            }

            if (item.Equals(MoveCommand))
            {
                _position = Move(_position, _direction);
            }
        }

        var obstaclePart = string.Empty;
        if (_hasFacedAnObstacle)
            obstaclePart = "O:";

        _hasFacedAnObstacle = false;

        return $"{obstaclePart}{_position.X}:{_position.Y}:{_direction.Value}";
    }

    private Position Move(Position currentPosition, Direction direction)
    {
        var nextPosition = _grid.NextPosition(currentPosition, direction);

        if (nextPosition is not null)
            return nextPosition;

        _hasFacedAnObstacle = true;
        return currentPosition;
    }

    private void TurnLeft()
    {
        var rotatedDirection = MatchingDirectionOf(_direction.Left);
        _direction = rotatedDirection;
    }

    private void TurnRight()
    {
        var rotatedDirection = MatchingDirectionOf(_direction.Right);
        _direction = rotatedDirection;
    }


    private Direction MatchingDirectionOf(string direction)
    {
        return DirectionStore.MatchingDirection(direction);
    }
}