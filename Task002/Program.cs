//  Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
//  В случае, если это невозможно, программа должна вывести сообщение для пользователя.


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


int[,] ReversMatrix (int[,] array)
{
    int [,] matrix = new int[array.GetLength(1),array.GetLength(0)];
    
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            matrix[j, i] = array[i, j];
        }
       
    }

    return matrix;
}


int[,] matrix = CreateMatrix(3, 3, 0, 99);
PrintMatrix(matrix);
Console.WriteLine();
int[,] reverMatrix = ReversMatrix(matrix);
PrintMatrix(reverMatrix);