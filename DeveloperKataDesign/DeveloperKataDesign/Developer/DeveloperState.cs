// Given a skill level 3 Dev with 5 energies
// And his state is normal
// And a working computer attach to him with an efficiency of 2
// And a Task with 12 remaining points
// When he work on it
// Then his energies equal 3
// And his state is low
// And the task has 7 remaining points
using System;

namespace DeveloperKataDesign
{
    public abstract class DeveloperState
    {
        public virtual int Work(Developer developer)
        {
            throw new NotImplementedException();
        }
    }

    public class Normal: DeveloperState
    {
        public override int Work(Developer developer)
        {
            return developer.GetProductivity();
        }

    }

    public class Low : DeveloperState
    {
        public override int Work(Developer developer)
        {
            return developer.GetProductivity()/2;
        }
    }
}