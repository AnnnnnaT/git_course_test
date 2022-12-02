//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

/*
double Degree (int a, int b)
{
   double d = Math.Pow(a,b);
   return d;
}

Console.WriteLine("Input 1st number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number as a degree: ");
int b = Convert.ToInt32(Console.ReadLine());

double res = Degree (a,b);
Console.WriteLine($"{a} in {b} degree is {res}");
*/

// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/*
int Sum (int a)
{
   
   if (a< 0)
   {
      a*=-1;
   }
   int sum = 0;
   while (a>0)
   {
    sum+=a%10;
    a/=10;    
   }
   return sum;
}

 Console.WriteLine("Input a number: ");
 int n = Convert.ToInt32(Console.ReadLine());
 int x = Sum(n);
Console.WriteLine(x);
*/


//  Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

// int [] RandomArray (int size, int min, int max)
// {
//    int[] newArray = new int [size];
//    for (int i = 0; i <size; i++)
//    {
//       newArray[i]= new Random().Next(min, max+1);
//    }
//    return newArray;
// }

// void ShowArray (int[]array)
// {
//    for (int i = 0; i < array.Length; i++)
//    {
//       Console.WriteLine(array[i] + " ");
//    }
//    Console.WriteLine();
// }

// Console.WriteLine("Input number as a size of array: ");
// int s = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input min number of array: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max number of array: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int [] res = RandomArray(s,min,max);
// Console.Write(res);
// ShowArray(res);
