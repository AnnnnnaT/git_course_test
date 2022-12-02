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
    Console.WriteLine();
}



void ChangeArray (int [,] array)
{
    if (array.GetLength(0) == array.GetLength(1))
    {
        for (int i = 0; i < array.GetLength(0) -1; i++)
        {
            for (int j = i +1; j <array.GetLength(1); j++)
            {
                int temp = array [i,j];
                array [i,j] = array [j,i];
                array [j,i] = temp;
            }
        }
    }
    else
    Console.WriteLine("It's impossible");
}


// int [,] newArray = Create2dArray();
// Show2dArray (newArray);
// ChangeArray (newArray);
// Show2dArray (newArray);



// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

void ChangeStringsArray (int [,] array)
{
        int i = 0;
        int j =0;
        while (i < array.GetLength(0) && j <array.GetLength(1))
            {
                int k = array.GetLength(0)-1;
                int temp = array [i,j];
                array [i,j] = array [k,j];
                array [k,j] = temp;
                j++;
            }
}

// int [,] newArray = Create2dArray();
// Show2dArray (newArray);
// ChangeStringsArray (newArray);
// Show2dArray (newArray);

// Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент

int [,] DelMinNumArray (int [,] array)
{
    int min = array [0,0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
          
         if (array[i,j] < min)
         {
           array [i,j] = min;
           int iMin= i;
           int jMin=j;
           int [,] newArray = new int [array.GetLength(0)-1, array.GetLength(1)-1];

            for (int k = 0; k < array.GetLength(0)-1 && k!=iMin; k++)
            {
                for (int l = 0; l < array.GetLength(1)-1 && l!=jMin; l++)
                
            }

        }
    }
    return newArray;
    
 }





int [,] newArray = Create2dArray();
Show2dArray (newArray);
int[,] newArray2 = DelMinNumArray(newArray);
Show2dArray (newArray2);
