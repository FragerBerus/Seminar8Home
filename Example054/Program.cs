// Задача 54: Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
Console.Clear();
Console.Write("Введите количество строк матрицы: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[rows, columns];
void PrintArray(int[,] array)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        matrix[i, j] = new Random().Next(11);
    }
}
Console.WriteLine("Исходная матрица: ");
PrintArray(matrix);
int[][] matrixRow = new int[rows][];
for (int i = 0; i < rows; i++)
{
    matrixRow[i] = new int[columns];
}
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        matrixRow[i][j] = matrix[i, j];
    }
}
for (int i = 0; i < rows; i++)
{
    Array.Sort(matrixRow[i]);
    Array.Reverse(matrixRow[i]);
}
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        matrix[i, j] = matrixRow[i][j];
    }
}
System.Console.WriteLine("Упорядоченная матрица: ");
PrintArray(matrix);