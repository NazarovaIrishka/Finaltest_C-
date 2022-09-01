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