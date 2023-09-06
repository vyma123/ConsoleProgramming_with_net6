// See https://aka.ms/new-console-template for more information

Person person = new();

Console.WriteLine("enter your first name: ");
person.FirstName = Console.ReadLine();

Console.WriteLine("enter your last name: ");
person.LastName = Console.ReadLine();

Console.WriteLine("enter your age: ");
person.Age = Convert.ToInt32(Console.ReadLine());

int salary = Convert.ToInt32(Console.ReadLine());  

person.setSalary(salary);

Console.WriteLine("First name is: " + person.FirstName);
Console.WriteLine("last name is: " + person.LastName);
Console.WriteLine("age is: " + person.Age);
Console.WriteLine("salary is: " + person.getSalary());