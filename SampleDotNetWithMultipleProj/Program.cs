namespace SampleDotNetWithMultipleProj;

class Program
{
    static void Main(string[] args)
    {
         Random r = new Random();
        int random_number = r.Next(1, int.MaxValue);
        Console.WriteLine("Finding factors for => {0}",random_number);
        SampleLib.ExampleCommonClass.GetPrimeFactors(random_number);
    }
}
