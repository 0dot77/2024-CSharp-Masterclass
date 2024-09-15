Console.WriteLine("Hello!");
Console.WriteLine("What do you want to do?");
Console.WriteLine("[S]ee all TODOs");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");

var userChoice = Console.ReadLine();

if(userChoice == "ABC")
{
    Console.WriteLine("User typed ABC");
}
else
{
    Console.WriteLine("User did not typed ABC");
}

Console.ReadKey();


