var index = 1;
Console.WriteLine(@$"The following items are available:
{index ++} - Rope
{index ++} - Torches
{index ++} - Climbing Equipment
{index ++} - Clean Water
{index ++} - Machete
{index ++} - Canoe
{index ++} - Food Supplies");

Console.Write(" What is your name? ");
string name =  Console.ReadLine().ToLower();


Console.Write("What number do you want to see the price of? ");
int itemChoice = Convert.ToInt32(Console.ReadLine());


string item = itemChoice switch
{
    1 => "Rope",
    2 => "Torches",
    3 => "Climbing Equipment",
    4 => "Clean Water",
    5 => "Machete",
    6 => "Canoe",
    7 => "Food Supplies"
};

int price = item switch
{
    "Rope" => 10,
    "Torches" => 15,
    "Climbing Equipment" => 25,
    "Clean Water" => 1,
    "Machete" => 20,
    "Canoe" => 200,
    "Food Supplies" => 1
};

if (name == "dale") price /= 2;

switch (itemChoice)
{
    case 1:
        Console.WriteLine($"{item} cost {price} gold.");
        break;
    case 2:
        Console.WriteLine($"{item} cost {price} gold.");
        break;
    case 3:
        Console.WriteLine($"{item} cost {price} gold.");
        break;
    case 4:
        Console.WriteLine($"{item} cost {price} gold.");
        break;
    case 5:
        Console.WriteLine($"{item} cost {price} gold.");
        break;
    case 6:
        Console.WriteLine($"{item} cost {price} gold.");
        break;
    case 7:
        Console.WriteLine($"{item} cost {price} gold.");
        break;
    default:
        Console.WriteLine($"{item} cost {price} gold.");
        break;
}