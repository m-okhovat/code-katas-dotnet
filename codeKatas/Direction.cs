namespace codeKatas;

class Direction
{
    public string Value { get; private set; }
    public Direction Right { get; private set; }
    public Direction Left { get; private set; }

    public Direction(string value, Direction right, Direction left)
    {
        Value = value;
        Right = right;
        Left = left;
    }

    

}