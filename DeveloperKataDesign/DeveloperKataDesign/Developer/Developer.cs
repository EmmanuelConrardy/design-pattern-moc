// Given a skill level 3 Dev with 5 energies
// And his state is normal
// And a working computer attach to him with an efficiency of 2
// And a Task with 12 remaining points
// When he work on it
// Then his energies equal 3
// And his state is low
// And the task has 7 remaining points
using DeveloperKataDesign.Coffee;
using System;
using System.Collections.Generic;

namespace DeveloperKataDesign
{
    public class Developer {
        private DeveloperState state { get; set; }
        private Computer computer;
        private int energy;
        private int skill;
        private Task task;
        public List<Drink> drinks;
        public IEnumerator<Drink> drinksEnumerator;

        public Developer(int skill = 1, int energy = 5)
        {
            this.skill = skill;
            this.energy = energy;
            drinks = new List<Drink>();
            drinksEnumerator = drinks.GetEnumerator();
            this.EvaluateState();
        }

        public void AddDrinks(List<Drink> drinks)
        {
            this.drinks.AddRange(drinks);
            this.drinksEnumerator = this.drinks.GetEnumerator();
            drinksEnumerator.MoveNext();
        }

        public void Assign(Task task)
        {
            this.task = task;
        }

        public void DoWork()
        {
            task.RemainingPoints -= this.state.Work(this);
            this.EvaluateState();
        }

        public int GetRemainingPoints()
        {
            return task.RemainingPoints < 0 ? 0 : task.RemainingPoints;
        }

        public int GetEnergy()
        {
            return energy;
        }

        public void Attach(Computer computer)
        {
            this.computer = computer;
        }

        private void EvaluateState()
        {
            if (energy <= 1)
            {
                this.state = new NeedCoffee();
            }
            else if(IsLow())
            {
                this.state = new Low();
            } else
            {
                this.state = new Normal();
            }
        }

        public void DrinkDrink()
        {
            var currentDrink = drinksEnumerator.Current;
            energy += currentDrink.GetBoost();
            drinksEnumerator.MoveNext();
        }

        private bool IsLow()
        {
            return this.energy < 5;
        }

        public int GetProductivity()
        {
            return this.skill + (int) this.computer.GetScore();
        }

        public void ReduceEnergy(int energyToReduce)
        {
            energy -= energyToReduce;
        }
    }
}
// Hello :)