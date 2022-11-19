namespace codeKatas;

static class DirectionStore
{
    public static List<Direction> Directions = new List<Direction>()
    {
        new North(),
        new East(),
        new South(),
        new West(),
    };

    public static Direction CurrentDirection(Direction direction)
    {
        return Directions
            .Find(x => x.Value.Equals(direction.Value));
    }
}