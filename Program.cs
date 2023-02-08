int number = 6;

Console.WriteLine(IsOdd(number));


Console.WriteLine(IsEven(number));

bool IsEven(int num) => num % 2 == 0;

bool IsOdd(int num) => num % 2 != 0;
