namespace L_The_Brotherss;

class Program
{
    static void Main(string[] args)
    {
        //Take Person One Data from the user
        string personOneInput = Console.ReadLine();
        string[] personOneFullName = personOneInput.Split(' ');

        string personOneFirstName = personOneFullName[0];
        string personOneLastName = personOneFullName[1];
        
        //Take Person One Data from the user
        string personTwoInput = Console.ReadLine();
        string[] personTwoFullName = personTwoInput.Split(' ');
        
        string personTwoFirstName = personTwoFullName[0];
        string personTwoLastName = personTwoFullName[1];
        
        //Check if they are brothers or not
        if(personOneLastName == personTwoLastName)
            Console.WriteLine("ARE Brothers");
        else
            Console.WriteLine("NOT");
        
    }
}