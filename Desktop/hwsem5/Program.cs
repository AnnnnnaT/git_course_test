// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

/*
int [] CreatingA (int size)
{   
    int [] array = new int [size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next (100, 1000);
    }
    return array;
}

void ShowArray (int []array)

{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int CountEven (int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2==0)
            count++;
            
    }
    return count;
}

Console.WriteLine("Input a number of elements in array: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreatingA(size);
ShowArray(myArray);

int c = CountEven(myArray);
Console.WriteLine("Number of even elements in array is " + c);
*/


// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

/*
int [] CreatingA (int size, int min, int max)
{
    int [] array = new int [size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next (min, max+1);
    }
    return array;
}

void ShowArray (int []array)

{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int Sum (int[] array)
{
    int sum =0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i%2==0)
        sum+=array[i];
    }
    return sum;
}

Console.WriteLine("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Input min element: ");
int a = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Input max element: ");
int b = Convert.ToInt32(Console.ReadLine());

int [] newArray = CreatingA(size, a, b);
ShowArray(newArray);

Console.WriteLine();

int s =Sum(newArray);
Console.WriteLine(s);

*/

//  Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

/*
double [] CreateA (int size)
{
    double [] array = new double [size];
    Console.WriteLine("Creating new array: ");
    for (int i = 0; i <size; i++)
    {
        Console.Write($"Input a {i+1} element of array: " );
        array[i] = Convert.ToDouble(Console.ReadLine());
    }
    Console.WriteLine("Complete!");
    return array;
}

void ShowArray (double []array)

{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

double FindMin (double [] array)
{ 
    double min = array [0];
    
    for (int i = 0; i < array.Length; i++)
    {  
        
        if (array[i]< min)
           min =array[i];
          
    }
       
    return min;
}


double FindMax (double [] array)
{ 
   
    double max = array [0];
    
    for (int i = 0; i < array.Length; i++)
    {  
        
        if (array[i]> max)
           max =array[i];
           

    }
       
    return max;
}


Console.WriteLine("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());

double [] newArray = CreateA(size);
ShowArray(newArray);

Console.WriteLine();

double max = FindMax(newArray);
Console.WriteLine(max);
Console.WriteLine();


double min = FindMin(newArray);
Console.WriteLine(min);
Console.WriteLine();

Console.WriteLine($"The difference between max  and min elements: {max-min}");
*/
