// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

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

string a = FillStringArray;

PrintArray(a);
FilterArray(a);
PrintArray(a);

