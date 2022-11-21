using codeKatas.Directions;

namespace codeKatas;

public class MarsRover2
{
    private Direction _direction = new North();
    private short _yAxis = 0;
    private short _xAxis = 0;
    private const char MoveCommand = 'M';
    private const char TurnLeftCommand = 'L';
    private const char TurnRightCommand = 'R';

    public string Execute(string command)
    {
        foreach (var item in command.ToCharArray())
        {
            if (item.Equals(MoveCommand))
            {
                switch (_direction)
                {
                    case North:
                        _yAxis++;
                        break;
                    case East:
                        _xAxis++;
                        break;
                    case West:
                        _xAxis--;
                        break;
                    case South:
                        _yAxis--;
                        break;
                }
            }

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
        }

        return $"{_xAxis}:{_yAxis}:{_direction.Value}";
    }

    private Direction GetCurrentDirection(string direction)
    {
        return DirectionStore.MatchingDirection(direction);
    }
}