using DeveloperKataDesign;
using System;

namespace DeveloperKataDesignSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start a Developer day in this happy world");
            Console.WriteLine("Press any button to continue.");
            Console.ReadKey();

            Console.WriteLine("Here it's Maurice our best (only) developer!");
            Console.WriteLine("Set his skill (1,2,3...)");
            var skillInfo = Console.ReadKey();
            var skill = int.Parse(skillInfo.KeyChar.ToString());

            Console.WriteLine("Set his energy ([0..100])");
            var energyInfo = Console.ReadKey();
            var energy = int.Parse(energyInfo.KeyChar.ToString());
            var maurice = new Developer(skill, energy);

            Console.WriteLine("good! now press any button and maurice will sit to his desk");
            Console.ReadKey();

            //Attach computer

            //Attach task

            //Do work until task is done !
        }
    }
}
