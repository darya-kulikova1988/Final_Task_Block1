string[] WatchArray(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i].Length < 4)
        {
            count++;
        }
    string[] newArray = new string[count];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}

void ShowArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"'{array[i]}', ");
    }
    Console.Write($"'{array[array.Length - 1]}']");
}

string[] Array = {"hello", "2", "world", ":-)", "1234", "1567", "-2",
"computer science","Russia", "Kazan", "new"};
Console.Write("[");
Console.Write(string.Join(", ", Array));
Console.Write("] -- > ");
ShowArray(WatchArray(Array));


// Решение с несколькими массивами:
// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] res = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         res[i] = new Random().Next(minValue, maxValue);
//     }
//     return res;
// }

// void ShowArray(int[] inArray)
// {
//     if (inArray.Length < 4)
//     {
//         Console.Write("'");
//         for (int i = 0; i < inArray.Length; i++)
//         {
//             Console.Write(inArray[i]);
//         }
//         Console.Write("', ");
//     }
// }

// int[] array = GetArray(5, 0, 10);
// Console.Write(string.Join("", array));
// Console.Write(" ");
// int[] array1 = GetArray(2, 0, 10);
// Console.Write(string.Join("", array1));
// Console.Write(" ");
// int[] array2 = GetArray(1, 0, 10);
// Console.Write(string.Join("", array2));
// Console.Write(" ");
// Console.Write("-->");
// ShowArray(array);
// ShowArray(array1);
// ShowArray(array2);
