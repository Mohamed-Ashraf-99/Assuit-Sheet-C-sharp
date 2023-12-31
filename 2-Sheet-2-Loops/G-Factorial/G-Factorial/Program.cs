namespace G_Factorial;

class Program
{
    static void Main(string[] args)
    {
            int counter = int.Parse(Console.ReadLine());
            while (counter != 0)
            {
                long factorial = long.Parse(Console.ReadLine());
                if (factorial > 0)
                {
                    for (long j = factorial - 1 ; j >= 1 ; j--)
                    {
                        factorial *= j;
                    }
                    Console.WriteLine(factorial);
                }
                counter--;
            }
    }
}