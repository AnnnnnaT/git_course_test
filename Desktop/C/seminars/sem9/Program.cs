void ShowNums (int n)
{
    if (n>1) ShowNums(n-1);
    Console.Write(n + " ");
}

ShowNums(5);

// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

void ShowRowMN (int n, int m)
{
    if (m<n && m>0) ShowRowMN (m+1);
    Console.Write(n);
}