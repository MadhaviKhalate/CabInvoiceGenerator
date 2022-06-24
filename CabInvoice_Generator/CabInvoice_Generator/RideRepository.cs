using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoice_Generator
{
    public class RideRepository
    {
        Dictionary<string, List<Ride>> user;
        public RideRepository()
        {
            this.user = new Dictionary<string, List<Ride>>();
        }
        public void AddRides(string userid, Ride[] rides)
        {
            bool result = this.user.ContainsKey(userid);
            try
            {
                if (!result)
                {
                    List<Ride> list = new List<Ride>();
                    list.AddRange(rides);
                    user.Add(userid, list);
                }
            }
            catch (CustomException)
            {
                throw new CustomException(CustomException.ExceptionType.NULL_RIDES, "Rides Are Null");
            }
        }
        public Ride[] GetRides(string userid)
        {
            try
            {
                return this.user[userid].ToArray();
            }
            catch (Exception)
            {
                throw new CustomException(CustomException.ExceptionType.INVALID_USER_ID, "Invalid UserID");
            }
        }
        public EnhancedInvoice UserInvoice(string userid)
        {
            CabInvoiceClass invoiceGenerator = new CabInvoiceClass(RideType.NORMAL);
            Console.WriteLine("UserID: " + userid);
            return invoiceGenerator.MultipleRides(GetRides(userid));
        }
    }
}
