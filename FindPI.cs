int piDecimalPlaces = -1;
do
{
    Console.Clear();
    Console.WriteLine("How many decimal places of PI do you desire? (range of 0 to 15)");
    string userinput = Console.ReadLine();
    if (!int.TryParse(userinput, out piDecimalPlaces))
    {
        piDecimalPlaces = -1;
    }
} while (piDecimalPlaces > 15 || piDecimalPlaces < 0);

Console.WriteLine("This is your PI: " + Math.Round(Math.PI, piDecimalPlaces));