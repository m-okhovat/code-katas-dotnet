using codeKatas.Directions;

namespace codeKatas;

public class MarsRover2
{
    private Direction _direction = new North();
    private short _yAxis = 0;
    private short _xAxis = 0;

    public string Execute(string command)
    {
        foreach (var item in command.ToCharArray())
        {
            if (item.Equals('M'))
            {
                if (_direction is North)
                {
                    _yAxis++;
                }

                if (_direction is East)
                {
                    _xAxis++;
                }

                if (_direction is West)
                    _xAxis--;

                if (_direction is South)
                    _yAxis--;
            }

            if (item.Equals('R'))
            {
                var rotatedDirection = GetCurrentDirection(_direction.Right);
                _direction = rotatedDirection;
            }
            else if (item.Equals('L'))
            {
                var rotatedDirection = GetCurrentDirection(_direction.Left);
                _direction = rotatedDirection;
            }
        }

        return $"{_xAxis}:{_yAxis}:{_direction.Value}";
    }

    private Direction GetCurrentDirection(string direction)
    {
        return DirectionStore.MatchingDirection(direction);
    }
}