void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

void ArithmeticMeanColomn(int[,] array)
{
    string result = "Среднее арифметическое каждого столбца: ";
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double arithmeticMean = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            arithmeticMean = array[j,i] + arithmeticMean;
        }
        arithmeticMean = arithmeticMean / array.GetLength(0);
        result = result + '(' + Convert.ToString(arithmeticMean) + ')' + ' ';
    }
    System.Console.WriteLine(result);
}

int[,] array = new int [4, 3];
FillArrayRandom(array);
PrintArray(array);
System.Console.WriteLine();
ArithmeticMeanColomn(array);