//Find PI to the Nth Digit - Enter a number and have the program generate PI up to that many decimal places. Keep a limit to how far the program will go.

//Declaring variable that represents the amount of PI digits to display
int eDecimalPlaces;

do
{
    //Clearing console if the loop is forced to restart so stuff doesnt get cluttered
    Console.Clear();
    Console.WriteLine("How many decimal places of e do you desire? (range of 0 and 15)");
    string userinput = Console.ReadLine();
    //Check if the user input can be converted into a valid int
    if (!int.TryParse(userinput, out eDecimalPlaces))
    {
        //Set the decimal place to a value that will force the loop to run again
        eDecimalPlaces = -1;
    }
} while (eDecimalPlaces > 15 || eDecimalPlaces < 0);

Console.WriteLine("This is your e: " + Math.Round(Math.E, eDecimalPlaces));