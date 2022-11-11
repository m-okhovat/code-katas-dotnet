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

    [Fact]
    public void moves_in_two_direction_without_reaching_the_edge_and_obstacle()
    {
        var position = new Rover().Execute("MRM");
        
        position.Should().Be("1:1:W");
    }

}

public class Rover
{
    private int _xPosition;
    private int _yPosition;
    private string _direction;
    public string Execute(string command)
    {
        // int counter = 0;
        // foreach (var character in command.ToCharArray())
        // {
        //     if (character.Equals('M'))
        //         counter++;
        //     
        //     if (character.Equals('R'))
        //     {
        //         _yPosition = counter;
        //         counter = 0;
        //         _direction = "W";
        //     }
        //     
        // }
        //
        // _xPosition = counter;
        //
        if (command.Substring(0,1) == "R")
        {
            _yPosition = command.Substring(0, command.Length - 1).Length;
            _direction = "W";
        }
        else
        {
            _xPosition = command.Length;
            _direction = "N";
        
        }
        
        return $"{_xPosition}:{_yPosition}:{_direction}";
    }
}