using Microsoft.VisualStudio.TestTools.UnitTesting;
using TripServiceKata.Trip;
using TripServiceKata.User;

namespace TripServicesKata.Test
{

    [TestClass]
    public class TripServiceTest
    {
        public const User UserAnonyme = null;

        [TestMethod]
        public void When_User_Is_Anonyme_Should_Return_No_Trip()
        {
            var tripService = new TripService();
            
            var trips = tripService.GetTripsByUser(UserAnonyme);

            Assert.AreEqual(0, trips.Count);
        }
    }
}
