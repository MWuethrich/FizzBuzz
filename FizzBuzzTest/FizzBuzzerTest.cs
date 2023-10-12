using FizzBuzz.Impl;
using FluentAssertions;
using Xunit;
using Console = FizzBuzz.Impl.Console;

namespace FizzBuzz;

public class FizzBuzzerTest
{
    private readonly FizzBuzzer _fizzBuzzer;
    private readonly Console _console;

    public FizzBuzzerTest()
    {
        _console = new Console();
        _fizzBuzzer = new FizzBuzzer(_console);
    }

    [Fact]
    public void FizzBuzz_ShouldPrintNumbers()
    {
        _fizzBuzzer.FizzBuzz(2);

        _console.ReadAll().Should().Be("""
                                              1
                                              2
                                              """);
    }

    [Fact]
    public void FizzBuzz_ShouldPrintFizzForThree()
    {
        _fizzBuzzer.FizzBuzz(3);

        _console.ReadAll().Should().Be("""
                                              1
                                              2
                                              Fizz
                                              """);
    }

    [Fact]
    public void FizzBuzz_ShouldPrintBuzzForFive()
    {
        _fizzBuzzer.FizzBuzz(5);

        _console.ReadAll().Should().Be("""
                                              1
                                              2
                                              Fizz
                                              4
                                              Buzz
                                              """);
    }

    [Fact]
    public void FizzBuzz_ShouldPrintFizzBuzzForFifteen()
    {
        _fizzBuzzer.FizzBuzz(15);

        _console.ReadAll().Should().Be("""
                                              1
                                              2
                                              Fizz
                                              4
                                              Buzz
                                              Fizz
                                              7
                                              8
                                              Fizz
                                              Buzz
                                              11
                                              Fizz
                                              13
                                              14
                                              FizzBuzz
                                              """);
    }
}