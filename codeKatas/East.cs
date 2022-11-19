namespace codeKatas;

class East : Direction
{
    public East() : base("E", new South(), new North())
    {
    }
}