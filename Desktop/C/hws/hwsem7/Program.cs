int [,] Create2dArray ()
{ 
    Console.WriteLine("Input number of rows: ");
    int rows =Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input number ofcolumns: ");
    int columns =Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input min number of 2d array: ");
    int min =Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input max number of 2d array: ");
    int max =Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    int [,] array = new int [rows, columns];
    for (int i = 0; i< rows; i++)
    {
        for  (int j = 0; j< columns; j++)
        array [i,j] = new Random().Next(min, max+1);
    }

    return array;
    
}

void Show2dArray (int [,] array)
{
    for (int i = 0; i< array.GetLength(0); i++)
    {
        for  (int j = 0; j< array.GetLength(1); j++)
       {    
            Console.Write(array [i,j] + " ");
       }

      Console.WriteLine();
    }
    
}

/*
double [,] Create2dArray ()
{ 
    Console.WriteLine("Input number of rows: ");
    int rows =Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input number ofcolumns: ");
    int columns =Convert.ToInt32(Console.ReadLine());

    double [,] array = new double[rows, columns];
    for (int i = 0; i< rows; i++)
    {
        for  (int j = 0; j< columns; j++)
        array [i,j] = new Random().NextDouble();
    }

    return array;
    
}
*/

void Show2dDoubleArray (double [,] array)
{
    for (int i = 0; i< array.GetLength(0); i++)
    {
        for  (int j = 0; j< array.GetLength(1); j++)
       {    
            Console.Write(array [i,j] + " ");
       }

      Console.WriteLine();
    }
    
}

// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// double [,] myArray = Create2dArray();
// Show2dArray(myArray);

// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.

void FindElement (int[,] array)
{
   Console.WriteLine("Input 1st index of element: ");
   int a = Convert.ToInt32(Console.ReadLine());
   Console.WriteLine("Input 2nd index of element: ");
   int b = Convert.ToInt32(Console.ReadLine());
   
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (a>=0 && b>=0 && a==i && b==j)
            {
                Console.WriteLine($"Element with index {a} and {b} is {array[a,b]}");
            }
                      

                          
        }
       
    }
    if(a<0 || b<0 || a!=i || b!=j)

     Console.WriteLine("There is no element with such indexes");
           
}

int [,] myArray = Create2dArray();
Show2dArray(myArray);
Console.WriteLine();
FindElement(myArray);

//  Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.