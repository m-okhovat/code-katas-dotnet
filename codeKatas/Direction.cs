namespace codeKatas;

class Direction
{
    public string Value { get; private set; }
    
    public string Right { get; private set; }
    public string Left { get; private set; }

    public Direction(string value, string right, string left)
    {
        Value = value;
        Right = right;
        Left = left;
    }
}