using GitDemo;

int number = 6;

Console.WriteLine(IsOdd(number));


Console.WriteLine(IsEven(number));

Calculator calc = new Calculator();

Console.WriteLine($"The sum of 5 and 4 is {calc.Sum(4, 5)}");

bool IsEven(int num) => num % 2 == 0;

bool IsOdd(int num) => num % 2 != 0;
