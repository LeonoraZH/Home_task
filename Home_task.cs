string[] arrey = new string[6];

FillArrey(arrey);

string[] arreyResult = new string[CountElements(arrey)];

FillResult(arrey, arreyResult);

PrintArrey(arrey);
Console.Write("-->");
PrintArrey(arreyResult);

void PrintArrey(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
        Console.Write(arr[i] + " ");
    Console.Write("]");
}

void FillArrey(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine("Please, enter a string : ");
        arr[i] = Convert.ToString(Console.ReadLine());
    }
}

int CountElements(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}


void FillResult(string[] arr, string[] arrResult)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            arrResult[count] = arr[i];
            count++;
        }
    }
}







