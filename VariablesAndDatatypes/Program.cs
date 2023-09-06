// See https://aka.ms/new-console-template for more information
string fullName = string.Empty;
int age;
double salary ;
char gender = char.MinValue;
bool working;

Console.WriteLine("name: ");
fullName = Console.ReadLine();

Console.WriteLine("age: ");
age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("salary: ");
salary = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("gender: ");
gender = Convert.ToChar(Console.ReadLine());
Console.WriteLine("working: ");
working = Convert.ToBoolean(Console.ReadLine());

Console.WriteLine("name is : "+fullName);
Console.WriteLine("age is :{0}hjh ", age);
Console.WriteLine($"salary is :{salary} " );
Console.WriteLine($"gender is :{gender} " );
Console.WriteLine($"working is : {working}" );

