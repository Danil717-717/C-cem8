//   Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет
//   местами первую и последнюю строку массива.


int [,] CreateMatrix(int rowCount, int columnCount, int min, int max)     
{
    int[,] array = new int[rowCount, columnCount];
    for(int row = 0; row < rowCount; ++row)                  
    {
        for(int column = 0; column < columnCount; ++column)
        {
            array[row, column] = new Random().Next(min,max + 1);  
        }
    }
    return array;
}

void PrintMatrix(int[,] array)
{
    for(int row = 0; row < array.GetLength(0); ++row)                  
    {
        for(int column = 0; column < array.GetLength(1); ++column)
        {
            Console.Write($"{array[row, column]}\t");
        }
        Console.WriteLine();
    }    
           
}

void SwapRows(int[,] array)
{
    int rowCount = array.GetLength(0);
    for(int i = 0; i < array.GetLength(1); i++)
    {
        // array[0,i] <-> array[rowCount-1,i]
        int temp = array[0, i];
        array[0,i] = array[rowCount-1,i];
        array[rowCount-1,i] = temp;
    }
}

int[,] matrix = CreateMatrix(5, 3, 0, 99);
PrintMatrix(matrix);
Console.WriteLine();
SwapRows(matrix);
PrintMatrix(matrix);