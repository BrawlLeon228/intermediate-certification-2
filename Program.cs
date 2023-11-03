void WriteStringArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i<array.Length-1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length-1]}");
    Console.Write("]");
}

void deleteMoreThenThree(string[] arr)
{
    int[] indexes = new int[arr.Length-1];
    int k = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            indexes[k] = i;
            k+=1;
        }
    }

    string[] new_arr = new string[indexes.Length];

    for (int i = 0; i < indexes.Length; i++)
    {
        new_arr[i] = arr[indexes[i]];
    }

    WriteStringArray(new_arr);
}


string[] array = {"123", "Привет", "12"};

deleteMoreThenThree(array);