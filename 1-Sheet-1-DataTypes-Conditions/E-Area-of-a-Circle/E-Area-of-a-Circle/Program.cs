namespace E_Area_of_a_Circle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double PI = 3.141592653;
            double radius = double.Parse(Console.ReadLine());
            double areaOfCircle = PI * radius * radius;
            Console.WriteLine(areaOfCircle);
        }
    }
}
