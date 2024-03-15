namespace _3_4;

public class GeneratorInt : IGenerator<int>
{
    public int GetRandom()
    {
        Random rand = new Random();
        return rand.Next(0, 100);
    }
}