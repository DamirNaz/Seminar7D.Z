// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// int rows = Convert.ToInt32(Console.ReadLine());
// int colomns = Convert.ToInt32(Console.ReadLine());
// double [,] array= new double[rows,colomns];
// void GetArray()
// {
//     for (int i=0; i<array.GetLength(0); i++)
//     {
//         for (int j=0; j<array.GetLength(1); j++)
//         {
//             array[i,j]=Math.Round(new Random ().NextDouble(),1)+5;
//         }
//     }
// }

// void PrintArray()
// {
//     for (int i=0; i<array.GetLength(0); i++)
//     {
//         for (int j=0; j<array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j]+" ");
//         }
//         Console.WriteLine();
//     }
// }
// GetArray();
// PrintArray();

//__________________________________________________________________________________

// Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Console.WriteLine("введите номер строки:");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите номер столбца:");
// int colomns = Convert.ToInt32(Console.ReadLine());
// int [,] array= new int[4,5];
// void GetArray()
// {
//     for (int i=0; i<array.GetLength(0); i++)
//     {
//         for (int j=0; j<array.GetLength(1); j++)
//         {
//             array[i,j]=new Random(). Next(0,10);
//         }
//     }
// }

// void PrintArray()
// {
//     for (int i=0; i<array.GetLength(0); i++)
//     {
//         for (int j=0; j<array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j]+" ");
//         }
//         Console.WriteLine();
//     }
// }

// void FillArray()
// {
//     if ((rows>4)||(colomns>5)||(rows<=0)||(colomns<=0))
//     {
//         Console.WriteLine("такого числа в массиве нет");
//     }
//     else
//     {
//          Console.WriteLine(array[rows-1,colomns-1] );
//     }

// }
// GetArray();
// PrintArray();
// FillArray();

//_____________________________________________________________________________________

// Задайте двумерный массив из целых чисел. Найдите среднее 
// арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
Console.WriteLine("введите колличество строк:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите колличество стотбцов:");
int colomns = Convert.ToInt32(Console.ReadLine());
int [,] array= new int[rows,colomns];
void GetArray()
{
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {
            array[i,j]=new Random ().Next (0,10);
        }
    }
}

void PrintArray()
{
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {
            Console.Write(array[i,j]+" ");
        }
        Console.WriteLine();
    }
}

void FillArray()
{
    int i,j;
    for (j=0; j<array.GetLength(1); j++)
    {
        double sum = 0; 
        for (i=0; i<array.GetLength(0); i++)
        {
            sum = sum+array[i,j];
        }
        double average=sum/i;
        Console.Write(average+" ");
    }
}
GetArray();
PrintArray();
FillArray();
