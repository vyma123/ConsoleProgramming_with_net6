// See https://aka.ms/new-console-template for more information

int printN(int num1, int num2, int num3)
{
    int largest = num1;
    if(largest< num2)
    {
        largest = num2;
    }
     if (largest < num3)
    {
        largest = num3;
    }
    return largest;

}

Console.WriteLine("input number 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input number 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input number 3: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int result = printN(num1, num2, num3);
Console.WriteLine($"{result}");
