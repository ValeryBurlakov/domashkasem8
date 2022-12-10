// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] FillMatrix(int rows, int columns)
{
    int[,] matrix = new int [rows, columns];
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(0,10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("введите m(строку):");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n(стобец):");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int [,] matrix = FillMatrix(m,n);
PrintMatrix(matrix);
Console.WriteLine();

for (int k = 1; k < m * n; k++)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            if (matrix[i, j + 1] > matrix[i, j])
            {
                int temp = matrix[i, j + 1];
                matrix[i, j + 1] = matrix[i, j];
                matrix[i, j] = temp;
            }
        }
    }
}

PrintMatrix(matrix);
Console.WriteLine();