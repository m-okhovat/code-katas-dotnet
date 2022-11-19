namespace codeKatas;

public class MarsRover2
{
    private Direction _direction = new North();

    public string Execute(string command)
    {
        foreach (var item in command.ToCharArray())
        {
            if (item.Equals('R'))
            {
                var currentDirection = CurrentDirection();
                // _direction = _direction.Right;
            }
            else if (item.Equals('L'))
            {
                var currentDirection = CurrentDirection();
                // _direction = _direction.Left;
            }
        }

        return $"0:0:{_direction.Value}";
    }

    private Direction? CurrentDirection()
    {
        return DirectionStore.CurrentDirection(_direction);
    }
}