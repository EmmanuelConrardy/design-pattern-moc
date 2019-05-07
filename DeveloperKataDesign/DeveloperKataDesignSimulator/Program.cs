using DeveloperKataDesign;
using System;
using System.Collections.Generic;
using System.Threading;

namespace DeveloperKataDesignSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start a Developer day in this happy world");
            Console.WriteLine("Press any button to continue.");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Here it's Maurice our best (only) developer!");
            Console.WriteLine("Set his skill (1=craftmen, 2=gardener, 3=guru,...)");
            var skillInfo = Console.ReadKey();
            Console.WriteLine();
            var skill = int.Parse(skillInfo.KeyChar.ToString());

            Console.WriteLine("Set his energy ([0 = Almost dead...100 = Maximum effort !])");
            var energyInfo = Console.ReadLine();
            Console.WriteLine();
            var energy = int.Parse(energyInfo);
            var maurice = new Developer(skill, energy);

            Console.WriteLine("good! now press any button and maurice will go to his desk");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Maurice :\"I'm going on a andventure !!\"");
            
            //Attach computer
            Console.WriteLine("Maurice need a computer before starting his journey (1=MS Surface Book, 2=Macbook Pro");
            var computerKey = Console.ReadLine();
            Console.WriteLine();
            var computerId = int.Parse(computerKey);
            var computer = CreateComputer(computerId);
            maurice.Attach(computer);

            //Attach task
            Console.WriteLine("Help Maurice to select a new task (0=No effort,....,100=Nightmare)");
            var taskKey = Console.ReadLine();
            Console.WriteLine();
            var taskEffort = int.Parse(taskKey);
            var task = new Task(taskEffort);
            maurice.Assign(task);

            //Coffee ?
            Console.WriteLine("Should we help maurice with some coffee ? (0=No,....,10=Yes a lot !)");
            var coffeeKey = Console.ReadLine();
            Console.WriteLine();
            var coffeeSupply = int.Parse(coffeeKey);
            var coffeeArmy = CreateCoffees(coffeeSupply);
            maurice.AddDrinks(coffeeArmy);

            //Do work until task is done !
            do
            {
                Console.WriteLine("Maurice doing stuff...");
                maurice.DoWork();
                Thread.Sleep(1000);
                Console.WriteLine($"Maurice energy {maurice.GetEnergy()}");
                Console.WriteLine($"Maurice remainingPoint {maurice.GetRemainingPoints()}");
            }
            while (!maurice.IsDead && maurice.GetRemainingPoints() > 0);

            if(maurice.IsDead){
                Console.WriteLine("Maurice died working on a task RIP...");
            }else{
                Console.WriteLine("Maurice get thing done !");
            }
        }

        private static List<Drink> CreateCoffees(int coffeeSupply){
            var drinks = new List<Drink>();
            if(coffeeSupply < 10){
                for (int i = 0; i < coffeeSupply; i++)
                {
                    drinks.Add(new Expresso());
                }
            }
            else{
                for (int i = 0; i < coffeeSupply; i++)
                {
                    drinks.Add(new WhiskyTopping(new Expresso()));
                }
            }
            return drinks;
        }
        private static Computer CreateComputer(int computerId){
            if(computerId == 1)
                return MSSurfaceBook(); // 10 score
            else if (computerId == 2)
                return MacbookPro(); // 8 score
            
            Console.WriteLine("Ooops!");
            return MissClick(); // ??
        }

        private static Computer MSSurfaceBook(){
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

        private static Computer MacbookPro(){
            var computer = new Computer();
            var motherBoard = new MotherBoard();
            var cpu1 = new CPU(1.5);
            var cpu2 = new CPU(1.5);
            var cpu3 = new CPU(1);
            var cpu4 = new CPU(1);
            motherBoard.AddComponent(cpu1);
            motherBoard.AddComponent(cpu2);
            motherBoard.AddComponent(cpu3);
            motherBoard.AddComponent(cpu4);
            var memory = new Memory();
            var ram1 = new Ram(1);
            var ram2 = new Ram(1);
            memory.AddComponent(ram1);
            memory.AddComponent(ram2);
            var graphicCard = new GraphicCard(1);
            computer.AddComponent(motherBoard);
            computer.AddComponent(graphicCard);
            computer.AddComponent(memory);
            return computer;
        }

        private static Computer MissClick(){
            var computer = new Computer();
            var motherBoard = new MotherBoard();
            var cpu1 = new CPU(1);
            motherBoard.AddComponent(cpu1);
            computer.AddComponent(motherBoard);
            return computer;
        }
    }
}
