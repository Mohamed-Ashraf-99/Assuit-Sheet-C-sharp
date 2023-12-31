namespace H_One_Prime;

class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        bool flag = true;
        //check if the number is a prime or not
        if (number >= 2)
        {
            for (int i = 2; i < number - 1; i++)
            {
                if (number % i == 0)
                {
                    flag = false;
                }
            }
            Console.WriteLine(flag ? "YES" : "NO");
        }
    }
}