// Задача 54: 
// Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой с
// троки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int m = 3;
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

void SortTheLines(int[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = j+1; k < n; k++)
            {
                if (array[i,k] > array[i,j])
                {
                    int tmp = array[i,j];
                    array[i,j] = array[i,k];
                    array[i,k] = tmp;
                }
                
            }
            
        }
        
    }
}

SortTheLines(array);
Console.WriteLine();

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
}