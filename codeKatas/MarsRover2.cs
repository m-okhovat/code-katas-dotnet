using codeKatas.Directions;

namespace codeKatas;

public class MarsRover2
{
    private Direction _direction = new North();
    private int _yAxis = 0;
    private int _xAxis = 0;
    private const char MoveCommand = 'M';
    private const char TurnLeftCommand = 'L';
    private const char TurnRightCommand = 'R';

    public string Execute(string command)
    {
        foreach (var item in command.ToCharArray())
        {
            if (item.Equals(TurnRightCommand))
            {
                var rotatedDirection = GetCurrentDirection(_direction.Right);
                _direction = rotatedDirection;
            }
            else
            {
                if (item.Equals(TurnLeftCommand))
                {
                    var rotatedDirection = GetCurrentDirection(_direction.Left);
                    _direction = rotatedDirection;
                }
            }
            
            if (item.Equals(MoveCommand))
            {
                switch (_direction)
                {
                    case North:
                        _yAxis =  (_yAxis % 10) + 1;
                        break;
                    case East:
                        _xAxis= (_xAxis % 10) +1;
                        break;
                    case West:
                        _xAxis = _xAxis == 0? 9  : _xAxis - 1;
                        break;
                    case South:
                        _yAxis = _yAxis == 0 ? 9 : _yAxis - 1;
                        break;
                }
            }

          
        }

        return $"{_xAxis}:{_yAxis}:{_direction.Value}";
    }

    private Direction GetCurrentDirection(string direction)
    {
        return DirectionStore.MatchingDirection(direction);
    }
}