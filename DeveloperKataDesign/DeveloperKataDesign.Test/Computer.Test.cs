using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DeveloperKataDesign.Test
{
    [TestClass]
    public class ComputerTest
    {
        [TestMethod]
        public void ComputerAddComponent()
        {
            // Arrange
            var computer = new Computer();
            var hardDrive = new HardDrive();
            computer.AddComponent(hardDrive);
            // Act
            var result = computer.GetComponents();
            // Assert
            Assert.AreEqual(1, result.Count);
        }

        [TestMethod]
        public void ComputerAddMotherBoardWithFourCPU()
        {
            // Arrange
            var computer = new Computer();
            var motherBoard = new MotherBoard();
            var cpu1 = new CPU();
            var cpu2 = new CPU();
            var cpu3 = new CPU();
            var cpu4 = new CPU();
            computer.AddComponent(motherBoard);
            motherBoard.AddComponent(cpu1);
            motherBoard.AddComponent(cpu2);
            motherBoard.AddComponent(cpu3);
            motherBoard.AddComponent(cpu4);

            // Act
            var result = computer.GetComponentsCount();
            // Assert
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void ComputerScoring()
        {
            // Arrange
            var commputerBuilder = new ComputerBuilder();
            var computer = commputerBuilder
                             .WithMotherBoard(new CPU(1.5), new CPU(1.5), new CPU(1.5), new CPU(1.5))
                             .WithMemory(new Ram(1), new Ram(1))
                             .WithGraphicCard(2)
                            .Build();

            // Act
            var result = computer.GetScore();

            // Assert
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void ComputerQuanticShouldKnowTheAnswer()
        {
            // Arrange
            var computerBuilder= new ComputerBuilder();
            var computer = computerBuilder
                .WithGodMotherBoard(new GodCPU())
                .Build();

            // Act
            var result = computer.GetScore();

            // Assert
            Assert.AreEqual(int.MaxValue, result);
        }

        [TestMethod]
        public void ComputerBuilder_WithMotherBoard()
        {
            // Arrange
            var commputerBuilder = new ComputerBuilder();
            var computer = commputerBuilder
                             .WithMotherBoard(new CPU(1.5))
                             .WithMemory(new Ram(1.5))
                             .WithGraphicCard(2)
                            .Build();

            // Act
            var result = computer.GetScore();

            // Assert
            Assert.AreEqual(5, result);
        }
    }
}
