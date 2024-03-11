Console.WriteLine("Hello!");
Console.WriteLine("What do you want to do?");
Console.WriteLine("[S]ee all TODOs");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");

var userChoice = Console.ReadLine();

if (userChoice == "S")
{
    PrintSelectedOption(" See all TODOS");
}
else if (userChoice == "A")
{
    PrintSelectedOption(" Add a TODO");
}
else if (userChoice == "R")
{
    PrintSelectedOption(" Remove a TODO");
}
else if(userChoice == "E")
{
    PrintSelectedOption(" Exit ");
}



Console.ReadKey();

void PrintSelectedOption(string selectedOption)
{
    Console.WriteLine("Selected Option : " + selectedOption);
}