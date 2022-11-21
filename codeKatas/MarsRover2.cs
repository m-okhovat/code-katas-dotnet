using codeKatas.Directions;

namespace codeKatas;

public class MarsRover2
{
    private Direction _direction = new North();
    private string _yAxis = "0";
    private short _yCounter = 0;

    public string Execute(string command)
    {
        foreach (var item in command.ToCharArray())
        {
            if (item.Equals('M'))
            {
                _yCounter++;
                _yAxis = _yCounter.ToString();
            }
            if (item.Equals('R'))
            {
                var rotatedDirection = GetCurrentDirection( _direction.Right);
                _direction = rotatedDirection;
            }
            else if (item.Equals('L'))
            {
                var rotatedDirection = GetCurrentDirection( _direction.Left);
                _direction = rotatedDirection;
            }
        }

        return $"0:{_yAxis}:{_direction.Value}";
    }

    private Direction GetCurrentDirection(string direction)
    {
        return DirectionStore.MatchingDirection(direction);
    }
}