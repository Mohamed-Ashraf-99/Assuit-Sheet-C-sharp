namespace H_Good_or_Bad;

class Program
{
    static void Main(string[] args)
    {
        int counter = int.Parse(Console.ReadLine());
        for (int i = 0 ; i < counter ; i++)
        {
            string word = Console.ReadLine();
            if (word.Contains("010") || word.Contains("101"))
                Console.WriteLine("Good");
            else 
                Console.WriteLine("Bad");
        }
    }
}