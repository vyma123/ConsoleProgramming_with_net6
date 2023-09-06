// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.WriteLine("Hello, World!");
string firstName = "John";
string lastName = "Smilga";

DateTime date = DateTime.Now;

int length = firstName.Length;
Console.WriteLine($"Your name is {length} letters long");

string newName = firstName.Replace("J", "");

Console.WriteLine($"new name is {newName} ");
string fullName = firstName + " "+lastName;
Console.WriteLine($"fullName {fullName} ");

string[] splitName = fullName.Split('o');
for(int i = 0;i < splitName.Length; i++)
{
    Console.WriteLine(splitName[i]);

}

string nullStr = null;

if (string.IsNullOrEmpty(nullStr))
{
    Console.WriteLine("string is null");
}

int comparisonR = string.Compare(firstName, lastName);
if (comparisonR == 0)
{
    Console.WriteLine("names are equal");
}
else
{
    Console.WriteLine("names are not equal");

}