using codeKatas.Directions;

namespace codeKatas;

public class MarsRover2
{
    private readonly Grid _grid;
    private Direction _direction = new North();
    private int _yAxis = 0;
    private int _xAxis = 0;
    private bool _doesFacedAnObstacle = false;
    
    public MarsRover2(Grid grid)
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
                switch (_direction)
                {
                    case North:
                        _yAxis = WrapAroundWhenReachMaximum(_yAxis);
                        break;
                    case East:
                        _xAxis = WrapAroundWhenReachMaximum(_xAxis);
                        break;
                    case West:
                        _xAxis = WrapAroundWhenReachMinimum(_xAxis);
                        break;
                    case South:
                        _yAxis = WrapAroundWhenReachMinimum(_yAxis);
                        break;
                }
            }
        }

        if (!_doesFacedAnObstacle)
            return $"{_xAxis}:{_yAxis}:{_direction.Value}";
        
        _doesFacedAnObstacle = false;
        return $"O:{_xAxis}:{_yAxis}:{_direction.Value}";
    }

    private void TurnLeft()
    {
        var rotatedDirection = GetCurrentDirection(_direction.Left);
        _direction = rotatedDirection;
    }

    private void TurnRight()
    {
        var rotatedDirection = GetCurrentDirection(_direction.Right);
        _direction = rotatedDirection;
    }

    private int WrapAroundWhenReachMaximum(int yAxis)
    {
        var newPosition = (yAxis % MaxDistance) + 1;
        if (_grid._obstacles.All(a => a.Y != newPosition && a.X == _xAxis))
            return newPosition;
        _doesFacedAnObstacle = true;
        return _yAxis;
    }

    private int WrapAroundWhenReachMinimum(int xAxis)
    {
        return xAxis == MinDistance ? 9 : xAxis - 1;
    }

    private Direction GetCurrentDirection(string direction)
    {
        return DirectionStore.MatchingDirection(direction);
    }
}