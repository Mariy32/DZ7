// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// double[,] Create2DRandomArray ( int rows, int columns)
// {

// double[,] newArray = new double[rows,columns];
 
// for(int i = 0; i < rows; i++)
// {
// for(int j = 0; j < columns; j++)
// {
// newArray[i,j] = Convert.ToDouble(new Random().Next(-100,100)) / 10;
// }
// }
// return newArray;
// }

// void Show2DArray(double[,] array)
// {
// for(int i = 0; i < array.GetLength(0); i++)
// {
// for(int j = 0; j < array.GetLength(1); j++)
// {
// Console.Write(array[i,j]+" ");
// }
// Console.WriteLine();
// }
// }
// Console.Write("Введите количество строк ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов ");
// int n = Convert.ToInt32(Console.ReadLine());
// double[,] myArray = Create2DRandomArray(m,n);
// Show2DArray(myArray);

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// int[,] Create2DRandomArray ( int rows, int columns, int aA, int bB)
// {
// int[,] newArray = new int[rows,columns];
// {
// for(int i = 0; i < rows; i++)
// {
// for(int j = 0; j < columns; j++)
// {
// newArray[i,j] = Convert.ToInt32(new Random().Next(-100,100));
// }
// }
// return newArray;
// }
// }

// void Show2DArray(int[,] array)
// {
// for(int i = 0; i < array.GetLength(0); i++)
// {
// for(int j = 0; j < array.GetLength(1); j++)
// {
// Console.Write(array[i,j]+" ");
// }
// Console.WriteLine();
// }
// }

// void AB (int[,] array)
// {
// int A = a;
// int B = b;
// for(int i = 0; i < array.GetLength(0); i++)
// {
// for(int j = 0; j < array.GetLength(1); j++)
// {
// if (i == A && j == B)
// {
// object c = array.GetValue(A,B);
// Console.WriteLine(c);;
// if ( A > i && B > j )
// {
// Console.WriteLine("Числа с такой позицией нет");
// }
// }
// }
// }
// }
// Console.Write("Введите количество строк ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите номер строки ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите номер столбца ");
// int b = Convert.ToInt32(Console.ReadLine());
// int[,] myArray = Create2DRandomArray(m,n,a,b);
// Show2DArray(myArray);
// AB(myArray);







// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Random random = new Random();
int[,] arr = new int[random.Next(1, 10), random.Next(1, 10)];
for (int i = 0; i < arr.GetLength(0); i++)
{
for (int j = 0; j < arr.GetLength(1); j++)
{
arr[i, j] = random.Next(1, 10);
 Console.Write(arr[i, j] + " ");
}
 Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine(arr.GetLength(0));
for (int j = 0; j < arr.GetLength(1); j++)
{
 double sum = 0;
 for (int i = 0; i < arr.GetLength(0); i++)
 {
     sum += arr[i, j];
}
    Console.Write($"{ sum / arr.GetLength(0)} ");
}
Console.ReadLine();
