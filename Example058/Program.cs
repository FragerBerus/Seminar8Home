// Задача 58: Задайте две матрицы. Напишите программу, которая
// будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
Console.Clear();
Console.Write("Задайте размер матриц A и B: ");
int sizeMatrixs = Convert.ToInt32(Console.ReadLine());
int[,] FillMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(11);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
int[,] matrixA = new int[sizeMatrixs, sizeMatrixs];
int[,] matrixB = new int[sizeMatrixs, sizeMatrixs];
int[,] matrixC = new int[sizeMatrixs, sizeMatrixs];
FillMatrix(matrixA);
FillMatrix(matrixB);
for (int i = 0; i < sizeMatrixs; i++)
{
    for (int j = 0; j < sizeMatrixs; j++)
    {
        for (int k = 0; k < sizeMatrixs; k++)
        {
            matrixC[i, j] = matrixC[i, j] + (matrixA[i, k] * matrixB[k, j]);
        }
    }
}

Console.WriteLine("Исходная матрица А:");
PrintMatrix(matrixA);
Console.WriteLine("Исходная матрица B:");
PrintMatrix(matrixB);
Console.WriteLine("Матрица С. Произведение метриц А и В:");
PrintMatrix(matrixC);