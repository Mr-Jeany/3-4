namespace _3_4;

public class GeneratorDouble : IGenerator<double>
{
    public double GetRandom()
    {
        Random rand = new Random();
        return rand.NextDouble();
    }
}