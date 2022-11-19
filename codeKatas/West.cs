namespace codeKatas;

class West : Direction
{
    public West() : base("W", new North(), new South())
    {
    }
}