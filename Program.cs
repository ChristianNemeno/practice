// See https://aka.ms/new-console-template for more information
bool EvenChecker(int a)
{
    return a % 2 == 0;
}

Console.Write("Enter a number ");
string? input = Console.ReadLine();

if (int.TryParse(input, out int number))
{
    if (EvenChecker(number))
    {
        Console.WriteLine($"{number} is an even number.");
    }
    else
    {
        Console.WriteLine($"{number} is not an even number.");
    }
}



