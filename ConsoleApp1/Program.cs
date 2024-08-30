using System.Runtime.Serialization;

Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.BackgroundColor = ConsoleColor.Yellow;

Console.Clear();String name;

Console.WriteLine("Write your name: ");

name = Console.ReadLine();

String favoriteanimal;

Console.WriteLine("Write your favorite animal: ");

favoriteanimal = Console.ReadLine();

String favoritecar;

Console.WriteLine("Write your favorite car: ");

favoritecar = Console.ReadLine();

String favoritefood;

Console.WriteLine("Write your favorite food: ");

favoritefood = Console.ReadLine();

String favoriteperson;

Console.WriteLine("Write your favorite person: ");

favoriteperson = Console.ReadLine();

Console.WriteLine($"Once upon a time there was this person named {name}. {name} was driving a {favoritecar} and was speeding then he saw {favoriteanimal}.");

Console.WriteLine("Do you want to pull over?");
string pullover = Console.ReadLine();

if (pullover == "yes")
{
Console.WriteLine($"{name} pulled over and pulled out a glock 19 with a switch.");
}
else
{
Console.WriteLine($"{name} kept driving and lost control of the {favoritecar}, {name} crashed and died. THE END!");
Environment.Exit(1);
}
Console.WriteLine($"Do you want to shoot the {favoriteanimal}?");
string shoot = Console.ReadLine();

if (shoot == "yes")
{
Console.WriteLine($"{name} pulled over and pulled out a glock 19 with a switch. {name} shot {favoriteanimal} in the anckle and watched slowly suffer ultil it died, then {name} stuffed the dead courps of the {favoriteanimal} and brought it home.");
}
else
{
Console.WriteLine($"The {favoriteanimal} bit your leg and left {name} slowly suffring ultil {name} died. THE END!");
Environment.Exit(1);
}
Console.WriteLine($"Do you want to eat {favoriteanimal}");
string eat = Console.ReadLine();

if (eat == "yes")
{
Console.WriteLine($"{name} Then {name} used the meat and cooked {favoritefood} and ate the food and got poisend and died! THE END!");
Environment.Exit(1);
}
else
{
Console.WriteLine($"{name} used the blood of the {favoriteanimal} to paint a picture of the {favoriteanimal}. {name} saw {favoriteperson} on the street.");    
}
Console.WriteLine($"Do you want to smash the painting on {favoriteperson}?");
string smash = Console.ReadLine();
if (smash == "yes")
{ Console.WriteLine($"smashed the drawing on {favoriteperson}s head and the placed the body of {favoriteperson} in the trunk of the {favoritecar}. THE END!"); 
}
    else
    {Console.WriteLine($"{favoriteperson} started stabbing you with a huge machete and you died becuase you owed {favoriteperson} some money. THE END!");
    }
    if (smash == "on my self")
    {Console.WriteLine("Congrats you found the secret ending! BTW killed your self! ");
    }


