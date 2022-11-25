using codeKatas.MarsRovers.Directions;

namespace codeKatas.MarsRovers;

static class DirectionStore
{
    public static List<Direction> Directions = new List<Direction>()
    {
        new North(),
        new East(),
        new South(),
        new West(),
    };

    public static Direction MatchingDirection(string direction)
    {
        return Directions
            .Find(x => x.Value.Equals(direction));
    }
}