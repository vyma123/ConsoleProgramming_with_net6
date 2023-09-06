// See https://aka.ms/new-console-template for more information
Console.WriteLine("enter first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("enter first number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
try
{

int quotient = num1 / num2;
    Console.WriteLine("Result is: " + quotient.ToString());

}
catch(DivideByZeroException ex) {
    Console.WriteLine($"Illegal Operation: {ex.Message}");
}
catch (Exception ex)
{
    throw ex;
}
finally
{
    Console.WriteLine("This is finally block");

}

