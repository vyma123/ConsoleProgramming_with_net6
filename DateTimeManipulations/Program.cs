// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.WriteLine("Hello, World!");

//DateTime date = new DateTime();

//DateTime DateOfBirth = new DateTime(1999, 06, 16);
//Console.WriteLine("my date of birth is:"+DateOfBirth);

DateTime now =  DateTime.Now;
Console.WriteLine("the time now is: " + now);

DateTime datetimefromString = DateTime.Parse("1/31/1998", CultureInfo.InvariantCulture);
Console.WriteLine("the date from string is: " + datetimefromString);


Console.WriteLine("one hour from now is: " + now.AddHours(1));
Console.WriteLine("one day from now is: " + now.AddDays(1));


