//Fibonacci Sequence - Enter a number and have the program generate the Fibonacci sequence to that number or to the Nth number.

using System.Numerics;

int sequenceLength;

do
{
    Console.Clear();
    Console.WriteLine("Choose Fibonacci sequence length! (no more than 1000 numbers)");
    string userinput = Console.ReadLine();
    //Make sure input is hokey pokey
    if (!int.TryParse(userinput, out sequenceLength))
    {
        //Restart loop
        sequenceLength = -1;
    }
} while (sequenceLength < 1 || sequenceLength > 1000);

//BigInteger type from System.Numerics because I wanted BIIIIG fibonacci, also adding +1 to sequenceLength cause it starts from 0
BigInteger[] sequence = new BigInteger[sequenceLength + 1];
sequence[0] = 0; //preset first 2 fibonacci numbers
sequence[1] = 1;

if (sequenceLength >= 2) //If its less than 2 then the values are already preset
{
    for (int i = 2; i < sequenceLength + 1; i++)
    {
        //just add the previous and one from the previous fibonacci number for the current fibonacci number
        sequence[i] = sequence[i - 2] + sequence[i - 1];
    }
}

//make the array nice and pretty
string stringSequence = String.Join(", ", sequence);
Console.WriteLine(stringSequence);
