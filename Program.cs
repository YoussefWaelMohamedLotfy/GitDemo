int number = 5;
bool isOdd = number % 2 != 0;

Console.WriteLine(isOdd);


Console.WriteLine(IsEven(number));

bool IsEven(int num)
{
    return num % 2 == 0;
}
