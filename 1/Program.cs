// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами


Console.WriteLine (" Двумерный массив вещественных чисел");

// Создаем метод для ввода числа пользователем

int InputNum (string message)
{
    Console.Write (message);
    return Convert.ToInt32 (Console.ReadLine ());
}

// Создаем метод заполнения случайного двумерного массива вещественными числами

double [,] SetArray2Double (int line, int column)
{
    double [,] numArr2D = new double [line, column];
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            numArr2D [i, j] = new Random ().Next (0, 100) + new Random ().NextDouble (); // заполняем массив вещественными числами
            numArr2D [i, j] = Math.Round (numArr2D [i, j], 2); // округляем элементы массива до второго знака после запятой
        }
    }
    return numArr2D;
}

// Создаем метод вывода двумерного массива

void PrintArray2Double (double [,] array2D)
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

int m = InputNum ("Задайте кол-во строк: ");
int n = InputNum ("Задайте кол-во столбцов: ");

double [,] array = SetArray2Double (m, n);

Console.WriteLine ($"Ваш массив {m}x{n}:");
PrintArray2Double (array);