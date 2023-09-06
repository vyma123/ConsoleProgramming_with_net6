// See https://aka.ms/new-console-template for more information
List<string> names = new List<string>();
string name = string.Empty;

names.Add("John");

Console.WriteLine("enter names: ");

while(!name.Equals("-1"))
{
    Console.WriteLine("Enter Name: ");
    name = Console.ReadLine();
    names.Add(name);
    if(!string.IsNullOrEmpty(name) && !name.Equals("-1")){
        Console.Write($"{name} was added successfully");
        names.Add(name);
    }

}
Console.WriteLine("printing: ");

for(int i = 0; i < names.Count; i++)
{
    Console.WriteLine(names[i]);
}

Console.WriteLine("printing foreach: ");
foreach(string item in names)
{
    Console.WriteLine(item);
}

