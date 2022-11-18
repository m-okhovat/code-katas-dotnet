namespace codeKatas;

static class  DirectionStore
{
    public static List<Direction> Directions = new List<Direction>()
    {
        new Direction("N", "E"),
        new Direction("E", "S"),
        new Direction("S", "W"),
        new Direction("W", "N"),
    };
}