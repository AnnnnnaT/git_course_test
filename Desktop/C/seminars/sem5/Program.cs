int [] CreateArray (int size)
{
    int [] array = new int [size];
    Console.WriteLine("Creating new array: ");
    for (int i = 0; i <size; i++)
    {
        Console.Write($"Input a {i+1} element of array: " );
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("Complete!");
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

int SumOfNegatives ( int [] array)

{
    int sum=0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]<0)
        sum+=array[i];
    }
    return sum;
}

/*
Console.WriteLine("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateArray(size);
ShowArray(myArray);

int sumON = SumOfNegatives(myArray);
Console.WriteLine("Sum ofnegative elements is" + sumON);
*/



int [] CreatingA (int size, int min, int max)
{
    int [] array = new int [size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next (min, max+1);
    }
    return array;
}

int [] Change (int [] array)

{
        for (int i = 0; i < array.Length; i++)
    {        
        array[i]*=-1;
    }
    
    return array;
}


// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот
/*
Console.WriteLine("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Input min element: ");
int a = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Input max element: ");
int b = Convert.ToInt32(Console.ReadLine());

int [] newArray = CreatingA(size, a, b);
ShowArray(newArray);

int [] changed = Change(newArray);
ShowArray(changed);
*/

// Напишите программу, которая определяет, присутствует ли заданное число в массиве.

bool Check (int[] array, int a)
{
    bool find = false;
    for (int i = 0; i < array.Length; i++)
    {
       if (array[i]==a)
       {
        find = true;
        break;
       }
    }
    return find;
}

/*


bool x = Check(newArray, c);
Console.WriteLine(x);
*/

// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

int Count (int [] array, int min, int max)
{
    int count=0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >=min && array [i] <=max)
        count++;
    }
    return count;
}


Console.WriteLine("Input min element: ");
int a = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Input max element: ");
int b = Convert.ToInt32(Console.ReadLine());

int [] newArray = CreatingA(12, a, b);
ShowArray(newArray);

Console.WriteLine("Input min element of range: ");
int min = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Input max element of range: ");
int max = Convert.ToInt32(Console.ReadLine());


int c = Count(newArray, min, max);
Console.WriteLine(c);
