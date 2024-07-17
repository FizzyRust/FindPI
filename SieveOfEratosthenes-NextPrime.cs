//Next Prime Number - Have the program find prime numbers until the user chooses to stop asking for the next one.
//I merged it with the Sieve of Eratosthenes and instead prompt the user for up to what number should the primes be generated

int limit = GetUserInput();
List<int> primes = GeneratePrimes(limit);
DisplayPrimes(primes, limit);

int GetUserInput()
    {
        int limit;
        do
        {
            Console.Clear();
            Console.WriteLine("Up to what number do you want to find prime numbers? (2 to 10 million)");
            if (!int.TryParse(Console.ReadLine(), out limit) || limit < 2 || limit > 10_000_000)
            {
                Console.WriteLine("Invalid input. Please enter a number between 2 and 10 million.");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        } while (limit < 2 || limit > 10_000_000);
        return limit;
    }

List<int> GeneratePrimes(int limit)
{
    bool[] isPrime = new bool[limit + 1];//compensate for index starting at 0
    for (int i = 2; i <= limit; i++)
    {
        //fill array with true values except indexes 0 and 1
        isPrime[i] = true;
    }

    //any composite number larger than sqrt of limit will already be marked as composite by a smaller prime factor
    for (int i = 2; i <= Math.Sqrt(limit); i++)
    {
        //the array by default is filled with only true values
        if (isPrime[i])
        {
            for (int j = i * i; j <= limit; j += i)
            {
                isPrime[j] = false;
            }
        }
    }

    //Add all true values to list
    return Enumerable.Range(2, limit - 1).Where(i => isPrime[i]).ToList();
}

void DisplayPrimes(List<int> primes, int limit)
{
    Console.Clear();
    Console.WriteLine($"These are all the prime numbers up to {limit}:");
    Console.WriteLine(string.Join(", ", primes));
}
