namespace codeKatas;

class Direction
{
    public string Current { get; private set; }
    public string Right { get; private set; }
    public string Left { get; private set; }

    public Direction(string current, string right, string left) 
    {
        Current = current;
        Right = right;
        Left = left;
    }
}