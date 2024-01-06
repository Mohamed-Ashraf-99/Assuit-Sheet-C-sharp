namespace K_I_Love_strings_2;

class Program
{
    static void Main(string[] args)
    {
        int counter = int.Parse(Console.ReadLine());
        for (int i = 0; i < counter; i++)
        {
            string[] words = Console.ReadLine().Split();
            
            string firstWord = words[0];
            string secondWord = words[1];

            int maxLength = Math.Max(firstWord.Length, secondWord.Length);
            for (int j = 0; j < maxLength ; j++)
            {
                if (j < firstWord.Length)
                {
                    Console.Write(firstWord[j]);
                }
                if (j < secondWord.Length)
                {
                    Console.Write(secondWord[j]);
                }
            }
            Console.WriteLine();
        }
    }
}