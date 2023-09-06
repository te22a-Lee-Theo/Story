// See https://aka.ms/new-console-template for more information
Console.WriteLine("You walk a path in a dark forest and you encounter a fork in the road. Do take the right or the left path?");
string dir = Console.ReadLine().ToLower();


if (dir == "right")
{
 Console.WriteLine("You continue walking and suddenly a house appears. Do you enter the house?");
}
else if (dir == "left")
{
    Console.WriteLine("You countinue on the dark path and a branch suddenly breaks and crushes you. GAME OVER");
}
else
{
    Console.WriteLine("Please choose a valid direction.");
}



Console.ReadLine();