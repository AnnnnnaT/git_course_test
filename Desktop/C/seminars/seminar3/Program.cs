
// if (a<1 & a>4) Console.WriteLine("not exist")
void FindQuart (int a)
{
    if (a==1) Console.WriteLine("x>0, y>0");
    if (a==2) Console.WriteLine("x<0, y>0");
    if (a==3) Console.WriteLine("x<0, y<0");
    if (a==4) Console.WriteLine("x>0, y<0");
    else Console.WriteLine("doesn't exist");
}
Console.WriteLine("Input a number of the quarter: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("The area of choosen quart: ");
FindQuart(x);