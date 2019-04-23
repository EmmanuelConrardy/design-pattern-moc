using Microsoft.VisualStudio.TestTools.UnitTesting;
using DeveloperKataDesign;
using System.Collections.Generic;
using System.Linq;
using System;

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

            // Act
            var result = computer.GetScore();
            // Assert
            Assert.AreEqual(10, result);

        }
    }

    public class GraphicCard : Component
    {
        public GraphicCard(double score = 0.2) : base(score)
        {
        }
    }

    public class Ram : Component
    {
        public Ram(double score = 0.2) : base(score)
        {
        }
    }

    public class Memory: Component
    {
    }

    public class CPU : Component
    {
        public CPU(double score = 0.2) : base(score)
        {
        }
    }

    public class MotherBoard: Component
    {
    }

    public class Computer : Component
    {
        
    }

    public abstract class Component {
        private List<Component> components;
        private double score;

        public Component(double score = 0.2)
        {
            components = new List<Component>();
            this.score = score;
        }

        public void AddComponent(Component component) {
            components.Add(component);
        }

        public List<Component> GetComponents() {
            return components;
        }

        public int GetComponentsCount()
        {
            int count = components.Count;
            foreach (var component in components)
            {
                count += component.GetComponentsCount();
            }
            return count;
        }

        public double GetScore()
        {
            double score = 0;
            if (components.Count == 0)
            {
                return this.score;
            }

            foreach (var component in components)
            {
                score += component.GetScore();
            }
            return score;
        }

        //getChildren
    }

    public class HardDrive: Component {

    }
}
