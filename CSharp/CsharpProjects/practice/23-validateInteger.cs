string? readLine;
bool validNumber = false;
int numericValue = 0;

Console.WriteLine("Enter an integer value between 5 and 10");
do
{
    readLine = Console.ReadLine();
    validNumber = int.TryParse(readLine, out numericValue);
    if (validNumber == true)
    {
        if (numericValue <= 5 || numericValue >= 10)
            Console.WriteLine($"You entered {numericValue}. Please enter a number between 5 and 10");
    }
    else
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
} while (validNumber == false || (numericValue <= 5 || numericValue >= 10));

Console.WriteLine($"Your input value {numericValue} has been accepted");