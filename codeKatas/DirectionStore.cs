namespace codeKatas;

static class  DirectionStore
{
    public static List<Direction> Directions = new List<Direction>()
    {
        new Direction("N", "E", "W"),
        new Direction("E", "S", "N"),
        new Direction("S", "W", "E"),
        new Direction("W", "N", "S"),
    };
}