using System;
using System.Collections.Generic;
using System.Linq;
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

        [TestMethod]
        public void Test_When_Avion_With_Pilotes_Stewart_Passengers()
        {
            //Arrange
            var avion = Avion.GetInstance();
            var passengers = new List<Human> {
                new Pilote(),
                new Pilote(),
                new Stewart(),
                new Passenger(),
                new Passenger(),
                new Passenger()
            };

            //Act
            avion.BoardingWith(passengers);

            //Assert
            Assert.AreEqual(6, avion.DisplayHumanOnBoard().Count());
        }

        [TestMethod]
        public void Test_Pilote()
        {
            var pilote = new Pilote();

            Assert.IsTrue(pilote.CanAccessToCockpit);
        }

        [TestMethod]
        public void Test_Passenger()
        {
            var passenger = new Passenger();

            Assert.IsFalse(passenger.CanAccessToCockpit);
        }

        [TestMethod]
        public void Test_Stewart()
        {
            var stewart = new Stewart();

            Assert.IsFalse(stewart.CanAccessToCockpit);
        }
    }

    
}
