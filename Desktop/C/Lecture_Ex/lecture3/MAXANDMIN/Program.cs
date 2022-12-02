/*int[] arr = {1, 3, 5, 6, 7, 9, 1, 1, 4, 8};

void PrintArray (int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
            Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
    
}

PrintArray(arr);

void SelectionSort (int[] array)
{
    for (int i  = 0; i < array.Length; i ++)
    {
        int minPos = i;
        for (int j = i+1; j < array.Length; j++)
        {
            if (array[j]<array[minPos])
            minPos=j;
        }

        int temporary =array[i];
        array[i]=array[minPos];
        array[minPos]= temporary;
    }
}

SelectionSort(arr);
*/

int[] arr = {1, 3, 5, 6, 7, 9, 1, 1, 4, 8};

void Sort(int[] array)
{
 int length = array.Length;
 for (int i = 0; i < length -1; i++)
 {
 int max = array [i];
 for (int j = i + 1; j < length; j++)
 {
 if (array[j] > array[i])
 max = array[j];
 }
 int space = array[i];
 array[i] = array[max];
 array[max] = space;
 }
}
Sort(arr);
