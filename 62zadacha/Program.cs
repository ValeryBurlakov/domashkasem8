// Задача 62. Напишите программу, 
// которая заполнит спирально массив 
// 4 на 4.
// Например, на выходе получается 
// вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// int[,] FillMatrix(int rows, int columns)
// {
//     int[,] matrix = new int [rows, columns];
//     for(int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for(int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i,j] = new Random().Next(0,10);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for(int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for(int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
// }
// Console.WriteLine("введите m");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите n");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();
// int [,] matrix = FillMatrix(m,n);
// PrintMatrix(matrix);
// Console.WriteLine();


// void DisplayArray(int[,] a)
//     {
//         for (int i = 0; i < a.GetLength(0); i++)
//         {
//             for (int j = 0; j < a.GetLength(1); j++) Console.Write("{0,3} ", a[i, j]);
//             Console.WriteLine();
//         }
//     }

// void Main(string[] args)
//     {
//         while (true)
//         {
//             Console.Write("Enter a non-negative number (0 - exit): ");

//             int n;
//             if (!Int32.TryParse(Console.ReadLine(), out n) || n <= 0) break;

//             Console.WriteLine();

//             int[,] a = new int[n, n];

//             int i = 0, j = 0;

//             int value = 1;

//             while (n != 0)
//             {
//                 int k = 0;
//                 do { a[i, j++] = value++; } while (++k < n - 1);
//                 for (k = 0; k < n - 1; k++) a[i++, j] = value++;
//                 for (k = 0; k < n - 1; k++) a[i, j--] = value++;
//                 for (k = 0; k < n - 1; k++) a[i--, j] = value++;

//                 ++i; ++j; n = n < 2 ? 0 : n - 2;
//             }

//             DisplayArray(a);
//             Console.WriteLine();
//         }
//     }




// void Main()
//         {
//             const int n = 11;
//             var a = GetSpire(n);
//             for (int i = 0; i < n; i++)
//             {
//                 for (int j = 0; j < n; j++)
//                 {
//                     Console.Write(a[i,j]);
//                 }
//                 Console.WriteLine();
//             }
//         }
 
// int[,] GetSpire(int n)
//         {
//             var result = new int[n, n];
//             for (int currentChar = 1, padding = 0; padding < n/2; padding++)
//             {
//                 for (int j = padding; j < n - padding; j++)
//                     result[padding, j] = currentChar;
//                 for (int j = padding; j < n - padding; j++)
//                     result[n - padding - 1, j] = currentChar;
//                 for (int i = padding + 2; i < n - padding - 1; i++)
//                     result[i, padding] = currentChar;
//                 for (int i = padding + 1; i < n - padding - 1; i++)
//                     result[i, n - padding - 1] = currentChar;
//                 currentChar = 1 - currentChar;
//                 result[padding + 1, padding] = currentChar;
//             }
//             if (n%2 != 0 && result[0, 0] == 1)
//                 result[n/2, n/2] = 1;
//             return result;
//         }



// int n = Int32.Parse(Console.ReadLine());
//             int[,] matr = new int[n, n];
 
//             Console.WriteLine();
 
//             int i, j;
                        
//             for (j = 0, i = 0; j < n; j++)
//                 matr[i, j] = 1;
 
//             for (i = 0, j = n - 1; i < n; i++)
//                 matr[i, j] = 1;
 
//             for (j = n-1, i = n-1; j >=0; j--)
//                 matr[i, j] = 1;
 
//             int count = 3;
//             int c = 0;
 
//             i= n - 1;
//             j= 0;
 
//             for (int x = n - 3; x > 0; x -= 2)
//             {
//                 if (n % 2 == 0 & x == 1)
//                     c = 1;
//                 else
//                     c = 0;
 
//                 while (c < 2)
//                 {
//                     switch (count)
//                     {
//                         case 1: //Down
//                             for (int t = 0; t < x; t++)
//                             {
//                                 i++;
//                                matr[i, j] = 1;
 
//                             }
 
//                             count++;
//                             break;
//                         case 2: //Left
//                             for (int t = 0; t < x; t++)
//                             {
//                                 j--;
//                                 matr[i, j] = 1;
//                             }
 
//                             count++;
//                             break;
//                         case 3: //Up
//                             for (int t = 0; t < x; t++)
//                             {
//                                 i--;
//                                 matr[i, j] = 1;
//                             }
 
//                             count++;
//                             break;
//                         case 4: //Right
//                             for (int t = 0; t < x; t++)
//                             {
//                                 j++;
//                                 matr[i, j] = 1;
//                             }
 
//                             count = 1;
//                             break;
//                     }
 
 
//                     c++;
//                 }
//             }
 
          
 
//             for (int ii = 0; ii < n; ii++)
//             {
//                 for (int jj = 0; jj < n; jj++)
//                     Console.Write(matr[ii, jj]);
//                 Console.WriteLine();
//             }
 
//             Console.ReadLine();
        


        // int n = 6;
        // int m = 8;
        //     int[,] matrix = new int[n, m];
 
        //     int row = 0;
        //     int col = 0;
        //     int dx = 1;
        //     int dy = 0;
        //     int dirChanges = 0;
        //     int visits = m;
 
        //     for (int i = 0; i < matrix.Length; i++) {
        //         matrix[row, col] = i + 1;
        //       if (--visits == 0) {
        //         visits = m * (dirChanges %2) + n * ((dirChanges + 1) %2) - (dirChanges/2 - 1) - 2;
        //         int temp = dx;
        //         dx = -dy;
        //         dy = temp;
        //         dirChanges++;
        //       }
 
        //       col += dx;
        //       row += dy;
        //     }

int[,] matrix = new int[N, M];
    int N, M;

    scanf("%d%d", &N, &M);
    
    int Ibeg = 0, Ifin = 0, Jbeg = 0, Jfin = 0;
    
    int k = 1;
    int i = 0;
    int j = 0;

    while (k <= N * M){
        a[i][j] = k;
        if (i == Ibeg && j < M - Jfin - 1)
            ++j;
        else if (j == M - Jfin - 1 && i < N - Ifin - 1)
            ++i;
        else if (i == N - Ifin - 1 && j > Jbeg)
            --j;
        else
            --i;

        if ((i == Ibeg + 1) && (j == Jbeg) && (Jbeg != M - Jfin - 1)){
            ++Ibeg;
            ++Ifin;
            ++Jbeg;
            ++Jfin;
        }
        ++k;
    }
    
    for (int i = 0; i < 10; ++i){
        for (int j = 0; j < 10; ++j)
            Console.WriteLine("%3d", a[i][j]);
        Console.WriteLine("\n");
    }

    return 0;
