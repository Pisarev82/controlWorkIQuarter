// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] arr = {"Hlo", "вррза", "", ":-)"};

void PrintArray (string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i !=array.Length -1) Console.Write($"“{array[i]}”, ");
        else Console.Write($"“{array[i]}”]");
    }
}

string[] Select3CharItems (string[] array)
{
    int sizeResultArray = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) sizeResultArray++;
    }
    string[] resultArray = new string[sizeResultArray];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) 
        {
            for (int j = 0; j < resultArray.Length; j++)
            {
                if(resultArray[j] is null) 
                {
                    resultArray[j] = array[i];
                    break;
                }
            }
        }
    }
    return resultArray;
}


PrintArray(arr);
Console.Write("  →  ");
PrintArray(Select3CharItems(arr));
