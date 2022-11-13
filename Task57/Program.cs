// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    var matrix = new int[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}


// int[] CreateArray(int[,] matrix)
// {
//     var array = new int[matrix.Length];
//     int k = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             array[k] = matrix[i, j];
//             k++;

//         }
//     }
//     Array.Sort(array);
//     return array;
// }

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}



// Альбина 

int[] NewArray(int[,] matrix)
{
    int[] newArray = new int[matrix.Length];
    int k = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                newArray[k] = matrix[i,j];
                k++;
            }
        }

    return newArray;
}

void CountElements(int[] array)
{
    int num = array[0]; //1
    int count = 1;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] == num) count++; //3
        else
        {
            Console.WriteLine($"{num} встречается {count} раз");
            num = array[i];
            count = 1;
        }
    }
    Console.WriteLine($"{num} встречается {count} раз");
}

int[,] array2D = CreateMatrixRndInt(4, 4, 1, 10);
PrintMatrix(array2D);
Console.WriteLine();

int[] array = NewArray(array2D);
Array.Sort(array);
PrintArray(array);

Console.WriteLine();
CountElements(array);


// №59

// int[] FindMin(int[,] matrix)
// {
//     int min = matrix[0, 0];
//     int minRow = 0;
//     int minColumn = 0;
//     for (int i = 1; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 1; j < matrix.GetLength(1); j++)
//         {
//             if (matrix[i, j] < min)
//             {
//                 min = matrix[i, j];
//                 minRow = i;
//                 minColumn = j;
//             }
//         }
//     }
//     return new int[] {min, minRow, minColumn};
// }

// int[,] array2D = CreateMatrixRndInt(4, 4, 1, 10);
// PrintMatrix(array2D);

// int[] min = FindMin(array2D);
// PrintArray(min);

