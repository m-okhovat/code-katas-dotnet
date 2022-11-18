namespace codeKatas;

class Direction
{
    public string Current { get; private set; }
    public string Right { get; private set; }

    public Direction(string current, string right) 
    {
        Current = current;
        Right = right;
    }
}