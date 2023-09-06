// See https://aka.ms/new-console-template for more information
public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    private double _salary { get; set; }

    public void setSalary(double salary)
    {
        _salary = salary;
    }

    public double getSalary()
    {
        return _salary;
    }

}