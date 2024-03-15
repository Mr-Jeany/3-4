namespace _3_4;

public abstract class ArrayBase : IArray
{
    public abstract void PrintSelf();

    public virtual void Regenerate(bool userGenerated = false)
    {
        if (userGenerated)
        {
            GenerateByUser();
        }
        else
        {
            GenerateRandomly();
        }
    }

    protected abstract void GenerateByUser();
    protected abstract void GenerateRandomly();
}