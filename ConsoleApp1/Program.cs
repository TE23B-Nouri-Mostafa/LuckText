using System.Runtime.Serialization;

Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.BackgroundColor = ConsoleColor.Yellow;

Console.Clear(); String name;   

Console.WriteLine("Write your name: ");

name = Console.ReadLine();

while (name == "")
{
    Console.WriteLine("please write your name or i will kill you");
    name = Console.ReadLine();
}


String favoriteanimal;

Console.WriteLine("Write your favorite animal: ");

favoriteanimal = Console.ReadLine();
while (favoriteanimal == "")
{
    Console.WriteLine("please write your favoriteanimal or i will kill you");
    favoriteanimal = Console.ReadLine();
}

String favoritecar;

Console.WriteLine("Write your favorite car: ");

favoritecar = Console.ReadLine();
while (favoritecar == "")
{
    Console.WriteLine("please write your favoritecar or i will kill you");
    favoritecar = Console.ReadLine();
}

String favoritefood;

Console.WriteLine("Write your favorite food: ");

favoritefood = Console.ReadLine();
while (favoritefood == "")
{
    Console.WriteLine("please write your favoritefood or i will kill you");
    favoritefood = Console.ReadLine();
}

String favoriteperson;

Console.WriteLine("Write your favorite person: ");

favoriteperson = Console.ReadLine();
while (favoriteperson == "")
{
    Console.WriteLine("please write your favoriteperson or i will kill you");
    Console.ReadLine();
}


Console.WriteLine($"Once upon a time there was this person named {name}. {name} was driving a {favoritecar} and was speeding then he saw {favoriteanimal}.");

Console.WriteLine("Do you want to pull over?");
string pullover = Console.ReadLine().ToLower();

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
string shoot = Console.ReadLine().ToLower();

if (shoot == "yes")
{
    Console.WriteLine($"{name} pulled over and pulled out a glock 19 with a switch. {name} shot {favoriteanimal} in the anckle and watched slowly suffer ultil it died, then {name} stuffed the dead courps of the {favoriteanimal} and brought it home.");
}
else
{
    Console.WriteLine($"The {favoriteanimal} bit your leg and left {name} slowly suffring ultil {name} died. THE END!");
    Environment.Exit(1);
}
Console.WriteLine($"Do you want to eat {favoriteanimal}".ToLower());
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
Console.WriteLine($"Do you want to smash the painting on {favoriteperson}?".ToLower());
string smash = Console.ReadLine();
if (smash == "yes")
{
    Console.WriteLine($"smashed the drawing on {favoriteperson}s head and the placed the body of {favoriteperson} in the trunk of the {favoritecar}. THE END!");
}
else if (smash == "no on my self" || smash == "on my self")
{
    Console.WriteLine("Congrats you found the secret ending! BTW killed your self!"+"""
====+##*++========+##*++++=======+#*+=++*+=======##**++===------=*#*++=======---=**+==============*#
====+##**+=====-==+##*+++=====-==+#*+=++**+=====+#%#**+====-----=*#++++===--=---=**=========--===+*#
====+##**+====--==+##**++====--==+#*+=++**+++++=+#%#**+====-----=*#++++===-===--=**=========-=====*#
==-=+*#**++===--==+##***++===-===+**+=++**+++++++#%#**+====-----=*#++++=======--=**===============*#
====+*#***+=======+##***++=======+**+=++**+++++++#%#**++++===---=*#++++==========**============--=*#
=====*#***+=======+*#***++===-===+*#+++***+++*###%#%%%%%%%%%#+===*#++*+==========**============--=*#
=====*#***+====-==+*#***++===--==+*#++++***#%%%%#%###%%@@@@@@@%%#%%+**++=========**=============-=*#
=====*##**+====-==+*#***++===--==+##+=+*#*##%@@@@@@@@@@@@@@@@@@@@@%#***+=========**===============*#
=====*##**+====-==+*##**+++======+##***#%@@@@@@@@@@@@@@@@@@@@@@@@@@@%%#+=========**=========---==+*#
=====*##**+=======+*%#**+++=====++####%@@@@%@@@@@@@@@@@@@@@@@@@@@@@@@@%#+=======+**+====+====-===+*#
====+*##**+=======+*%#*+++++=++*%##%@@@%#%@@@@@@@@@@@@@@@@@@@@@@@@%@@@@@%*======+**+========--====*#
====+*##**+=======+*%#**+#*++#%%@%%%%%%*#%%@@@@@@@@@@@@@@@@@@@@@@@@@%@@@@#+=====+**+==============*#
====+*##**+======++*@%**%@@%%%%@@%@%%%%%%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@+=====+#*========---====*%
=====+##*++======++*@%*#@@@@@@@@@@@@@%%#%%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%+====+**===============*%
=====+##*++=======+*@%*#%@@@@@@@@@@@%%@%%%%@@@@@@@@@@@@@@@%@@@@@@@@@@@@@@@%+=====**=====+++++==--=*%
=====+##*++======++*@%#%@%%@@@@@@@@%%###%%@@@@@@@@@@@@@@@@%@@@@@@@@@@@@@@@@++====**=====+++++=---=*%
=====+##*++++====++*@%%%@%%%@@@@@@@%%%%@%%%#******##%%%@@@@@@@@@@@@@@@@@@@@++====**=====++++==---=*%
=====+##*++++++++++*%%%%@@%%@@@@@@@%%#*+==-===+=+++**#%@@@@@@@@@@@@@@@@@@@@++===+**+====+++===-===*%
==+==+##*++++++++++*%%#%@@@@@@@@@@@%#+=-----======++*#%%@@@@@@@@@@@@@@@@@@@++==++**+====++=======+*%
==+==+#%#*+++++++++*%%%%##%%#@@%%%#*=--------======+**##%%@@@@@@@@@@@@@@@@@++++==**+=============+*%
+====+#%#*++++++++++#%%###%%%%##*=++=--------======++*##%%%%@@@@@@@@@@@@@@@+++===*#+====+=======++*%
++++++#%#*++++++++++%%##*#%#####*+-+=------=---=+*######%%%%%%@@@@@@@@@@@@@+=====*#+====+++=====++*#
++++=+*%#**+++++++++%@%#**%*+++##-+--------=++#######%%%%%%%%%%@@@@@@@@%%##+=====*#+===+++=======+*#
+====+*%*+++++++++++#@#***#%**##%+------==*%@@#*+*****###%%%%%%@@@@@@@@@@@%++====*#+==+===---==+++*#
=====+*#*++++++++++*#@#***++**##%%%*+=-=+*%%%%%%###%#*+++*###%%%@@@@@@@@%%@#+====*#+======---==+++##
======*#*+=+++++++++#@#**++++++=*%%#*+--=*%#**=======--=++*##%%%@@@%@@@@@%%%*====*#+=====----==+++##
+=====*#*+=+++++==++#%#**+++++++##*=-=--=*#*+==-------===+*#%%%%%@%%%@@@@@%%+====*#+===========+++##
+=====*#*+=+++++==++#%#**++++++=--===---=++++==-------===+*#%%%%%%%%@@@@@%%#=====*#+===========+++##
+=====*#*++++++===++*%#***+++++=--------=+*++=--------==+*##%%%%%%%%@@@%%%#+=====*#+============++*#
+==+++*#*++++++===++*%#***+++++=--------=+*+**+------==++*#%%%%%%%%%@@@%%*+======*#+============++*#
+==+++*#*+++++====++*%#***+++++=--------=+*+*#%#=---===+*##%%%%%%%%%@@%%*+=======*#+============++*#
++=++++##*++++====++*%#***++++++-----===*%%%@%#*======++*##%%%%%%%%%%%%#*+=======*#*===========+++*#
++++==+##+++++====++*%%***++++++=--=====+*##*++++++===+++*#%%%%%%%%#%%%#*+=======*#*===========+++*#
++++==+##+++++====++*#%****+++++++====+===-=+++*#%%#+==++*#%%%%%%%%%%%%%*+=======*#*============++*#
++=++++##++++++===++*#%****++++++++==+#*+++++++**++====++*#%%%%%%%%%%%%%#++======*#*+===========++*#
++=++++##*+++++===++*###***+++++++++==========++++=====+*#%%%%%%%%%%%%%%#*++=====*#*++==========++*#
++=++++*#*+++++====+*#%###*++++++++**======+++=====++++**#%%%%%%%%@@@%%%%*+======*#*+++========++*##
+==++++*#*+++++====++#%###**+++++**#@*+===-==---==++**##%%%%%%%%%@@@@@%%%#++++==+*#*+++========++*##
+==++++*#*++++++===++#%###*********#@#*+====--===++*#%%%%%%%%%%@@@@@@@%%%%*++++=+*#*++++======++**##
+==++++*#*+++++++==++#%#***+*******#@#++*+====+++*##%%%%%%%%%%@@@@@@@@%%%%#++++=+*#*++++======++**##
++=++++*#*+++++++++++#%#****+**++**#@#++***+++**######%%%@@@@@@@@@@@@%%%%%%#+++=+*#*+++++======++*#%
++=++++*%*+++++++++++#%#***********#@#++*+*+++++====+*#%%%%%%%%@%%%%%%%%%%%%#*+=+*#*+++++=====++**##
++=++++*%**+++++++++*#%###********+*@#*+****++++======+++******++++++**#%%%%%%%%%#-=+++++===+++++*##
++=++++*##*++++*++++**%###*****++***@#*+***+++++==========+++*++++++++**#########*--=++++==+++=++*##
++=++++*##*++++++++++*%###*****++**#@#******+++-===========+++++==+++++****++*++=-----=*++++++++**##
+++++++*##*++*+++++++*%%##**+*******@#*****+-:::===========++++====+++++++++===-:::::+%%%###*+++**#%
+++++++*##**+*+++++++*%%##**********@%**+=::::..-=================+++++=++====-::::-#%#%%%%###****#%
+++++++*#%**+++++++++*%%##**********%#=-::::::..============++====++========-:::::*##*+-=*+-:--=++#%
+++++++*##**+++++++++*%#*#**+**+++++=-::::::::..:==========================:::.:=+*++*+==+*#*+**#***
+++++++*#%***++++++++*%%#***+++++=-:::::::::::...+=======================-::.:-+**+=+**+==++******##
+++++++*#%*****++++++*%%#***+=--:--:::-::::::::...*====================-::::-+**+*++=+*+====+*******
++++++++##*****++++++*#%#*+-::::-::::-::::::-+=::.:===+++===========-:::::-++*+++*++=++++==++*+----=
++++++++##*****++++++*#*=-:::::-::::-::::::=***=:::.-============--:..::=+++++++++++=+++++++========
+++=++++##******+++++=-:::::::-::::-:::::-+***++-:...::--====--::....:-==++++=+++++++***+==--======+
*+++++++*#******+++=-::::::::--:::--::::-+==*+==++-:...::..::.....:--=====+++=++***+=++====--====++*
++++++++*%******++=:::::..::---:::-::::-+=++++===++==-::....::::--===----=+*+==++++==++====-====+***
""");
}
else
{
    Console.WriteLine($"{favoriteperson} pulled out a knife and wants to kill you becuase you own him money, do you want to plead with him?");
    string plead = Console.ReadLine().ToLower();
    if (plead == "yes")
    {
        Console.WriteLine($"{favoriteperson} didn't carestarted stabbing you with a huge machete and you died becuase you owed {favoriteperson} some money. THE END!");

    }
    else
    {
        Console.WriteLine($"You ran away from {favoriteperson} into {favoritecar} and maneged to lose {favoriteperson}, but you crashed and died. THE END!");
    }

}

Console.ReadLine();