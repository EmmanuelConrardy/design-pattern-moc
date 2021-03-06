using DeveloperKataDesign;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace DeveloperKataDesign.Test
{
    [TestClass]
    public class DeveloperTest
    {
        private const int EnnergyNeedCoffee = 1;
        private const int SkillCraftmen = 1;

        [TestMethod]
        public void DevGetTaskDone()
        {
            //Arrange 
            var maurice = new Developer();
            var computer = CreateComputer();
            maurice.Attach(computer);
            var task = new Task(2);
            maurice.Assign(task);
            // Act
            maurice.DoWork();
            // Assert 
            Assert.AreEqual(0, maurice.GetRemainingPoints());
            Assert.AreEqual(3, maurice.GetEnergy());
        }

        [TestMethod]
        public void DevStateIsLowPerformanceDividedByTwo()
        {
            //Arrange 
            var maurice = new Developer(2, 3);
            var computer = CreateComputer(); // With score of 10
            maurice.Attach(computer);
            var task = new Task(10);
            maurice.Assign(task);
            // Act
            maurice.DoWork();
            // Assert 
            Assert.AreEqual(1, maurice.GetEnergy());
            Assert.AreEqual(4, maurice.GetRemainingPoints());
        }

        [TestMethod]
        public void DeveloperDrinkCoffee()
        {
            // Arrange
            Developer maurice = new Developer();
            var megaCoffee = CreateMagicCoffee();
            var drinks = new List<Drink>();
            drinks.Add(megaCoffee);
            maurice.AddDrinks(drinks);

            // Act
            maurice.DrinkDrink();

            // Assert
            Assert.AreEqual(28, maurice.GetEnergy());
        }

        [TestMethod]
        public void DevWorkAndDrinkCoffee()
        {
            // Arrange
            Developer maurice = new Developer(2, 2);
            var megaCoffee = CreateMagicCoffee();
            var drinks = new List<Drink>();
            drinks.Add(megaCoffee);
            maurice.AddDrinks(drinks);
            var computer = CreateComputer(); // With score of 10
            maurice.Attach(computer);
            var task = new Task(10);
            maurice.Assign(task);

            // Act
            maurice.DoWork();
            maurice.DoWork();

            // Assert
            Assert.AreEqual(23, maurice.GetEnergy());
            Assert.AreEqual(4, maurice.GetRemainingPoints());
        }

        [TestMethod]
        public void DevWork_IsDead_When_Energy_Is_Below_10()
        {
            //Arrange
            var maurice = new Developer(1, 1);
            var computer = CreateComputer();
            maurice.Attach(computer);
            maurice.Assign(new Task(int.MaxValue));

            maurice.DoWork();//-1
            maurice.DoWork();//-3
            maurice.DoWork();//-5
            maurice.DoWork();//-7
            maurice.DoWork();//-9

            //Act
            maurice.DoWork();//RIP

            //Assert
            Assert.AreEqual(-11, maurice.GetEnergy());
            Assert.IsTrue(maurice.IsDead);
        }

        private Drink CreateMagicCoffee()
        {
            var expresso = new Expresso();
            var expressoWhisky = new WhiskyTopping(expresso);
            var expressoWhiskyChocolate = new ChocolateTopping(expressoWhisky);
            var expressoWhiskyChocolateChantilly = new ChantillyTopping(expressoWhiskyChocolate);
            return expressoWhiskyChocolateChantilly;
        }

        private Computer CreateComputer()
        {
            var computer = new Computer();
            var motherBoard = new MotherBoard();
            var cpu1 = new CPU(1.5);
            var cpu2 = new CPU(1.5);
            var cpu3 = new CPU(1.5);
            var cpu4 = new CPU(1.5);
            motherBoard.AddComponent(cpu1);
            motherBoard.AddComponent(cpu2);
            motherBoard.AddComponent(cpu3);
            motherBoard.AddComponent(cpu4);
            var memory = new Memory();
            var ram1 = new Ram(1);
            var ram2 = new Ram(1);
            memory.AddComponent(ram1);
            memory.AddComponent(ram2);
            var graphicCard = new GraphicCard(2);
            computer.AddComponent(motherBoard);
            computer.AddComponent(graphicCard);
            computer.AddComponent(memory);

            return computer;
        }

        [TestMethod]
        public void DeveloperGoToToiletWhen3Coffees()
        {
            // Arrange
            Developer maurice = new Developer();
            var expresso = new Expresso();
            var computer = new Computer();
            var drinks = new List<Drink>();
            var task = new Task(42);

            drinks.Add(expresso);
            drinks.Add(expresso);
            drinks.Add(expresso);
            maurice.Attach(computer);

            maurice.AddDrinks(drinks);

            maurice.Assign(task);

            // Act
            while (maurice.drinksEnumerator.Current != null)
            {
                maurice.DoWork();
            }
            // Assert
            Assert.AreEqual(3, maurice.drinkTaken);
            Assert.AreEqual(typeof(GoToToilet), maurice.CurrentState.GetType());
        }

        [TestMethod]
        public void DeveloperDiedByArsenic()
        {
            // Arrange
            Developer maurice = new Developer(SkillCraftmen, EnnergyNeedCoffee);
            maurice.Attach(new Computer());
            maurice.Assign(new Task(42));

            var drinks = new List<Drink>();
            var expresso = new Expresso();
            var expressonArsenic = new ArsenicTopping(expresso);
            drinks.Add(expressonArsenic);
            maurice.AddDrinks(drinks);

            // Act
            maurice.DoWork();
            maurice.DoWork();

            // Assert
            Assert.IsTrue(maurice.IsDead);
            Assert.AreEqual(-46,maurice.GetEnergy());
        }

        [TestMethod]
        public void DeveloperUseQuanticComputer()
        {
            // Arrange
            Developer maurice = new Developer(SkillCraftmen, 5);
            maurice.Assign(new Task(42));
            var computer = new Computer();
            var godMotherBoard = new GodMotherBoard();
            var godCPU = new GodCPU();
            godMotherBoard.AddComponent(godCPU);
            computer.AddComponent(godMotherBoard);
            maurice.Attach(computer);

            // Act
            maurice.DoWork();

            // Assert
            Assert.AreEqual(0, maurice.GetRemainingPoints());
        }
    }
}
