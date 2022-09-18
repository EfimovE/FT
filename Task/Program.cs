string[] array = new string[4] {":)", "Russia", "123", "world"};
string[] array2 = new string[array.Length];

void CreateResultArray(string[] array, string[] array2)
{
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            array2[index] = array[i];
            index ++;
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
CreateResultArray(array, array2);
PrintArray(array);
PrintArray(array2);