namespace codeKatas;

public class MarsRover2
{
    private string _direction = "N";

    public string Execute(string command)
    {
        foreach (var item in command.ToCharArray())
        {
            if (_direction.Equals("N"))
                _direction = "E";
            else if (_direction.Equals("E"))
            {
                _direction = "S";
            }
        }


        return $"0:0:{_direction}";
    }
}