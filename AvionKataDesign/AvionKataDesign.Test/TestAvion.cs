using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AvionKataDesign.Test
{
    [TestClass]
    public class TestAvion
    {
        [TestMethod]
        public void Test_Avion_Singleton()
        {
            //Arrange
            var avion = Avion.GetInstance();
            var avion2 = Avion.GetInstance();

            //Assert
            Assert.AreSame(avion, avion2);
        }

        [TestMethod]
        public void Test_When_Avion_Emit_Position_Radar_Should_Return_Message()
        {
            //Arrange
            var avion = Avion.GetInstance();
            var tourDeControle = new TourDeControle();
            avion.Attach(tourDeControle);
            
            //Act
            avion.EmitPosition();

            //Assert
            Assert.AreEqual("0,0", tourDeControle.GetMessagePosition());
        }
    }
}
