
string GetNewString()
{
    string a = Convert.ToString(Console.ReadLine());
    return a;
}

string[] FillStringArray()
{
    string[] arr = new string [0];
    string b = "a";
    for (int i = 0; (b = GetNewString()) != " "; i++)
    {
        Array.Resize(ref arr, i);
        arr[i] = b;
    }
    return arr;
}

string[] FilterArray(string[] a)
{
    string[] b = new string[0];
    int j = 0;
    for (int i = 0; i < a.Length; i++)
    {
        if (a[i].Length <= 3)
        {
            Array.Resize(ref b, j + 1);
            b[j] = a[i];
            j +=1;
        }
    }
    return b;
}

void PrintArray(string[] arr)
{
    Console.Write($"{arr[0]}");
    for (int i = 1; i < arr.Length; i++)
    {
        Console.Write($", {arr[i]}");
    }
}

string[] a = FillStringArray();
PrintArray(a);
string[] b = FilterArray(a);
PrintArray(b);

