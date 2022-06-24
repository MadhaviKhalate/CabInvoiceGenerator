using System;

namespace CabInvoice_Generator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Ride[] ride = { new Ride(10, 10), new Ride(10, 5) };
            CabInvoiceClass getMethod = new CabInvoiceClass();
            double fare = getMethod.MultipleRides(ride);
        }
    }
}