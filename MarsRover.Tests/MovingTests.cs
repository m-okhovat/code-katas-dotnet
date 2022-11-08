using FluentAssertions;

namespace MarsRover.Tests;

public class MovingTests
{
    [Fact]
    public void Rover_moves_by_command()
    {
        var rover = new Rover();

        string roverPosition =  rover.Execute("MMMM");

        roverPosition.Should().Be("4:0:N");
    }
}

public class Rover
{
    public string Execute(string s)
    {
        var counter = s.Length;
        return $"{counter}:0:N";
                
        if (s.Equals("MM"))
            return "2:0:N";
        
        return "1:0:N";
    }
}