namespace SampleLib;

public class ExampleCommonClass
{
    public static void GetPrimeFactors(int n=1)
    {
        List<int> factors = new List<int>();
        while (n % 2 == 0)
        {
            factors.Add(2);
            n /= 2;
        }
        for (int i = 3; i <= Math.Sqrt(n); i += 2)
        {
            while (n % i == 0)
            {
                factors.Add(i);
                n /= i;
            }
        }
        if (n > 2)
        {
            factors.Add(n);
        }
        Console.Write("\nFactors=>");
        foreach(int i in factors)
        {
            Console.Write("\t{0}",i);
        }

    }
}
