﻿// Задача 62. Напишите программу, 
// которая заполнит спирально массив 
// 4 на 4.
// Например, на выходе получается 
// вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void PrintArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      {
      Console.Write($" {array[i,j]} ");
      }
      else 
      {
        Console.Write($"{array[i,j]} ");
      }
    }
    Console.WriteLine();
  }
}

void FillArray(int[,] matrix)
{

int number = 1;
int i = 0;
int j = 0;

while (number <= matrix.GetLength(0) * matrix.GetLength(1))
{

  matrix[i, j] = number;
  number++;
  
  if (i <= j + 1 && i + j < matrix.GetLength(1) - 1) 
  {
    j++;
  }
  else if (i < j && i + j >= matrix.GetLength(0) - 1) 
  {
    i++;
  }
  else if (i >= j && i + j > matrix.GetLength(1) - 1) 
  {
    j--;
  }
  else 
  {
    i--;
  }
}
}

Console.Write("Введите размерность квадратного массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] matrix = new int[size, size];

FillArray(matrix);
PrintArray(matrix);