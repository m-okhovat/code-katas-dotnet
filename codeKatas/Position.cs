namespace codeKatas;

public class Position
{
    public short X { get; private set; }
    public short Y { get; private set; }

    public Position(short x, short y)
    {
        X = x;
        Y = y;
    }
}