// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет 
// находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
Console.Clear();
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
Console.WriteLine("первая матрица");
Console.WriteLine("введите m(строка)");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n(столбец)");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int [,] matrix = FillMatrix(m,n);

Console.WriteLine();

Console.WriteLine("Вторая матрица");
Console.WriteLine("введите n(строка)");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите p(столбец)");
int p = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int [,] matrix2 = FillMatrix(n2, p);

int [,] matrix3 = new int[m, p];

Console.WriteLine();

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix2.GetLength(1); j++)
    {
        for (int k = 0; k < n; k++)
        {
        matrix3[i, j] = matrix3[i, j] + matrix[i, k] * matrix2[k, j];
        }
    }
}
Console.WriteLine("Первая матрица:");
PrintMatrix(matrix);
Console.WriteLine("Вторая матрица:");
PrintMatrix(matrix2);
Console.WriteLine("Результат умножения двух матриц: ");
PrintMatrix(matrix3);