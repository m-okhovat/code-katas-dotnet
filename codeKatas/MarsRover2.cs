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
                        _yAxis = MoveUp(_yAxis);
                        break;
                    case East:
                        _xAxis = MoveRight(_xAxis);
                        break;
                    case West:
                        _xAxis = MoveLeft(_xAxis);
                        break;
                    case South:
                        _yAxis = MoveDown(_yAxis);
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

    private int MoveUp(int current)
    {
        var newPosition = (current % MaxDistance) + 1;
        
        if (!_grid._obstacles.Any(a => a.Y == newPosition && a.X == _xAxis))
            return newPosition;
        
        _doesFacedAnObstacle = true;
        return _yAxis;
    }

    private int MoveRight(int current)
    {
        var newPosition = (current % MaxDistance) + 1;
        
        if (!_grid._obstacles.Any(a => a.X == newPosition && a.Y == _yAxis))
            return newPosition;
        
        _doesFacedAnObstacle = true;
        return _xAxis;
    }
    private int MoveDown(int current)
    {
        var newPosition = current == MinDistance ? 9 : current - 1;

        if (!_grid._obstacles.Any(a => a.Y == newPosition && a.X == _xAxis))
            return newPosition;
        
        _doesFacedAnObstacle = true;
        return current;
        
    }
    
    private int MoveLeft(int current)
    {
        var newPosition = current == MinDistance ? 9 : current - 1;

        if (!_grid._obstacles.Any(a => a.Y == _yAxis && a.X == newPosition))
            return newPosition;
        
        _doesFacedAnObstacle = true;
        return current;
    }


    private Direction GetCurrentDirection(string direction)
    {
        return DirectionStore.MatchingDirection(direction);
    }
}