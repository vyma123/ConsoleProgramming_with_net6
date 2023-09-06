// See https://aka.ms/new-console-template for more information

int[] arr = new int[5];
//arr[0] = 1;
//arr[1] = 56;
//arr[2] = 57;
//arr[3] = 345;
//arr[4] = 5;

//arr = new int[] { 1, 56, 57, 345, 5 };

for (int i = 0;i < arr.Length; i++)
{
    Console.WriteLine("enter grade: ");
    arr[i] = Convert.ToInt32(Console.ReadLine());

}
Console.WriteLine("grade is: ");

for (int i = 0; i < arr.Length; i++)
{

    Console.Write(" "+arr[i]);

}

string[] studentNames = new string[] {"Test","Student1", "etc..."}