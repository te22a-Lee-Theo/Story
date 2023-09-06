// See https://aka.ms/new-console-template for more information
Console.WriteLine("You walk a path in a dark forest and you encounter a fork in the road. Do take the right or the left path?");
string dir = Console.ReadLine().ToLower();


if (dir == "right" || dir =="r")
{
    Console.WriteLine("You continue walking and suddenly a house appears. Do you enter the house?. Yes or no");
    string wasd = Console.ReadLine().ToLower();

    if (wasd == "yes" || wasd == "y");
    {
    Console.WriteLine("You open the dorr to the house, you get struck in the head from behind and gets captured.\nGAME OVER");
    }

    else if (wasd == "no" || wasd == "n");
    {
    Console.WriteLine("You follow the dark path and suddenly you see the light trough the trees and you arrive to your destination.");
    Console.WriteLine("YOU WIN");
    }

    else
    {
        Console.WriteLine("");
    }
}
else if (dir == "left" || dir == "l")
{
    Console.WriteLine("You countinue on the dark path. A tree branch suddenly breaks and crushes you. GAME OVER");
}
else
{
    Console.WriteLine("Please choose a valid direction.");
}



Console.ReadLine();