// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

/*
int Count (int n)
{
    string s = Convert.ToString(n);
    int l = s.Length;
    int sum =0;
    for (int i = 0; i <=l; i++)
    {
        sum+=i;
    }
    
    return sum;
}

Console.WriteLine("Input a number: ");
int r= Convert.ToInt32(Console.ReadLine());

int a = Count(r);
Console.WriteLine($"There are {a} numbers in {r}");


*/

// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

// void Res (int n)
// {  
//   int i = 1;
//  while (i<=n)
//  {      
//         int b = i+1;
//         int c =i*b;
//         i++;
//  }
// }

// Console.WriteLine("Input a number: ");
// int r= Convert.ToInt32(Console.ReadLine());

// Res(r);


int [] CreateRandomArray ( int size, int minValue, int maxValue)
{
   int [] newArray = new int [size];

   for (int i = 0; i < size; i++)
   {
    newArray[i] = new Random().Next(minValue, maxValue+1);
   }
   return newArray;
}

void ShowArray (int[] array)

{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}  ");
    }

    Console.WriteLine();
}


Console.WriteLine("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());

int min =0;
int max = 1;

int[] myArray = CreateRandomArray(size, min, max);

ShowArray (myArray);
