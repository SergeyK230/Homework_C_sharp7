void FillArrayDouble(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().NextDouble() + new Random().Next(-9, 10);
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write("{0, 4:0.#} ",array[i, j]);
        }
        System.Console.WriteLine();
    }
}

System.Console.WriteLine("Введите количество строк");
int m = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов");
int n = int.Parse(Console.ReadLine());
double[,] array = new double[m,n];
FillArrayDouble(array);
PrintArray(array);