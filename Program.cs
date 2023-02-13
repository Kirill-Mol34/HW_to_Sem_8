//    Составить частотный словарь элементов двумерного массива

/*
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
int m = 4;
int n = 8;
int[,] array = new int[m, n];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int count = 0;
int[,] dictionary = new int[m * n, 2];
int k = 0;

bool exist = false;

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        exist = false;
        for (int r = 0; r < k; r++)
        {
            if (dictionary[r, 0] == array[i, j])
            {
                dictionary[r, 1]++;
                exist = true;
                break;
            }
        }
        if (exist == false)
        {
            dictionary[k, 0] = array[i, j];
            dictionary[k, 1]++;
            k++;
        }
    }
}
for (int i = 0; i < k; i++)
{
    for (int j = 0; j < dictionary.GetLength(1); j++)
    {
        Console.Write($"{dictionary[i, +j]} ");
    }
    Console.WriteLine();
}
*/

//    Найти произведение двух матриц.
/*
void FillArray(int[,] matrix, int[,] matrix1)
{
    for (int m = 0; m < matrix.GetLength(0); m++)
    {
        for (int n = 0; n < matrix.GetLength(1); n++)
        {
            matrix[m, n] = new Random().Next(1, 10);
        }
    }
    for (int m = 0; m < matrix1.GetLength(0); m++)
    {
        for (int n = 0; n < matrix1.GetLength(1); n++)
        {
            matrix1[m, n] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] matrix, int[,] matrix1)
{
    for (int m = 0; m < matrix.GetLength(0); m++)
    {
        for (int n = 0; n < matrix.GetLength(1); n++)
        {
            Console.Write($"{matrix[m, n]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    for (int m = 0; m < matrix1.GetLength(0); m++)
    {
        for (int n = 0; n < matrix1.GetLength(1); n++)
        {
            Console.Write($"{matrix1[m, n]} ");
        }
        Console.WriteLine();
    }
}

void Composition(int[,] matrix, int[,] matrix1, int[,] compMatrix)
{
    for (int m = 0; m < matrix.GetLength(0); m++)
    {
        for (int n = 0; n < matrix.GetLength(1); n++)
        {
            compMatrix[m, n] = matrix[m, n] * matrix1[m, n];
        }
    }
}

void PrintCompArray(int[,] compMatrix)
{
    for (int m = 0; m < compMatrix.GetLength(0); m++)
    {
        for (int n = 0; n < compMatrix.GetLength(1); n++)
        {
            Console.Write($"{compMatrix[m, n]} ");
        }
        Console.WriteLine();
    }
}

int[,] matrix = new int[2, 2];
int[,] matrix1 = new int[2, 2];
int[,] compMatrix = new int[2, 2];
FillArray(matrix, matrix1);
PrintArray(matrix, matrix1);
Console.WriteLine();
Console.WriteLine("Произведение чисел первого и второго массива:");
Composition(matrix, matrix1, compMatrix);
PrintCompArray(compMatrix);
*/

//    В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.
/*
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
int m = 6;
int n = 6;
int[,] array = new int[m, n];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int x = 0;
int y = 0;
int min = array[0, 0];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i, j] < min)
        {
            min = array[i, j];
            x = i;
            y = j;
        }
    }
}
Console.WriteLine("Наименьший элемент в массиве: " + min);

Console.WriteLine("Массив после удаления строки и столбца с наименьшим элементом:");
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        {
            if ((i == x) || (j == y))
                continue;
            else
                Console.Write(array[i, j] + " ");
        }
    }
    Console.WriteLine();
}
*/

//    Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно 
//    на экран выводя индексы соответствующего элемента.

/*
int[,,] array3D = new int[2, 2, 2];
FillArray(array3D);
PrintIndex(array3D);

void PrintIndex(int[,,] arr)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.Write($"{array3D[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}

void FillArray(int[,,] arr)
{
    int count = 10;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[k, i, j] += count;
                count += 3;
            }
        }
    }
}
*/

//    Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника
/*
int row = 32;
int[,] triangle = new int[row, row];
const int cellWidth = 1;

void FillTriangle()
{
    for (int i = 0; i < row; i++)
    {
        triangle[i, 0] = 1;
        triangle[i, i] = 1;
    }

    for (int i = 2; i < row; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            triangle[i, j] = triangle[i - 1, j - 1] + triangle[i - 1, j];
        }
    }
}

void PrintTriangle()
{
    for (int i = 0; i < row; i++)
    {
        for (int j = 1; j < row; j++)
        {
            if (triangle[i, j] != 0)
                Console.Write($"{triangle[i, j],cellWidth}");
        }
        Console.WriteLine();
    }
}

void MassTriangle()
{
    int col = cellWidth * row;
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j <= i; j++)
        {
            Console.SetCursorPosition(col, i + 1);
            if (triangle[i, j] % 2 != 0) Console.Write("0");
            col += cellWidth * 2;
        }
        col = cellWidth * row - cellWidth * (i + 1);
        Console.WriteLine();
    }
}
Console.ReadLine();
FillTriangle();
Console.ReadLine();
MassTriangle();
*/