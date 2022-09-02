// Задача 60.
// Сформируйте трёхмерный массив из неповторяющихся двузначных
// чисел. Напишите программу, которая будет построчно выводить
// массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
Console.Clear();
Console.Write("Задайте размер кубической матрицы не более 4 (4х4х4): ");
int size = Convert.ToInt32(Console.ReadLine());
if (size > 4)
{
    Console.WriteLine("Превышен введенный размер матрицы.");
    return;
}
int[,,] matrix3D = new int[size, size, size];
for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        for (int k = 0; k < size; k++)
        {
        Random:
            int temp = new Random().Next(100);
            for (int l = 0; l < size; l++)
            {
                for (int m = 0; m < size; m++)
                {
                    for (int n = 0; n < size; n++)
                    {
                        if (temp == matrix3D[l, m, n])
                        {
                            goto Random;
                        }
                    }
                }
            }
            matrix3D[i, j, k] = temp;
        }
    }
}
Console.WriteLine("Элементы матрицы " + size + "х" + size + "х" + size + " с индексами:");
for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        for (int k = 0; k < size; k++)
        {
            Console.Write(matrix3D[i, j, k] + " (" + i + ", " + j + ", " + k + ")" + "\t");
        }
        Console.WriteLine();
    }
}