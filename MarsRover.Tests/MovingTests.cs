using FluentAssertions;

namespace MarsRover.Tests;

public class MovingTests
{
    [Fact]
    public void moves_one_direction_towards_north()
    {
        var rover = new Rover();

        string roverPosition = rover.Execute("MMMM");

        roverPosition.Should().Be("4:0:N");
    }

    [Fact]
    public void moves_one_direction_towards_west()
    {
        var rover = new Rover();

        var position = rover.Execute("RMM");

        position.Should().Be("0:2:W");
    }
    
    
}

public class Rover
{
    
    public string Execute(string s)
    {
        var substringLenght = s.Substring(0, s.Length - 1).Length;
        if (s.Substring(0,1) == "R")
        {
            return $"0:{substringLenght}:W";
        }
        var counter = s.Length;
        return $"{counter}:0:N";
    }
}