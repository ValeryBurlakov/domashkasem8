// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой 
// элементов: 1 строка

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

int SumInRow(int[,] matrix, int i)
{
  int sumInRow = matrix[i,0];
  for (int j = 1; j < matrix.GetLength(1); j++)
  {
    sumInRow += matrix[i,j];
  }
  return sumInRow;
}

Console.WriteLine("введите m(строка)");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n(столбец)");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int [,] matrix = FillMatrix(m,n);
PrintMatrix(matrix);
Console.WriteLine();

int minRow = 0;
int sumInRow = SumInRow(matrix, 0);

for (int i = 1; i < matrix.GetLength(0); i++)
{
  int temp = SumInRow(matrix, i);
  if (sumInRow > temp)
  {
    sumInRow = temp;
    minRow = i;
  }
}

Console.WriteLine($"{minRow+1} - строкa с наименьшей суммой элементов");
