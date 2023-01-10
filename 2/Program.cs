// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве 
// и возвращает значение этого элемента или же указание, что такого элемента нет. 
// Во вводе первая цифра - номер строки, вторая - столбца.

Console.WriteLine ("Вывод элемента двумерного массива");

// Создаем метод для ввода числа пользователем

int InputNum (string message)
{
    Console.Write (message);
    return Convert.ToInt32 (Console.ReadLine ());
}

// Создаем метод заполнения случайного двумерного массива

int [,] SetArray2DInt (int line, int column)
{
    int [,] numArr2D = new int [line, column];
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            numArr2D [i, j] = new Random ().Next (0, 100); // заполняем массив 
        }
    }
    return numArr2D;
}

// Создаем метод вывода двумерного массива

void PrintArray2DInt (int [,] array2D)
{
    for (int i = 0; i < array2D.GetLength (0); i++)
    {
        for (int j = 0; j < array2D.GetLength (1); j++)
        {
            Console.Write (array2D [i, j] + " ");
        }
        Console.WriteLine ();
    }
}

// Создаем метод перевода числа в цифры

int [] FindInx (int number)
{
    int [] idxArr = new int [2];
    idxArr [0] = number / 10;
    idxArr [1] = number % 10;
    return idxArr;
}

// Создаем метод вывода элемента двумерного массива

void PrintUnitArr (int [,] array2D, int [] array)
{
    if (array [0] > array2D.GetLength (0) || array [1] > array2D.GetLength (1))
    {
        Console.WriteLine ($"Такого элемента нет в массиве, строка {array [0]} столбец {array [1]}");
    }
    else
    {
        Console.WriteLine ($"Ваш элемент: {array2D [array[0] - 1, array [1] - 1]}");
    }
}

int m = InputNum ("Задайте кол-во строк: ");
int n = InputNum ("Задайте кол-во столбцов: ");

int [,] array = SetArray2DInt (m, n);

Console.WriteLine ($"Ваш массив {m}x{n}:");
PrintArray2DInt (array);

int num = InputNum ("Введите двухзначный индекс ячейки: ");
int [] index = FindInx (num);

PrintUnitArr (array, index);