using FizzBuzz.Impl;
using FluentAssertions;
using Xunit;

namespace FizzBuzz;

public class FizzBuzzerTest
{
    private readonly FizzBuzzer _fizzBuzzer;
    private readonly ConsoleWrapper _consoleWrapper;

    public FizzBuzzerTest()
    {
        _consoleWrapper = new ConsoleWrapper();
        _fizzBuzzer = new FizzBuzzer(_consoleWrapper);
    }

    [Fact]
    public void FizzBuzz_ShouldPrintNumbers()
    {
        _fizzBuzzer.FizzBuzz(2);

        _consoleWrapper.ReadAll().Should().Be("""
                                              1
                                              2
                                              """);
    }

    [Fact]
    public void FizzBuzz_ShouldPrintFizzForThree()
    {
        _fizzBuzzer.FizzBuzz(3);

        _consoleWrapper.ReadAll().Should().Be("""
                                              1
                                              2
                                              Fizz
                                              """);
    }

    [Fact]
    public void FizzBuzz_ShouldPrintBuzzForFive()
    {
        _fizzBuzzer.FizzBuzz(5);

        _consoleWrapper.ReadAll().Should().Be("""
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

        _consoleWrapper.ReadAll().Should().Be("""
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