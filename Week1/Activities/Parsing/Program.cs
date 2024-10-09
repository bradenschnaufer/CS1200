System.Console.WriteLine("Enter an integer: ");
int num1 = int.Parse(Console.ReadLine());

System.Console.WriteLine("Enter a decimal: ");
decimal num2 = decimal.Parse(Console.ReadLine());

System.Console.WriteLine("Enter a boolean (true/false): ");
bool val = bool.Parse(Console.ReadLine());

System.Console.WriteLine("You entered " + num1 + "," + num2 + ", and " + val);
