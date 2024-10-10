

ConsoleApplication.Run();

public class ConsoleApplication
{

    public static void Run()
    {
        const float Pi = 3.1415926535897931f;
        Console.Write("What type of shape (R)ectangle, (T)riangle, or (C)ircle?");
        string shape = Console.ReadLine();

        switch (shape[0])
        {
            case 'R':
                System.Console.Write("Enter the length: ");
                float Rlength = float.Parse(Console.ReadLine());
                System.Console.Write("Enter the width: ");
                float Rwidth = float.Parse(Console.ReadLine());
                float Rarea = Rlength * Rwidth;
                Console.WriteLine($"The area of this rectangle is {Rarea:F2}.");
                break;
            case 'T':
                System.Console.Write("Enter the base: ");
                float Tbase = float.Parse(Console.ReadLine());
                System.Console.Write("Enter the height: ");
                float Theight = float.Parse(Console.ReadLine());
                float Tarea = ((Tbase * Theight) / 2);
                System.Console.WriteLine($"The area of this triangle is {Tarea:F2}.");
                break;
            case 'C':
                System.Console.Write("Enter the radius: ");
                float Cradius = float.Parse(Console.ReadLine());
                float Carea = Pi * (Cradius * Cradius);
                System.Console.WriteLine($"The area of this circle is {Carea:F2}.");
                break;
            default:
                System.Console.WriteLine("Invalid shape type!");
                break;
        }
    }
}
