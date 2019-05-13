using DeveloperKataDesign;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeveloperKataDesign.Test
{
    [TestClass]
    public class Coffee
    {
        [TestMethod]
        public void ExpressoReturnABoostOfFive()
        {
            //Arrange
            var expresso = new Expresso();

            //Act
            var result = expresso.GetBoost();

            //Assert
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void FilteredReturnABoostOfThree()
        {
            //Arrange
            var filtered = new Filtered();

            //Act
            var result = filtered.GetBoost();

            //Assert
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void ExpressoWhiskyReturnABoostOfFifteen()
        {
            //Arrange
            var expresso = new Expresso();
            var expressoWhisky = new WhiskyTopping(expresso);

            //Act
            var result = expressoWhisky.GetBoost();


            //Assert
            Assert.AreEqual("Whisky Expresso", expressoWhisky.GetName());
            Assert.AreEqual(15, result);
        }


        [TestMethod]
        public void ExpressoWhiskyChocolateReturnABoostOfTwenty()
        {
            //Arrange
            var expresso = new Expresso();
            var expressoWhisky = new WhiskyTopping(expresso);
            var expressoWhiskyChocolate = new ChocolateTopping(expressoWhisky);

            //Act
            var result = expressoWhiskyChocolate.GetBoost();


            //Assert
            Assert.AreEqual("Chocolate Whisky Expresso", expressoWhiskyChocolate.GetName());
            Assert.AreEqual(20, result);
        }

        [TestMethod]
        public void ExpressoWhiskyChocolateChantillyReturnABoostOfTwentyThree()
        {
            //Arrange
            var expresso = new Expresso();
            var expressoWhisky = new WhiskyTopping(expresso);
            var expressoWhiskyChocolate = new ChocolateTopping(expressoWhisky);
            var expressoWhiskyChocolateChantilly = new ChantillyTopping(expressoWhiskyChocolate);

            //Act
            var result = expressoWhiskyChocolateChantilly.GetBoost();


            //Assert
            Assert.AreEqual("Chantilly Chocolate Whisky Expresso", expressoWhiskyChocolateChantilly.GetName());
            Assert.AreEqual(23, result);
        }
        
        [TestMethod]
        public void ExpressoWithArsenic()
        {
            //Arrange
            var expresso = new Expresso();
            var expressoArsenic = new ArsenicTopping(expresso);

            //Act
            var result = expressoArsenic.GetBoost();

            //Assert
            Assert.AreEqual("Arsenic Expresso", expressoArsenic.GetName());
            Assert.AreEqual(-45, result);
        }

        [TestMethod]
        public void ExpressoWithArsenicSong()
        {
            //Arrange
            var expresso = new Expresso();
            var expressoArsenic = new ArsenicTopping(expresso);

            //Act
            var result = expressoArsenic.Song();

            //Assert
            Assert.AreEqual("Run https://www.youtube.com/watch?v=-G3MLjqicC8", result);
        }
    }
}
