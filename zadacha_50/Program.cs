void FillArrayRandom(int[,]array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,]array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

void FindElement(int[,]array, int row, int column)
{
    if (row < array.GetLength(0)
    && row >= 0
    && column < array.GetLength(1)
    && column >= 0)
        System.Console.WriteLine(array[row, column]);
    else
        System.Console.WriteLine("Такого элемента нет");
}

int[,] array = new int [4, 3];
FillArrayRandom(array);
System.Console.WriteLine("Введите номер строки от нуля");
int row = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите номер столбца от нуля");
int column = int.Parse(Console.ReadLine());
PrintArray(array);
FindElement(array, row, column);