using FizzBuzz;
using FizzBuzz.Impl;
using Console = FizzBuzz.Impl.Console;

IConsole console = new Console();

int rest = 4 % 3;
console.WriteLine("Ein Rest wird mit '%' gerechnet: 4 durch 3 gibt Rest " + rest);

return;

console.WriteLine("\n--------------------------***--------------------------\n");

console.WriteLine("Ein Kreislauf (loop) wird mit 'while' gemacht: ");
int n = 1;
int max = 8;
while (n < max)
{
    console.WriteLine("Wir sind zum " + n + "-ten mal im loop.");
    n = n + 1;
}

console.WriteLine("\n--------------------------***--------------------------\n");


FizzBuzzer fizzBuzzer = new FizzBuzzer(console);
fizzBuzzer.FizzBuzz(1);