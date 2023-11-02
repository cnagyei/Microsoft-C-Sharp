bool flag = true;
int value = 0;
if (flag)
{
    value = 10;
    Console.WriteLine($"Inside of code block: {value}");
}
Console.WriteLine($"Outside of code block: {value}");

// Knowledge check
int num1 = 5;

if (num1 > 0)
{
    int num2 = 6;
    num1 = num1 + num2;
}
Console.WriteLine(num1);