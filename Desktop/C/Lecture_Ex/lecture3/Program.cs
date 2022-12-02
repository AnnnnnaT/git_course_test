// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

int[] CreateArray(int size, int min, int max)
{ 
  int[] newarray = new int [size];
  for (int i = 0; i < newarray.Length; i++)
  {
    newarray[i] =new Random().Next(min, max+1);
  }
  return newarray;
}

void Change (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]<0)
        {
            array[i]=-array[i];
        }
         if (array[i]>0)
        {
            array[i]=-array[i];
        }
    }
}

Console.WriteLine("Input size of array: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("min of array: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("max of array: ");
int d = Convert.ToInt32(Console.ReadLine());

int [] a =CreateArray(b, c, d);
Change(a);
