namespace codeKatas;

public class Rover
{
    private int _xPosition;
    private int _yPosition;
    private string _direction = "N";

    public string Execute(string command)
    {
        var towardsX = false;

        var commandChars = command.ToCharArray();
        var trackCounter = 0;
        for (var i = 0; i <= command.Length - 1; i++)
        {
            var currentChar = commandChars[i];
            switch (currentChar)
            {
                case 'R':
                    if (_direction.Equals("N"))
                        _direction = "E";
                    else if (_direction.Equals("E"))
                        _direction = "S";
                    else if (_direction.Equals("S"))
                        _direction = "W";
                    else if (_direction.Equals("W"))
                        _direction = "N";
                    towardsX = !towardsX;
                    break;
                case 'L':
                    if (_direction.Equals("E"))
                        _direction = "N";
                    else if (_direction.Equals("N"))
                        _direction = "W";
                    else if (_direction.Equals("W"))
                        _direction = "S";
                    else if (_direction.Equals("S"))
                        _direction = "E";
                    towardsX = !towardsX;
                    break;
                case 'M':
                    if (towardsX)
                    {
                        if (_direction.Equals("E"))
                            _xPosition++;
                        else if (_direction.Equals("W"))
                            _xPosition--;
                    }

                    else
                    {
                        if (_direction.Equals("N"))
                            _yPosition++;
                        else if (_direction.Equals("S"))
                            _yPosition--;
                    }

                    break;
            }
        }

        return $"{_xPosition}:{_yPosition}:{_direction}";
    }
}