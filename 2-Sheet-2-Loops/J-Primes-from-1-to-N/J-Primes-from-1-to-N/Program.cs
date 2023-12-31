namespace J_Primes_from_1_to_N;

class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        
        for (int i = 2 ; i <= number ; i++)
        {
            bool flag = true;
            for (int j = 2 ; j < i ; j++)
            {
                if (i % j == 0)
                {
                    flag = false;
                    break;
                }
            }
            if (flag)
                Console.Write($"{i} ");
        }
    }
}