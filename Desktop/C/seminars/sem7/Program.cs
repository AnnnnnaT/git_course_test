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


// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = i+j. Выведите полученный массив на экран.

void ElementsChanging (int [,] array)
{
    for (int i = 0; i< array.GetLength(0); i++)
    {
        for  (int j = 0; j< array.GetLength(1); j++)
        array [i,j] = i + j;
    }
}

/*
int [,] myArray = Create2dArray();
Show2dArray(myArray);
ElementsChanging (myArray);
Console.WriteLine();
Show2dArray(myArray);
*/



// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

void SqrtElements (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i%2==0 && j%2==0)
            {
                array[i,j]*=array [i,j];
            }
        }
    }
}


/*
int [,] newArray = Create2dArray();
Show2dArray(newArray);
Console.WriteLine();
SqrtElements(newArray);
Show2dArray(newArray);
*/

//  Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

int Count (int[,] array)
{
    int count = 0;
    for (int i = 0; i <array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i==j && array.GetLength(0) == array.GetLength(1))
            {
                count+=array[i,j];
            }
           
        }
    }
    return count;
}

int [,] newArray = Create2dArray();
Show2dArray(newArray);
Console.WriteLine();
int count = Count (newArray);
Console.WriteLine(count);