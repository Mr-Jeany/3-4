namespace _3_4;

public class GeneratorBool : IGenerator<bool>
{
    public bool GetRandom()
    {
        Random rand = new Random();
        return rand.NextDouble() < 0.5;
    }
}