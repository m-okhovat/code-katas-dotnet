namespace codeKatas;

class South : Direction
{
    public South() : base("S", new West(), new East())
    {
    }
}