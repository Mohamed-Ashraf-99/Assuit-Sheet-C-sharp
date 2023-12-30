namespace G_Summation_from_1_to_N
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            long result = number * (number + 1) / 2;
            Console.WriteLine(result);
        }
    }
}
