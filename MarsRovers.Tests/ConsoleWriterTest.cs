using codeKatas;
using FluentAssertions;

namespace MarsRovers.Tests;

public class ConsoleWriterTest
{
    [Fact]
    public void Write_on_console()
    {
        var consoleWriter = new ConsoleWriter();

        var writer = new StringWriter();
        Console.SetOut(writer);
        
        consoleWriter.Write();

        var s = writer.ToString();
        s.Should().Be("Hello");
    }
}