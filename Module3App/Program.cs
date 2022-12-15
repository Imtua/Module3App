Console.Write("Enter your name: ");
string myName = Console.ReadLine();

Console.Write("Enter your age: ");
int myAge = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Your name is {myName} and age is {myAge}");

Console.Write("Enter your birthdate: ");
string myDate = Console.ReadLine();
myDate = DateTime.Parse(myDate).ToShortDateString();
Console.WriteLine($"Your birthdate is {myDate}");


