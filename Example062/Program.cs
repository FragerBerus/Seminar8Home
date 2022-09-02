// Задача 62. Напишите программу, которая заполнит спирально
// массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
Console.Clear();
Console.Write("Введите размер квадратной матрицы: ");
int size = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[size, size];
int element = 1;
int i = 0;
int j = 0;
while (element <= size * size)
{
    matrix[i, j] = element;
    if (i <= j + 1 && i + j < size - 1)
    {
        ++j;
    }
    else
    {
        if (i < j && i + j >= size - +1)
        {
            ++i;
        }
        else
        {
            if (i >= j && i + j > size - 1)
            {
                --j;
            }
            else
            {
                --i;
            }
        }
    }
    ++element;
}
Console.WriteLine("Квадратная матрица, зfполненная по спирали:");
for (i = 0; i < size; i++)
{
    for (j = 0; j < size; j++)
    {
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}
