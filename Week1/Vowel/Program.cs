using System;




System.Console.WriteLine("Please enter a single character: ");
char letter = char.Parse(Console.ReadLine());
letter = char.ToLower(letter);
switch(letter)
{
    case 'a':
    case 'e':
    case 'i':
    case 'o':
    case 'u':
    System.Console.WriteLine("Vowel");
    break;
    case 'y':
    System.Console.WriteLine("Maybe");
    break;
    default:
    System.Console.WriteLine("Not a vowel.");
    break;
}
