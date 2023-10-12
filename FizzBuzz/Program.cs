using FizzBuzz;
using FizzBuzz.Impl;

var console = new ConsoleWrapper();
var fizzBuzzer = new FizzBuzzer(console);

fizzBuzzer.FizzBuzz(1);