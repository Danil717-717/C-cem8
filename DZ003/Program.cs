//  Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//  Например, даны 2 матрицы:
//  2 4 | 3 4
//  3 2 | 3 3
//  Результирующая матрица будет:
//  18 20
//  15 18

int[,] CreateMatrix1(int rowCount, int columnCount, int min, int max)
{
    int[,] array = new int[rowCount, columnCount];
    for (int row = 0; row < rowCount; ++row)
    {
        for (int column = 0; column < columnCount; ++column)
        {
            array[row, column] = new Random().Next(min, max + 1);
        }
    }
    return array;
}

int[,] CreateMatrix2(int rowCount, int columnCount, int min, int max)
{
    int[,] array = new int[rowCount, columnCount];
    for (int row = 0; row < rowCount; ++row)
    {
        for (int column = 0; column < columnCount; ++column)
        {
            array[row, column] = new Random().Next(min, max + 1);
        }
    }
    return array;
}

void PrintMatrix(int[,] array)
{
    for (int row = 0; row < array.GetLength(0); ++row)
    {
        for (int column = 0; column < array.GetLength(1); ++column)
        {
            Console.Write($"{array[row, column]}\t");
        }
        Console.WriteLine();
    }

}

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMartrix.GetLength(1); k++)
            {
                sum += firstMartrix[i, k] * secomdMartrix[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
}

Console.WriteLine($"\nПервая матрица:");
int[,] firstMartrix = CreateMatrix1(5, 5, 0, 9);
PrintMatrix(firstMartrix);

Console.WriteLine($"\nВторая матрица:");
int[,] secomdMartrix = CreateMatrix2(5, 5, 0, 9);
PrintMatrix(secomdMartrix);

int[,] resultMatrix = new int[5, 5];
MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
Console.WriteLine($"\nПроизведение первой и второй матриц:");
PrintMatrix(resultMatrix);


