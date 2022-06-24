using System;

namespace CabInvoice_Generator
{
    public class Tests
    {
        [Test]
        public void GivenDistanceAndTime_ShouldReturnExpectedTotalFare()
        {
            double distance = 10;
            int time = 10, expected = 110;
            CabInvoiceClass getMethod = new CabInvoiceClass();
            Ride ride = new Ride(distance, time);
            Assert.AreEqual(expected, getMethod.CalculateFare(ride));
        }
        [Test]
        public void GivenMultipleRideData_ShouldReturnExpectedTotalFare()
        {
            int expected = 215;
            CabInvoiceClass getMethod = new CabInvoiceClass();
            Ride[] ride = { new Ride(10, 10), new Ride(10, 5) };
            Assert.AreEqual(expected, getMethod.MultipleRides(ride));
        }
    }
}