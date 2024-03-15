﻿namespace _3_4;

public class ArrayRect<T> : ArrayBase
{
    private T[,] _selfArray;
    public int[] size = {4, 3};
    private IGenerator<T> _selfElementGenerator;

    /// <summary>
    /// Creates a rectangular array.
    /// </summary>
    /// <param name="elementGenerator">generate used by this array. Must be the same type as array </param>
    /// <param name="userGenerated">true if array must be generated by the user. Optional </param>
    public ArrayRect(IGenerator<T> elementGenerator, bool userGenerated = false)
    {
        _selfElementGenerator = elementGenerator;
        Regenerate(userGenerated);
    }

    public override void PrintSelf()
    {
        for (int i = 0; i < size[0]; i++)
        {
            for (int j = 0; j < size[1]; j++)
            {
                Console.Write(_selfArray[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    protected override void GenerateByUser()
    {
        Console.Write("Enter height of the array: ");
        size[0] = int.Parse(Console.ReadLine());
        Console.Write("Enter width of the array: ");
        size[1] = int.Parse(Console.ReadLine());
        
        _selfArray = new T[size[0], size[1]];
        for (int i = 0; i < _selfArray.GetLength(0); i++)
        {
            for (int j = 0; j < _selfArray.GetLength(1); j++)
            {
                Console.Write($"Element [{i}, {j}]: ");
                _selfArray[i, j] = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
            }
        }
    }

    protected override void GenerateRandomly()
    {
        _selfArray = new T[size[0], size[1]];
        for (int i = 0; i < _selfArray.GetLength(0); i++)
        {
            for (int j = 0; j < _selfArray.GetLength(1); j++)
            {
                _selfArray[i, j] = _selfElementGenerator.GetRandom();
            }
        }
    }
}