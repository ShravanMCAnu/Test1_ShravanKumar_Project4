using Test1_ShravanKumar_Project4;

public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter Principle Amount :");
        double principleAmount = Convert.ToDouble(Console.ReadLine());
        SimpleIntrest objSimpleIntrest=new SimpleIntrest();
        Console.WriteLine("Enter Rate Of Intrest: ");
        objSimpleIntrest.RateOfInterest = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter Time ");
        objSimpleIntrest.Time = Convert.ToDouble(Console.ReadLine()); 
        objSimpleIntrest.IntrestCalculation(principleAmount);
        Console.WriteLine("the Intrest of Principle Amount is : " + objSimpleIntrest.Intrest);
        Console.WriteLine("The Total Amount with Principle Amount and Intrest is : " + objSimpleIntrest.TotalAmount);

    }
}