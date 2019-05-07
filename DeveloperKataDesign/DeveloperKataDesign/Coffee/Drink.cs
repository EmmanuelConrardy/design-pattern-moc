using System;
using System.Collections.Generic;
using System.Text;

namespace DeveloperKataDesign
{
    public abstract class Drink
    {
        protected int boost;
        protected String name;

        public virtual int GetBoost()
        {
            return this.boost;
        }

        public virtual String GetName()
        {
            return this.name;
        }
    }
}
