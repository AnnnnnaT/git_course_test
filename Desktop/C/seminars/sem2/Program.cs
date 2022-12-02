// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
/*
int FindBiggestDigit (int num)


{
    int max;
    int ed = num % 10;
    int dec = num / 10;

    if (ed>dec)
        max = ed;
    else
       max = dec;

    return max;
 }

int number = new Random().Next(10,100);
int biggestDigit = FindBiggestDigit(number);

 Console.WriteLine($"The biggest digit of {number} is {biggestDigit}");
 */

 //Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

/*
int TwoDigitNumber (int num)
{
    int ed = num % 10;
    int dec = num / 100;
    int result = dec*10 + ed;
    
    return result;
 }

int number = new Random().Next(100,1000);
int result = TwoDigitNumber(number);

 Console.WriteLine($"Number is {result}");
 */
// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно a и b.a и b - инфо от пользователя(тоже int)

bool Check (int a, int b, int num)

{   
    bool result;
    if (num%a==0 && num%b==00)
      result = true;
    else
       result = false;
    return result;
 }
 Console.Write("Input number ");
 int num Convert.ToInt32 (Console.ReadLine());
 Console.Write("Input  1st diider ");
 int a Convert.ToInt32 (Console.ReadLine());
 Console.Write("Input 2nd divider");
 int b Convert.ToInt32 (Console.ReadLine());
 bool res = Check (num, a, b);
 Console.WriteLine(res);
 