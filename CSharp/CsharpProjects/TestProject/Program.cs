int total = 0;
bool found = true;
int[] numbers = {4, 8, 15, 16, 23, 42};

foreach (int number in numbers)
{
    total += number;

    if (number == 42)
        found = true;
}

if (found)
    Console.WriteLine("Set contains 42");

Console.WriteLine($"Total: {total}");

// knowledge check 1
int num1 = 1;

if (num1 > 0)
{
    int num2 = 8;
    num1 = num1 + num2;
}

Console.WriteLine(num1);

// knowledge check 2
int value1 = 5;

if (value1 > 0)
{
    int value2 = 6;
}
value1 = value1 + value2;
Console.WriteLine(value1);