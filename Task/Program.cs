Console.Write("Количество вводимых данных: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] array = CreateArrayInt(size);
PrintArray(array);
string[] result = ArrayLessThreeChar(array);
PrintArray(result);


string[] CreateArrayInt(int arrSize)
{
    string[] arr = new string[arrSize];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Введите числа (через Enter): ");
        arr[i] = Console.ReadLine();
    }
    return arr;
}

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]},");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

static string[] ArrayLessThreeChar(string[] arr)
{
    
}