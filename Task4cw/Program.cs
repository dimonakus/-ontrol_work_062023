//Задача: Написать программу, которая
//из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам.
//Первоначальный массив можно ввести с клавиатуры,
//либо задать на старте выполнения алгоритма.
//При решении не рекомендуется пользоваться коллекциями,
//лучше обойтись исключительно массивами.

void FormatTextArray(string[] arr1, string[] arr2)
{
    int count = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i].Length <= 3)
        {
            arr2[count] = arr1[i];
            count++;
        }
    }
}

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

Console.Write("Программой задан массив строк: ");
string[] textArray = new string[6] { "Лев", "23", "Привет", "Бал", "Кукиш", "Ррр" };
string[] formatTextArray = new string[textArray.Length];
FormatTextArray(textArray, formatTextArray);
PrintArray(textArray);
Console.Write("Результат работы программы - отбор строк с количеством символом менее или равным трех: ");
PrintArray(formatTextArray);
