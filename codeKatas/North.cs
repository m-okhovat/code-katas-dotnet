namespace codeKatas;

class North : Direction
{
    public North() : base("N", new East(), new West())
    {
    }
}