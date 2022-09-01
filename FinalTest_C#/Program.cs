string [] CreateAndFillArray ()
{
    Console.Write("Enter the number of array elements: ");
    int size = Convert.ToInt32(Console.ReadLine());
    string[] Array1 = new string[size]; 
    for (int i = 0; i < Array1.Length; i++)
    {
        Console.Write("Enter array element: ");
        Array1 [i] = Console.ReadLine();
    }
    return Array1;
}


string [] SelectiveArray(string[] Array)
{
    string[] NewArray = new string[Array.Length];
    int count = 0;
    for (int i = 0; i < Array.Length; i++)
    {
    if(Array[i].Length <= 3)
        {
        NewArray[count] = Array[i];
        count++;
        }
    }
    return NewArray;
}


void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write( $"{array[i]} ");
    }
    Console.WriteLine();
}


string [] MyArray = CreateAndFillArray(); 
PrintArray(MyArray);
string [] Array2 = SelectiveArray(MyArray);
PrintArray(Array2);
