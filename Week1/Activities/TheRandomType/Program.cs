using System;

Random rand = new Random();
int dye1 = rand.Next(1,7);
int dye2 = rand.Next(1,7);
// int dye1 = 1;
// int dye2 = 1;
// System.Console.WriteLine(dye1);
// System.Console.WriteLine(dye2);

if(dye1+dye2 == 2)
{
    System.Console.WriteLine("You rolled ", dye1, ",", dye2);
    System.Console.WriteLine("Snake Eyes!");
}
else if(dye1==6 && dye2 == 6)
{
    System.Console.WriteLine("You rolled ", dye1, ",", dye2);
    System.Console.WriteLine("Box Cars!");
}
else
{
    System.Console.WriteLine("You rolled {0}, {1}", dye1, dye2);
    System.Console.WriteLine($"{dye1+dye2}");

}

https://github.com/bradenschnaufer/CS1200