using System.Text;

namespace FizzBuzz.Impl;

public class Console : IConsole
{
    private readonly StringBuilder _stringBuilder = new StringBuilder();

    public void WriteLine(string line)
    {
        _stringBuilder.AppendLine(line);
        System.Console.WriteLine(line);
    }

    public void Write(string value)
    {
        _stringBuilder.Append(value);
        System.Console.Write(value);
    }

    public string ReadAll()
    {
        return _stringBuilder.ToString().Trim();
    }
}