Console.Write("Количество вводимых данных: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] array = CreateArrayString(size);
PrintArray(array);
int sizeNewArray = ArrLessThreeCharSize(array);
string[] result = ArrayLessThreeChar(array, sizeNewArray);
PrintArray(result);


string[] CreateArrayString (int arrSize)
{
    string[] arr = new string[arrSize];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write("Введите данные через enter: ", i);
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

int ArrLessThreeCharSize(string[] arr)
{
    int newSize = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length < 3) 
        newSize++;
    }
    return newSize;
}

string[] ArrayLessThreeChar(string[] arr, int newSize)
{
    int j = 0;
    string[] newArr = new string[newSize];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length < 3)
        {
            newArr[j] = arr[i];
            j++;
        }
    }
    return newArr;
}