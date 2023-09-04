// See https://aka.ms/new-console-template for more information
Console.WriteLine("Vad heter du");
string name = Console.ReadLine().ToLower();


if (name == "theo" || name == "Theo")
{
 Console.WriteLine("Välkommen");
}
else if (name == "olivia")
{
    Console.WriteLine("Hej Hej :)");
}
else
{
    Console.WriteLine("Hej då :(");
}


// if (name != "theo")
// {
    // Console.WriteLine("FUCK OFF");
// }

Console.ReadLine();