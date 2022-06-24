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
            double expected = 325;
            CabInvoiceClass getMethod = new CabInvoiceClass();
            Ride[] ride = { new Ride(10, 10), new Ride(10, 5), new Ride(10, 10) };
            EnhancedInvoice result = getMethod.MultipleRides(ride);
            Assert.AreEqual(expected, result.totalFare);
        }
        [Test]
        public void GivenMultipleRideData_ShouldReturnExpectedTotalFare_numberOfRides_AverageFare()
        {
            CabInvoiceClass getMethod = new CabInvoiceClass();
            Ride[] ride = { new Ride(10, 10), new Ride(10, 5), new Ride(10, 10) };
            double totalFate = 325, numberOfRides = ride.Length, averageFare = totalFate / numberOfRides;
            EnhancedInvoice result = getMethod.MultipleRides(ride);
            Assert.AreEqual(totalFate, result.totalFare);
            Assert.AreEqual(averageFare, result.averageFare);
            Assert.AreEqual(numberOfRides, result.numberOfRides);
        }
        [Test]
        public void GivenUserID_ShouldReturnExpectedTotalFare_numberOfRides_AverageFare()
        {
            RideRepository rideRepository = new RideRepository();
            Ride[] ride = { new Ride(10, 10), new Ride(10, 5), new Ride(10, 10) };
            double totalFare = 325, numberOfRides = ride.Length, averageFare = totalFare / numberOfRides;
            rideRepository.AddRides("Ela", ride);
            var result = rideRepository.UserInvoice("Ela");
            Assert.AreEqual(totalFare, result.totalFare);
            Assert.AreEqual(averageFare, result.averageFare);
            Assert.AreEqual(numberOfRides, result.numberOfRides);
        }
    }
}