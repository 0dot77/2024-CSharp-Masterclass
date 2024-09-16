Console.WriteLine("Hello!");
Console.WriteLine("What do you want to do?");
Console.WriteLine("[S]ee all TODOs");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");

var userChoice = Console.ReadLine();

switch(userChoice)
{
    case "s":
    case "S":
        PrintSelectedOption("See all TODOs");
        break;
}

if (userChoice == "S")
{
    PrintSelectedOption("See all TODOs");
}

void PrintSelectedOption(string selectedOption)
{
    Console.WriteLine("Selected Option: " + selectedOption);
}
