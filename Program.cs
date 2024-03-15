namespace _3_4;

class Program
{
    static void Main()
    {
        IGenerator<int> generatorInt = new GeneratorInt();
        IGenerator<string> generatorString = new GeneratorString();
        IGenerator<bool> generatorBool = new GeneratorBool();
        IGenerator<double> generatorDouble = new GeneratorDouble();

        Console.Write("Show simple arrays? (y/n) - ");
        if (Console.ReadLine() == "y")
        {
            Console.WriteLine();
            ArraySimple<int> arraySimpleInt = new ArraySimple<int>(generatorInt, false);
            arraySimpleInt.PrintSelf();
            ArraySimple<string> arraySimpleString = new ArraySimple<string>(generatorString, false);
            arraySimpleString.PrintSelf();
            ArraySimple<bool> arraySimpleBool = new ArraySimple<bool>(generatorBool, false);
            arraySimpleBool.PrintSelf();
            ArraySimple<double> arraySimpleDouble = new ArraySimple<double>(generatorDouble, false);
            arraySimpleDouble.PrintSelf();
        }

        Console.Write("Show rectangular arrays (twodim)? (y/n) - ");
        if (Console.ReadLine() == "y")
        {
            ArrayRect<int> arrayRectInt = new ArrayRect<int>(generatorInt, false);
            arrayRectInt.PrintSelf();
            ArrayRect<string> arrayRectString = new ArrayRect<string>(generatorString, false);
            arrayRectString.PrintSelf();
            ArrayRect<bool> arrayRectBool = new ArrayRect<bool>(generatorBool, false);
            arrayRectBool.PrintSelf();
            ArrayRect<double> arrayRectDouble = new ArrayRect<double>(generatorDouble, false);
            arrayRectDouble.PrintSelf();
        }
        
        Console.Write("Show stup arrays ([][])? (y/n) - ");
        if (Console.ReadLine() == "y")
        {
            ArrayStup<int> arrayStupInt = new ArrayStup<int>(generatorInt, false);
            arrayStupInt.PrintSelf();
            ArrayStup<string> arrayStupString = new ArrayStup<string>(generatorString, false);
            arrayStupString.PrintSelf();
            ArrayStup<bool> arrayStupBool = new ArrayStup<bool>(generatorBool, false);
            arrayStupBool.PrintSelf();
            ArrayStup<double> arrayStupDouble = new ArrayStup<double>(generatorDouble, false);
            arrayStupDouble.PrintSelf();
        }

    }
}