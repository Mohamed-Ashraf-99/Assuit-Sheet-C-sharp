namespace I_Palindrome;

class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        int palindrom = 0;
        for (int i = number; i > 0 ; i/=10)
        {
            palindrom = (palindrom * 10) + (i % 10);
        }

        if (number == palindrom)
        {
            Console.WriteLine(palindrom);
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine(palindrom);
            Console.WriteLine("NO");
        }
            
    }
}