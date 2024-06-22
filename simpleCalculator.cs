Console.Write("enter 1st number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("enter 2nd number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int index = 1;

Console.WriteLine(@$"which arithmetic operator would you like to use?
{index++} - Addition
{index++} - Subtraction
{index++} - Multiplication
{index++} - Division");

int userChoice = Convert.ToInt32(Console.ReadLine());

Console.Clear();

switch (userChoice)
{
    case 1:
        int addAnswer = firstNumber + secondNumber;
        Console.WriteLine($" the answer for your choice is {addAnswer}");
        break;
    case 2:
        int subAnswer = firstNumber - secondNumber;
        Console.WriteLine($" the answer for your choice is {subAnswer}");
        break;
    case 3:
        int multAnswer = firstNumber * secondNumber;
        Console.WriteLine($" the answer for your choice is {multAnswer}");
        break;
    case 4:
        if (secondNumber == 0)
        {
            Console.WriteLine("no division by 0!");
        }
        else
        {
            int divAnswer = firstNumber / secondNumber;
            Console.WriteLine($"the answer is {divAnswer}");
        }
        break;
    default:
        Console.WriteLine("that choice is not recognized.");
        break;
