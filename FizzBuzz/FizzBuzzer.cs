using FizzBuzz.Impl;

namespace FizzBuzz;

public class FizzBuzzer
{
    private readonly IConsoleWrapper _console;

    public FizzBuzzer(IConsoleWrapper console)
    {
        _console = console;
    }

    public void FizzBuzz(int number)
    {
        throw new NotImplementedException();
    }
}