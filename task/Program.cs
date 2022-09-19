string[] initialArray = new string[6] { "yes", "hello", "456", "yellow", "9876", "56" };
string[] sortedArray = new string[initialArray.Length];
int count = 0;
void PerebArray(string[] initialArray, string[] sortedArray)
{
    
    for (int i = 0; i < initialArray.Length; i++)
    {
        if (initialArray[i].Length <= 3)
        {
            sortedArray[count] = initialArray[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
        ;
    Console.Write(string.Join(" , ", sortedArray, 0, count));
    Console.WriteLine();
}

PerebArray(initialArray, sortedArray);
PrintArray(sortedArray);

