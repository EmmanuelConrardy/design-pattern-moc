using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DeveloperKataDesign.Test
{
    [TestClass]
    public class DeveloperTest
    {
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

        private Computer CreateComputer() {
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
    }
}
