namespace P_First_digit;

class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        int firstDigit = number / 1000;
        if(firstDigit % 2 == 0)
            Console.WriteLine("EVEN");
        else 
            Console.WriteLine("ODD");
    }
}