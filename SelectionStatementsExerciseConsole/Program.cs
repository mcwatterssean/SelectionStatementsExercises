

var r = 67;

Console.WriteLine("Guess my favorite number(from 0-100)");
var userInput= int.Parse(Console.ReadLine());

if (userInput < r)
{
    Console.WriteLine("TOO LOW!");
}
else if (userInput >r)
{
    Console.WriteLine("TOO HIGH!");
}
else if (userInput == r)
{
    Console.WriteLine("CONGRATULATIONS, YOU WIN!");
}
else
{
    Console.WriteLine("Nevermind");
}

Console.WriteLine("What is your favorite subject(please capitalize your answer)");
string userSubject = Console.ReadLine();

switch (userSubject)
{
    case "Math":
        Console.WriteLine("Welcome to Math class");
        break;
    case "English":
        Console.WriteLine("Welcome to English class");
        break;
    case "Gym":
        Console.WriteLine("GYM IS NOT A SUBJECT!");
        break;
    case "History":
        Console.WriteLine("Welcome to History class");
        break;
    default:
        Console.WriteLine("We have very limited options here, and unfortunately, that is not one");
        break;
}