int numberSelected;

do
{
    Console.Write("User 1, enter a number: ");
    numberSelected = Convert.ToInt32(Console.ReadLine());
}
while (numberSelected < 0 || numberSelected > 100);

Console.Clear();

Console.Write("User 2, guess the number: ");

while (true)
{
    Console.Write("What is your next guess? ");
    int numberGuess = Convert.ToInt32(Console.ReadLine());

    if (numberGuess > numberSelected) Console.WriteLine($"{numberGuess} is too high.");
    else if (numberGuess < numberSelected) Console.WriteLine($"{numberGuess} is too low.");
    else break;
}

Console.WriteLine("You guessed the number!");