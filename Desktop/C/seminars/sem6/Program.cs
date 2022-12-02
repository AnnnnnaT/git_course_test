// Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)

void ShowArray (int []array)

{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int [] CreatingA ()
{

    Console.WriteLine("Input a number of elements: ");
    int size = Convert.ToInt32(Console.ReadLine());


    Console.WriteLine("Input min element: ");
    int min = Convert.ToInt32(Console.ReadLine());


    Console.WriteLine("Input max element: ");
    int max = Convert.ToInt32(Console.ReadLine());

    int [] array = new int [size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next (min, max+1);
    }
    return array;
}

void ReversedArray (int[] array)

{
    for (int i = 0, last = array.Length-1; i < last; i++, last--)
    {
        int temp = array[i];
        array[i] = array [last];
        array[last] = array [i];
    }
}

/*
int [] myArray = CreatingA();
ShowArray(myArray);
ReversedArray(myArray);
ShowArray(myArray);
*/

// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

/*
bool Check (int a, int b, int c)
{
    bool check = true;
    if(a<b+c && b<a+c && c<b+a)
    return check;
    else
    return false;

}

Console.WriteLine("Inpur size of 1st side: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Inpur size of 2nd side: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Inpur size of 3rd side: ");
int c = Convert.ToInt32(Console.ReadLine());

bool check = Check(a,b,c);
Console.WriteLine(check);
*/

// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.


int [] CopyArray (int [] array)
{
    int [] newarray = new int [array.Length];
    for (int i = 0; i < array.Length; i++)
    {
       newarray[i] = array [i];
    }
    return newarray;
}

/*
int [] Array = (CreatingA());
ShowArray(Array);
int [] newArray = (CopyArray(Array));
ShowArray(newArray);
*/

// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.


int [] Fibonacci (int N, int a, int b)
{
    int [] array = new int [N];
    array [0] =a;
    array [1] =b;

    for (int i = 2; i < N; i++)
    {
        array[i] = array[i-1]+array[i-2];
    }
    return array;
}

Console.WriteLine("Input number of Fibonacci numbers: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input 1st number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input 2nd number: ");
int b = Convert.ToInt32(Console.ReadLine());

int [] F = Fibonacci(c,a,b);
ShowArray(F);
