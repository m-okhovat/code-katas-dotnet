namespace codeKatas;

public class Grid
{
    public List<Position> _obstacles { get; private set; } = new List<Position>();

    public Grid(List<Position> obstacles)
    {
        _obstacles = obstacles;
    }
}