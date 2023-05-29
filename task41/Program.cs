// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


int number = Prompt("Введите количество вводимых чисел: ");
int[] array = GetArray(number);
Console.WriteLine($"Количество положительных элементов равна {PositiveElements(array)}");


int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine()!;
    int result = Convert.ToInt32(value);
    return result;
}

int[] GetArray(int size)
{
    int[] arr = new int[size];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Prompt($"Введите {i + 1} число: ");
    }
    return arr;
}

int PositiveElements(int[] UserArray)
{
    int count = 0;
    for (int i = 0; i < UserArray.Length; i++)
    {
        if (UserArray[i] > 0) count++;
    }
    return count;
}