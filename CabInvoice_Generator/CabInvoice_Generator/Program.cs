using System;

namespace CabInvoice_Generator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CabInvoiceClass getMethod = new CabInvoiceClass(10.0, 5);
            double fare = getMethod.CalculateFare();
            Console.WriteLine("Fare: " + fare);
        }
    }
}