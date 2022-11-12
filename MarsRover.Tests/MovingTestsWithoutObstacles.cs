using FluentAssertions;

namespace MarsRover.Tests;

public class MovingTestsWithoutObstacles
{
    [Fact]
    public void moves_one_direction_towards_north()
    {
        var rover = new Rover();

        string roverPosition = rover.Execute("MMMM");

        roverPosition.Should().Be("0:4:N");
    }

    [Fact]
    public void moves_one_direction_towards_west()
    {
        var rover = new Rover();

        var position = rover.Execute("RMM");

        position.Should().Be("2:0:E");
    }

    [Fact]
    public void moves_north_and_then_turns_right()
    {
        var position = new Rover().Execute("MRMM");

        position.Should().Be("2:1:E");
    }

    [Fact]
    public void moves_right_then_turns_left()
    {
        string position  = new Rover().Execute("RMMMLMM");

        position.Should().Be("3:2:N");
    }

    [Fact]
    public void moves_right_then_turns_left_then_turns_left()
    {
        string position = new Rover().Execute("RMLMLM");

        position.Should().Be("0:1:W");
    }

    // [Fact]
    // public void moves_toward_north_then_turns_right_then_turns_right()
    // {
    //     var position = new Rover().Execute("MMMRMRM");
    //
    //     position.Should().Be("2:1:S");
    //
    // }
}

public class Rover
{
    private int _xPosition;
    private int _yPosition;
    private string _direction = "N";

    public string Execute(string command)
    {
        var towardsX = false;

        var commandChars = command.ToCharArray();
        var trackCounter = 0;
        for (var i = 0; i <= command.Length - 1; i++)
        {
            var currentChar = commandChars[i];
            switch (currentChar)
            {
                case 'R':
                    _direction = "E";
                    towardsX = !towardsX;
                    break;
                case 'L':
                    if (_direction.Equals("E"))
                        _direction = "N";

                    else if (_direction.Equals("N"))
                        _direction = "W";  
                    towardsX = !towardsX;
                    break;
                case 'M':
                    if (towardsX)
                    {
                        if (_direction.Equals("E"))
                            _xPosition++;
                        if (_direction.Equals("W"))
                            _xPosition--;
                    }

                    else
                        _yPosition++;
                    
                    break;
            }
        }

        return $"{_xPosition}:{_yPosition}:{_direction}";
    }
}