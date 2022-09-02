// Задача 56:
// Задайте прямоугольный двумерный массив. Напишите
// программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер
// строки с наименьшей суммой элементов: 1 строка
Console.Clear();
Console.Write("Задайте количество строк матрицы: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте количество столбцов матрицы: ");
int columns = Convert.ToInt32(Console.ReadLine());
if (rows != columns)
{
    int sumRow = 0;
    int minSumRow = Int32.MaxValue;
    int indexMinSumRow = 0;
    int[,] matrix = new int[rows, columns];
    Console.WriteLine("Исходная матрица:");
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = new Random().Next(11);
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            sumRow = sumRow + matrix[i, j];
        }
        if (minSumRow > sumRow)
        {
            minSumRow = sumRow;
            indexMinSumRow = i;
        }
        sumRow = 0;
    }
    Console.WriteLine("Наименьшая сумма строковых переменных " + minSumRow + " в строке " + (indexMinSumRow + 1) + " матрицы.");
}
else
{
    Console.WriteLine("Матрица не является прямоугольной, т.к. количество строк равно количеству столбцов.");
    return;
}