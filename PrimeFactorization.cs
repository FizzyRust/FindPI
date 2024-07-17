using System.Collections.Generic;

ulong number;


do
{
    Console.Clear();
    Console.WriteLine("Enter a number between 2 and 18446744073709551615");
    string userinput = Console.ReadLine();
    if (!ulong.TryParse(userinput, out number))
    {
        number = 0;
    }

} while (number < 2 || number > 18446744073709551615);

ulong unchangingNumber = number;

List<ulong> primeFactors = new List<ulong>();

//if the number can be divided by 2
while (number % 2 == 0)
    {
    number /= 2;
    primeFactors.Add(2);
    }


//as all primes except 2 are odd we start with 3 and keep adding 2 to keep the number odd
//every composite number has a prime factor that is less than or equal to its square root, so we check for that
for (ulong i = 3; i <= Math.Sqrt(number); i += 2)
{
    //check if the number can be divided by i
    if (number % i == 0)
    {
        number /= i;
        primeFactors.Add(i);
    }

}

//if the number we have now is not 1, then its a prime factor
if (number != 1)
{
    primeFactors.Add(number);
}

Console.Clear();
//display the list on one line with * separators
Console.WriteLine($"For your chosen number {unchangingNumber}, I found these prime factors: " + string.Join(" * ", primeFactors));
