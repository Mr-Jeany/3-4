﻿namespace _3_4;

public class ArrayStup<T> : ArrayBase
{
    private ArraySimple<T>[] _selfArray;
    private IGenerator<T> _selfElementGenerator;

    /// <summary>
    /// Creates a rectangular array.
    /// </summary>
    /// <param name="elementGenerator">generate used by this array. Must be the same type as array </param>
    /// <param name="userGenerated">true if array must be generated by the user. Optional </param>
    public ArrayStup(IGenerator<T> elementGenerator, bool userGenerated = false)
    {
        _selfElementGenerator = elementGenerator;
        Regenerate(userGenerated);
    }

    public override void PrintSelf()
    {
        foreach (var el in _selfArray)
        {
            el.PrintSelf();
        }
    }

    protected override void GenerateByUser()
    {
        Console.Write("Enter size of the array: ");
        _selfArray = new ArraySimple<T>[int.Parse(Console.ReadLine())];

        for (int i = 0; i < _selfArray.Length; i++)
        {
            _selfArray[i] = new ArraySimple<T>(_selfElementGenerator, true);
        }
    }

    protected override void GenerateRandomly()
    {
        Random rand = new Random();
        _selfArray = new ArraySimple<T>[rand.Next(0, 10)];
        
        for (int i = 0; i < _selfArray.Length; i++)
        {
            _selfArray[i] = new ArraySimple<T>(_selfElementGenerator, false);
        }
    }
}