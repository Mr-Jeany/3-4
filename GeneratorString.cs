namespace _3_4;

public class GeneratorString : IGenerator<string>
{
    private const string _availableSymbs = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";


    public string GetRandom()
    {
        string returnedString = "";
        Random rand = new Random();
        
        for (int i = 0; i < rand.Next(3, 10); i++)
        {
            returnedString += Char.ToString(_availableSymbs[rand.Next(0, _availableSymbs.Length)]);
        }

        return returnedString;
    }
}