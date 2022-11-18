namespace codeKatas;

public class MarsRover2
{
    private string _direction = "N";

    public string Execute(string command)
    {
        foreach (var item in command.ToCharArray())
        {

           var currentDirection =  DirectionStore
               .Directions
               .Find(x => x.Current.Equals(_direction));
           _direction = currentDirection.Right;
            
        }

        return $"0:0:{_direction}";
    }

    
     
     
}