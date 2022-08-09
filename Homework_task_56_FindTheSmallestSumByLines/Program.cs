// Задача 56: 
// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить 
// строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int m = 4;
int n = 4;
int[,] array = new int[m,n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i,j] = new Random().Next(10);
        Console.Write($"{array[i,j]} ");    
    }
    Console.WriteLine();
}

void FindSum(int[,] array)
{
    int sum = 0;
    int[] sumLines = new int[m];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            sum += array[i,j];            
        }
        //Console.Write($"{sum} ");
        sumLines[i] = sum;
        sum = 0;
    }

    int indexMinSum = 0;
    for (int i = 0; i < m; i++)
    {
        if(sumLines[i]<sumLines[indexMinSum]) indexMinSum = i;
    }
    Console.WriteLine();
    Console.WriteLine($"Индекс строки с миниимальной суммой элементов в данном массиве равен {indexMinSum}.");
}

FindSum(array);