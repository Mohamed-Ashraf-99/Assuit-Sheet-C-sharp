namespace B._Basic_Data_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string userInput = Console.ReadLine();
           var splited = userInput.Split(' ');
           
            foreach (var sol in splited)
            {
                Console.WriteLine(sol);
            }
        }
    }
}
