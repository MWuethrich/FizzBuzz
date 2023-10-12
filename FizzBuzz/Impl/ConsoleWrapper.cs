using System.Text;

namespace FizzBuzz.Impl;

public class ConsoleWrapper : IConsoleWrapper
{
    private readonly StringBuilder _stringBuilder = new StringBuilder();

    public void WriteLine(string line)
    {
        _stringBuilder.AppendLine(line);
        Console.WriteLine(line);
    }

    public void Write(string value)
    {
        _stringBuilder.Append(value);
        Console.Write(value);
    }

    public string ReadAll()
    {
        return _stringBuilder.ToString().Trim();
    }
}