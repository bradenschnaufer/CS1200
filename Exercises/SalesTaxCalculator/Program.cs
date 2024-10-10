using System.Text;



ConsoleApplication.Run();

public class ConsoleApplication
{
    public static void Run()
    {
        
        //get purchase price
      Console.Write("Enter the purchase price: ");
       //parse price
       double price = double.Parse(Console.ReadLine());

    //     //enter tax rate
        Console.Write("Enter the tax rate: ");
        //parse tax rate
        double tax = double.Parse(Console.ReadLine());
        double taxTotal = ((price * tax) /100) ;
      // decimal totalprice = (tax + price);
    //    Console.WriteLine($"{price}");
    //    Console.WriteLine("{0}", tax);
        double totalprice = taxTotal + price;
        Console.WriteLine($"\nFor your {price:C2} purchase, a {tax}% tax is {taxTotal:C2} for a total of {totalprice:C2}.");
    }
}
