// Написать программу, которая 
//из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равно 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []



string[] mainString = MainStringArray();
PrintArray(mainString);
string[] mewString = NewStringArray(mainString);
PrintArray(mewString);


string[] MainStringArray()
{
    string[] arrayString = new string[] { "hello", "2", "world", ":-)" };
    return arrayString;
}

string[] NewStringArray(string[] array)
{
    string temp;
    string[] newStringArray = new string[array.Length];

for (int i = 0; i < array.Length; i++)
{
    temp = array[i];
    if (temp.Length <= 3) newStringArray[i] = array[i];
}
return newStringArray;
}

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ",");
        else Console.Write(arr[i]);
    }
    Console.Write("]");
}
