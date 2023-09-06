// See https://aka.ms/new-console-template for more information


Console.WriteLine("number apples: ");
int numberOfApples = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("number oranges: ");
int numberOfOranges = Convert.ToInt32(Console.ReadLine());

int grade = Convert.ToInt32(Console.ReadLine());

switch(grade)
{
    case int n when n <= 60 && n>0:
        Console.WriteLine("you failed");
        break;
    case int n when n > 60 && n<101:
        Console.WriteLine("you passed");
        break;
    case 101:
        Console.WriteLine("single case example");
        break;
    default: Console.WriteLine("Invalid grade");
            break;
}