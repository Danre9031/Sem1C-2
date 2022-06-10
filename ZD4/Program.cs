// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

/*int CTD (int f, int s)
{
    return f*10+s;
}
*/

/*int CheckMultiply(int a, int b)
{
    return a % b == 0;
}
*/

/*int FMaxD(int n)
{
    int max = 0;
    while (n>0)
    {
        int ld=n%10;
        if (ld>max)
        {
            max=ld;
        }
        n=n%10;
    }
    return max;
}
*/
int numberA = Input("Введите число: ");
int numberB = Input("Введите число2: ");
int result = numberB * numberB;
int result2 = numberA * numberA;
if(result == numberA || result2 == numberB) 
{
    Console.Write("Квадрат");
}
else 
{
Console.Write($"Не квадрат");
}